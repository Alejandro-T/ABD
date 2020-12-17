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
    public partial class MantenimientoArmEq : Form
    {
        public MantenimientoArmEq()
        {
            InitializeComponent();
        }

        private void MantenimientoArmEq_Load(object sender, EventArgs e)
        {
            this.textBoxId_tec.Text = publicas.id_tec.ToString();
            SeleccionacomboEq();
            CargarArmEq(this.dataGridViewArmEq);
        }

        public void SeleccionacomboEq()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "select id_equipo,nombre from EQUIPOSDEPORTIVOS where ID_TEC ='" + this.textBoxId_tec.Text + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);
            if (dr.Read())
            {


                comboBoxEquipos.DataSource = ds.Tables[0];
                comboBoxEquipos.DisplayMember = "nombre";
                comboBoxEquipos.ValueMember = "id_equipo";

            }
            else
            {
                MessageBox.Show("no hay Equipos existentes");
                Conexion.cerrar();
            }
        }

        public void CargarArmEq(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "select A.NO_CONTROL,A.NOMBRE AS NOMBRE_ALUMNO,A.PATERNO AS PATERNO_ALUMNO,A.MATERNO AS MATERNO_ALUMNO,EQ.NOMBRE AS NOMBRE_EQUIPO,EQ.id_equipo FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS AE JOIN ALUMNOS A ON AE.ALUMNOS_NO_CONTROL = A.NO_CONTROL JOIN EQUIPOSDEPORTIVOS EQ ON AE.EQUIPOSDEPORTIVOS_ID_EQUIPO = EQ.ID_EQUIPO where AE.ID_TEC='" + publicas.id_tec.ToString() +"'";
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
        public void Limpiar()
        {
            this.textBoxId_Alumno.Clear();
            
            
        }

        private void DataGridViewArmEq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewArmEq.Rows[e.RowIndex];
                this.textBoxId_Alumno.Text = row.Cells["NO_CONTROL"].Value.ToString();

                this.comboBoxEquipos.SelectedValue = row.Cells["id_equipo"].Value.ToString();
                publicas.id_Ag_equipo = Convert.ToInt32(comboBoxEquipos.SelectedValue.ToString());
               // MessageBox.Show(publicas.id_Ag_equipo.ToString());
            }
        }

        private void PictureBoxClean_Click(object sender, EventArgs e) => Limpiar();

        private void PictureBoxDrop_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS where ALUMNOS_NO_CONTROL='" + textBoxId_Alumno.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "' and  EQUIPOSDEPORTIVOS_ID_EQUIPO='" + this.comboBoxEquipos.SelectedValue + "'";

                string comprobacion =
                    "SELECT NO_CONTROL from alumnos where NO_CONTROL='" + textBoxId_Alumno.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.CargarArmEq(this.dataGridViewArmEq);
                    //limpiar los cuadros de texto
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("El Alumno no existe no existe", "aviso", MessageBoxButtons.OK);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SelectArmEq sAr = new SelectArmEq();
            sAr.Show();
                
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from tecsnm where id_tec='" + textBoxId_tec.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZEQAGRE", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;

                act.Parameters.Add("ALUMNOS_NO_CONTROLIN", OracleDbType.Int16).Value = textBoxId_Alumno.Text;
                act.Parameters.Add("EQUIPOSDEPORTIVOS_ID_EQUIPOIN", OracleDbType.Int16).Value = Convert.ToInt16(publicas.id_Ag_equipo.ToString());
                act.Parameters.Add("EQUIPOSDEPORTIVOS_NUEVO", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxEquipos.SelectedValue);
                
                //aaaa
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                //
                string comprobacion2 =
                    "SELECT ALUMNOS_NO_CONTROL from ALUMNOS_HAS_EQUIPOSDEPORTIVOS where ALUMNOS_NO_CONTROL='" + textBoxId_Alumno.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                OracleDataReader dr2 = cp2.ExecuteReader();

                if (dr.Read())
                {
                    if (dr2.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                        this.CargarArmEq(this.dataGridViewArmEq);
                        this.Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El Alumno no existe no existe", "aviso", MessageBoxButtons.OK);
                    }

                }

                else
                {
                    MessageBox.Show("Error en la llave foranea de Tecsnm", "aviso", MessageBoxButtons.OK);
                }

                //aaaa
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
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
