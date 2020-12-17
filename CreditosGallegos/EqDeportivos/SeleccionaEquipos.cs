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

namespace CreditosGallegos.EqDeportivos
{
    public partial class SeleccionaEquipos : Form
    {
        public SeleccionaEquipos()
        {
            InitializeComponent();
        }
        private void SeleccionaEquipos_Load(object sender, EventArgs e)
        {
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
        public void cargarEquipo(DataGridView dvg)
        {
            try
            {
                DataTable dtDepto = new DataTable();
                string comprobacion = "select EQ.ID_EQUIPO, EQ.NOMBRE AS NOMBRE_EQUIPO, E.NOMBRE AS NOMBRE_ENTRENA,E.PATERNO AS PATERNO_ENTRENA,E.MATERNO AS MATERNO_ENTRENA,EQ.ENTRENADORES_ID_ENTRENADOR AS ID_ENTRENADOR from EQUIPOSDEPORTIVOS EQ JOIN ENTRENADORES E ON EQ.ENTRENADORES_ID_ENTRENADOR = E.ID_ENTRENADOR where EQ.ID_EQUIPO='" + this.textBoxSidEquipo.Text + "'and EQ.id_tec='" + publicas.id_tec.ToString() + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtDepto);
                    dvg.DataSource = dtDepto;
                }
                else
                {
                    dataGridViewCargaEquipo.DataSource = "";
                    MessageBox.Show("El Equipo no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaEquipo.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        public void cargarEquipoName(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select EQ.ID_EQUIPO, EQ.NOMBRE AS NOMBRE_EQUIPO, E.NOMBRE AS NOMBRE_ENTRENA,E.PATERNO AS PATERNO_ENTRENA,E.MATERNO AS MATERNO_ENTRENA,EQ.ENTRENADORES_ID_ENTRENADOR AS ID_ENTRENADOR from EQUIPOSDEPORTIVOS EQ JOIN ENTRENADORES E ON EQ.ENTRENADORES_ID_ENTRENADOR = E.ID_ENTRENADOR  where EQ.id_tec='" + publicas.id_tec.ToString() + "'and EQ.nombre like '" + Convert.ToString(this.textBox1.Text).ToLower() + "%'";
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
                    dataGridViewCargaEquipo.DataSource = "";
                    MessageBox.Show("El Equipo no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaEquipo.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        public void cargarEquipoTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select EQ.ID_EQUIPO, EQ.NOMBRE AS NOMBRE_EQUIPO, E.NOMBRE AS NOMBRE_ENTRENA,E.PATERNO AS PATERNO_ENTRENA,E.MATERNO AS MATERNO_ENTRENA,EQ.ENTRENADORES_ID_ENTRENADOR AS ID_ENTRENADOR from EQUIPOSDEPORTIVOS EQ JOIN ENTRENADORES E ON EQ.ENTRENADORES_ID_ENTRENADOR = E.ID_ENTRENADOR where EQ.ID_tec='" + publicas.id_tec.ToString() + "'";
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
                    dataGridViewCargaEquipo.DataSource = "";
                    MessageBox.Show("El Equipo no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaEquipo.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        

       

       
        private void btncbuscar_Click_1(object sender, EventArgs e)
        {
            this.cargarEquipo(this.dataGridViewCargaEquipo);
        }

        private void buttonCbuscar_Click_1(object sender, EventArgs e)
        {
            this.cargarEquipoTodos(this.dataGridViewCargaEquipo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.cargarEquipoName(this.dataGridViewCargaEquipo);
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

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
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

        private void dataGridViewCargaEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCargaEquipo.Rows[e.RowIndex];
                this.textBoxSidEquipo.Text = row.Cells["id_equipo"].Value.ToString();
                this.textBox1.Text = row.Cells["NOMBRE_EQUIPO"].Value.ToString();
            }
        }
    }
}
