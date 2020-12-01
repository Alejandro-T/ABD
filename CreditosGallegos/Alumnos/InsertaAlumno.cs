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
            seleccionacomboGenero();
            seleccionacomboCarreras();
        }
        public void actualizasecuencia()
        {
            // OracleCommand loCmd = Conexion.conectar().CreateCommand();
            // loCmd.CommandType = CommandType.Text;
            // loCmd.CommandText = "select seq_entrena_id_entrena.nextval from dual";
            // long lnNextVal = Convert.ToInt64(loCmd.ExecuteScalar());
            // textBox1.Text = lnNextVal.ToString();
        }
        public void seleccionacomboGenero()
        {
            DataTable dt = new DataTable();

            string depto = "SELECT id_genero,descripcion FROM generos";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(dt);
            if (dr.Read())
            {
                if (dr.HasRows)
                {
                    comboBoxGenero.Items.Clear();
                    while (dr.Read())
                    {
                        comboBoxGenero.DataSource = dt;
                        comboBoxGenero.DisplayMember = dt.Columns[1].ColumnName;
                        comboBoxGenero.ValueMember = dt.Columns[0].ColumnName;
                    }
                    comboBoxGenero.SelectedIndex = 1;
                    Conexion.cerrar();
                }
            }
            else
            {
                comboBoxGenero.Items.Add("Ningun valor");
                comboBoxGenero.SelectedIndex = 0;
                Conexion.cerrar();
            }
        }


        public void seleccionacomboCarreras()
        {


            DataTable dt = new DataTable();

            string depto = "SELECT id_carrera,id_tec,nombre FROM carreras where ID_TEC ='" + this.textBoxTec.Text + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(dt);
            if (dr.Read())
            {


                comboBoxCarreras.Items.Clear();
                while (dr.Read())
                {
                    comboBoxCarreras.DataSource = dt;
                    comboBoxCarreras.DisplayMember = dt.Columns[2].ColumnName;
                    comboBoxCarreras.ValueMember = dt.Columns[0].ColumnName;
                }

                //comboBoxDepartamento.SelectedIndex = 0;
                Conexion.cerrar();

            }
            else
            {
                comboBoxCarreras.Items.Add("Ningun valor");
                comboBoxCarreras.SelectedIndex = 0;
                Conexion.cerrar();
            }

        }
        public void cargarAlumno(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "Select * from alumnos where NO_CONTROL='" + publicas.id_alumno.ToString() + "'";
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

        private void button1_Click(object sender, EventArgs e)
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


                    this.cargarAlumno(this.dataGridViewEntrenadores);
                    //actualizasecuencia();
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
    }
}
