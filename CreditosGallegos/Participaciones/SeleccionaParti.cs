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

namespace CreditosGallegos.Participaciones
{
    public partial class SeleccionaParti : Form
    {
        public SeleccionaParti()
        {
            InitializeComponent();
        }

        public void cargarParti(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select P.ID_EQUIPO,EQ.NOMBRE AS NOMBRE_EQUIPO,P.FECHA_PARTICIPA from participaciones P JOIN EQUIPOSDEPORTIVOS EQ ON P.ID_EQUIPO = EQ.ID_EQUIPO where P.id_equipo='" + this.textBoxSidEquipo.Text + "'and P.id_tec='" + publicas.id_tec.ToString() + "'";
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
                    dataGridViewCargaParti.DataSource = "";
                    MessageBox.Show("La Participacion no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        public void CargarPartisName(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "select P.ID_EQUIPO,EQ.NOMBRE AS NOMBRE_EQUIPO,P.FECHA_PARTICIPA from participaciones P JOIN EQUIPOSDEPORTIVOS EQ ON P.ID_EQUIPO = EQ.ID_EQUIPO where P.id_tec='" + publicas.id_tec.ToString() + "'and P.fecha_participa ='" + dateTimePicker1.Text + "'";
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
                    dataGridViewCargaParti.DataSource = "";
                    MessageBox.Show("La Participacion no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        public void CargarPartiTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtscarreras = new DataTable();
                string comprobacion = "select P.ID_EQUIPO,EQ.NOMBRE AS NOMBRE_EQUIPO,P.FECHA_PARTICIPA from participaciones P JOIN EQUIPOSDEPORTIVOS EQ ON P.ID_EQUIPO = EQ.ID_EQUIPO where P.ID_tec='" + publicas.id_tec.ToString() + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtscarreras);
                    dvg.DataSource = dtscarreras;
                }
                else
                {
                    dataGridViewCargaParti.DataSource = "";
                    MessageBox.Show("La Participacion no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }
        private void buttonCbuscar_Click(object sender, EventArgs e)
        {
            CargarPartiTodos(dataGridViewCargaParti);
        }

        private void btncbuscar_Click(object sender, EventArgs e)
        {
            cargarParti(dataGridViewCargaParti);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarPartisName(dataGridViewCargaParti);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void SeleccionaParti_Load(object sender, EventArgs e)
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

        private void dataGridViewCargaParti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCargaParti.Rows[e.RowIndex];
                this.textBoxSidEquipo.Text = row.Cells["id_equipo"].Value.ToString();
                this.dateTimePicker1.Text = row.Cells["fecha_participa"].Value.ToString();

            }
        }
    }
}
