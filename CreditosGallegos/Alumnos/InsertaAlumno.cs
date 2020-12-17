using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditosGallegos.Alumnos
{
    public partial class InsertaAlumno : Form
    {
        public InsertaAlumno()
        {
            InitializeComponent();
        }

        private void InsertaAlumno_Load(object sender, EventArgs e)
        {
            textBoxTec.Text = publicas.id_tec.ToString();
            SeleccionacomboGenero();
            SeleccionacomboCarreras();
        }
        public void actualizasecuencia()
        {
            // OracleCommand loCmd = Conexion.conectar().CreateCommand();
            // loCmd.CommandType = CommandType.Text;
            // loCmd.CommandText = "select seq_entrena_id_entrena.nextval from dual";
            // long lnNextVal = Convert.ToInt64(loCmd.ExecuteScalar());
            // textBox1.Text = lnNextVal.ToString();
        }
        public void SeleccionacomboGenero()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "SELECT id_genero,descripcion FROM generos";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);

            if(dr.Read()){
                comboBoxGenero.DataSource = ds.Tables[0];
                comboBoxGenero.DisplayMember = "descripcion";
                comboBoxGenero.ValueMember = "id_genero";
            }
            else
            {
                MessageBox.Show("no hay generos existentes");
            }
        }


        public void SeleccionacomboCarreras()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "SELECT id_carrera,id_tec,nombre FROM carreras where ID_TEC ='" + this.textBoxTec.Text + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);
            if (dr.Read())
            {


                comboBoxCarreras.DataSource = ds.Tables[0];
                comboBoxCarreras.DisplayMember = "nombre";
                comboBoxCarreras.ValueMember = "id_carrera";

            }
            else
            {
                MessageBox.Show("no hay Carreras existentes");
                Conexion.cerrar();
            }
        }
        public void CargarAlumno(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "Select A.NO_CONTROL,A.NOMBRE,A.PATERNO,A.MATERNO,G.DESCRIPCION AS SEXO ,C.NOMBRE AS CARRERA from alumnos A JOIN GENEROS G ON A.ID_GENERO=G.ID_GENERO JOIN CARRERAS C ON A.ID_CARRERA = C.ID_CARRERA where NO_CONTROL='" + publicas.id_alumno.ToString() + "' order by no_control";
            OracleDataAdapter da = new OracleDataAdapter
                (comprobacion, Conexion.conectar());
            OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
            OracleDataReader dr = cp.ExecuteReader();
            if (dr.Read())
            {
                da.Fill(dtsgenero);
                dvg.DataSource = dtsgenero;
            }
            else
            {
                MessageBox.Show("El Alumno no existe", "aviso", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {           
                string comprobacion =
              "SELECT id_tec from tecsnm where id_tec='" + textBoxTec.Text + "'";
                OracleCommand cpp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader drp = cpp.ExecuteReader();
                if (drp.Read())
                {
                    string comp = "Select seq_alum_id_alum.nextval from dual";
                    OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
                    publicas.id_alumno = Convert.ToInt32(cpe.ExecuteScalar());

                    OracleCommand comandoinse = new OracleCommand("insertar_alumno", Conexion.conectar());
                    comandoinse.CommandType = CommandType.StoredProcedure;

                    comandoinse.Parameters.Add("@no_control", OracleDbType.Int32).Value = publicas.id_alumno.ToString();
                    comandoinse.Parameters.Add("@id_genero", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxGenero.SelectedValue);
                    comandoinse.Parameters.Add("@ID_CARRERA", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxCarreras.SelectedValue);
                    comandoinse.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxTec.Text;
                    //

                    comandoinse.Parameters.Add("@nombre", OracleDbType.Varchar2).Value = this.textBoxName.Text;
                    comandoinse.Parameters.Add("@paterno", OracleDbType.Varchar2).Value = this.textBoxPaterno.Text;
                    comandoinse.Parameters.Add("@materno", OracleDbType.Varchar2).Value = this.textBoxMaterno.Text;


                    comandoinse.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el numero actual.


                    this.CargarAlumno(this.dataGridViewEntrenadores);
                    //actualizasecuencia();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("no existe el tec", "aviso", MessageBoxButtons.OK);
                }
            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1722:
                        MessageBox.Show("Numero invalido(FormatException)--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
                    case 2292:
                        MessageBox.Show("No se puede eliminar el dato, porque existe una tabla hijo con ese dato", "Aviso", MessageBoxButtons.OK);
                        break;
                    default:
                        MessageBox.Show("Formato invalido--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
                }
            }
        }
        public static int obtenerId()
        {
            int numero = 0;
            DataTable dtsgenero = new DataTable();
            string comp = "Select no_control from (select * from alumnos order by no_control desc ) where rownum = 1";
            

            OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
            OracleDataReader dre = cpe.ExecuteReader();
            if (dre.Read())
            {
               
                numero = Convert.ToInt32(cpe.ExecuteScalar());
                MessageBox.Show("Insertado con la matricula: " + numero+"");
                return numero;
            }
            else
                return 0;     
        }
        public void Limpiar()
        {
            this.textBoxName.Clear();
            this.textBoxMaterno.Clear();
            this.textBoxPaterno.Clear();
            
        }

        private void DataGridViewEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewEntrenadores.Rows[e.RowIndex];
                this.textBoxName.Text = row.Cells["nombre"].Value.ToString();
                this.textBoxPaterno.Text = row.Cells["paterno"].Value.ToString();
                this.textBoxMaterno.Text = row.Cells["materno"].Value.ToString();

            }
        }
    }
}
