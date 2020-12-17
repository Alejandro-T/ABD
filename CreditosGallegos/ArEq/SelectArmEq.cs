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
    public partial class SelectArmEq : Form
    {
        public SelectArmEq()
        {
            InitializeComponent();
        }

        private void SelectArmEq_Load(object sender, EventArgs e)
        {
            //cargarEquiposTodos(dataGridViewCargaAlumno);
            if (groupBox1.Enabled == true || groupBox2.Enabled == true)
            {

            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                this.groupBox1.Hide();
                this.groupBox2.Hide();
            }
        }
        public void SeleccionacomboEq()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "select id_equipo,nombre from EQUIPOSDEPORTIVOS where ID_TEC ='" + publicas.id_tec.ToString() + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);
            if (dr.Read())
            {


                comboBoxEquipo.DataSource = ds.Tables[0];
                comboBoxEquipo.DisplayMember = "nombre";
                comboBoxEquipo.ValueMember = "id_equipo";

            }
            else
            {
                MessageBox.Show("no hay Equipos existentes");
                Conexion.cerrar();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Show();
                groupBox2.Hide();
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                groupBox1.Hide();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                SeleccionacomboEq();
                groupBox2.Show();
                groupBox1.Hide();
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                groupBox2.Hide();
            }
        }


        public void CargarEquiposName(DataGridView dvg)
        {

            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select A.NO_CONTROL,A.NOMBRE,EQ.NOMBRE AS NOMBRE_EQUIPO,EQ.id_equipo FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS AE JOIN ALUMNOS A ON AE.ALUMNOS_NO_CONTROL = A.NO_CONTROL JOIN EQUIPOSDEPORTIVOS EQ ON AE.EQUIPOSDEPORTIVOS_ID_EQUIPO = EQ.ID_EQUIPO where AE.EQUIPOSDEPORTIVOS_ID_EQUIPO='" + this.comboBoxEquipo.SelectedValue + "' and AE.ID_TEC='" + publicas.id_tec.ToString() +"'";
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
                    dataGridViewCargaAlumno.DataSource = "";
                    MessageBox.Show("El alumno no existe", "aviso", MessageBoxButtons.OK);
                }
            }
            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaAlumno.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }

        }



        public void CargarEquiposTodos(DataGridView dvg)
        {

            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select A.NO_CONTROL,A.NOMBRE,EQ.NOMBRE AS NOMBRE_EQUIPO,EQ.id_equipo FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS AE JOIN ALUMNOS A ON AE.ALUMNOS_NO_CONTROL = A.NO_CONTROL JOIN EQUIPOSDEPORTIVOS EQ ON AE.EQUIPOSDEPORTIVOS_ID_EQUIPO = EQ.ID_EQUIPO WHERE AE.ID_TEC='" + publicas.id_tec.ToString()+"'";
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
                    dataGridViewCargaAlumno.DataSource = "";
                    MessageBox.Show("El alumno no existe", "aviso", MessageBoxButtons.OK);
                }
            }
            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaAlumno.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }

        }

        public void CargarEquipos(DataGridView dvg)
        {

            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select A.NO_CONTROL,A.NOMBRE,EQ.NOMBRE AS NOMBRE_EQUIPO,EQ.id_equipo FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS AE JOIN ALUMNOS A ON AE.ALUMNOS_NO_CONTROL = A.NO_CONTROL JOIN EQUIPOSDEPORTIVOS EQ ON AE.EQUIPOSDEPORTIVOS_ID_EQUIPO = EQ.ID_EQUIPO where AE.ALUMNOS_NO_CONTROL='" + this.textBoxSidAlumno.Text + "' and AE.ID_TEC='"+publicas.id_tec.ToString()+"'";
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
                    dataGridViewCargaAlumno.DataSource = "";
                    MessageBox.Show("El alumno no existe", "aviso", MessageBoxButtons.OK);
                }
            }

            
            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaAlumno.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void ButtonCbuscar_Click(object sender, EventArgs e) => CargarEquiposTodos(dataGridViewCargaAlumno);

        private void Btncbuscar_Click(object sender, EventArgs e) => CargarEquipos(dataGridViewCargaAlumno);

        int contador = 0;

        private void ComboBoxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                CargarEquiposName(dataGridViewCargaAlumno);
            }
            else
            {
                contador++;
            }
        }

        private void DataGridViewCargaAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCargaAlumno.Rows[e.RowIndex];
                this.textBoxSidAlumno.Text = row.Cells["NO_CONTROL"].Value.ToString();

                this.comboBoxEquipo.SelectedValue = row.Cells["id_equipo"].Value.ToString();

            }
        }
    }
}
