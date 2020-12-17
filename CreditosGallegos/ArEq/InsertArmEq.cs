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

namespace CreditosGallegos.ArEq
{
    public partial class InsertArmEq : Form
    {
        public InsertArmEq()
        {
            InitializeComponent();
        }
        public void SeleccionacomboEq()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "select id_equipo,nombre from EQUIPOSDEPORTIVOS where ID_TEC ='" + this.textBoxid_tec.Text + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);
            if (dr.Read())
            {


                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "nombre";
                comboBox1.ValueMember = "id_equipo";

            }
            else
            {
                MessageBox.Show("no hay Equipos existentes");
                Conexion.cerrar();
            }
        }
        private void BtnAgreagrCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobacion =
               "SELECT NO_CONTROL from alumnos where id_tec='" + textBoxid_tec.Text + "' and NO_CONTROL='"+this.textBoxMatriculaAl.Text+"'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                   

                    OracleCommand comando = new OracleCommand("insertar_Arm_Eq", Conexion.conectar());
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@ALUMNOS_NO_CONTROL", OracleDbType.Int32).Value = this.textBoxMatriculaAl.Text;
                    comando.Parameters.Add("@EQUIPOSDEPORTIVOS_ID_EQUIPO", OracleDbType.Int32).Value = comboBox1.SelectedValue;
                    comando.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxid_tec.Text;
                    

                    comando.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el numero actual.
                    this.CargarArmEq(this.dataGridViewArmaEq);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("no existe Alumno", "aviso", MessageBoxButtons.OK);
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Formato invalido: " + ex);
            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1:
                        MessageBox.Show("No puedes agregar al mismo alumno otra vez en el mismo Equipo", "aviso");
                        break;
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

        public void CargarArmEq(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "select A.NO_CONTROL,A.NOMBRE,EQ.NOMBRE AS NOMBRE_EQUIPO FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS AE JOIN ALUMNOS A ON AE.ALUMNOS_NO_CONTROL = A.NO_CONTROL JOIN EQUIPOSDEPORTIVOS EQ ON AE.EQUIPOSDEPORTIVOS_ID_EQUIPO = EQ.ID_EQUIPO where AE.ALUMNOS_NO_CONTROL ='" + textBoxMatriculaAl.Text + "'";
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
                MessageBox.Show("El alumno no existe", "aviso", MessageBoxButtons.OK);
            }
        }

        private void InsertArmEq_Load(object sender, EventArgs e)
        {
            textBoxid_tec.Text = publicas.id_tec.ToString();
            SeleccionacomboEq();
        }

        private void DataGridViewArmaEq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewArmaEq.Rows[e.RowIndex];
                this.textBoxMatriculaAl.Text = row.Cells["NO_CONTROL"].Value.ToString();
              
            }
        }
        public void Limpiar()
        {
            this.textBoxMatriculaAl.Clear();
        }
    }
}
