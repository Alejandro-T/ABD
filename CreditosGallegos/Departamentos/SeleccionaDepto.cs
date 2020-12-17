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

namespace CreditosGallegos.Departamentos
{
    public partial class SeleccionaDepto : Form
    {
        public SeleccionaDepto()
        {
            InitializeComponent();
        }
        public void cargarDepto(DataGridView dvg)
        {
            try
            {
                DataTable dtDepto = new DataTable();
                string comprobacion = "Select ID_DEPARTAMENTO,DESCRIPCION from departamentos where id_departamento='" + this.textBoxSidDepto.Text + "'and id_tec='" + publicas.id_tec.ToString() + "'";
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
                    dataGridViewCargaDepto.DataSource = "";
                    MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        public void cargarDeptoName(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select ID_DEPARTAMENTO,DESCRIPCION from departamentos where id_tec='" + publicas.id_tec.ToString() + "'and DESCRIPCION like '" + Convert.ToString(this.textBox1.Text).ToLower() + "%'";
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
                    dataGridViewCargaDepto.DataSource = "";
                    MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
                }
                
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        public void cargarDeptoTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select ID_DEPARTAMENTO,DESCRIPCION from departamentos where ID_tec='" + publicas.id_tec.ToString() + "'";
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
                    dataGridViewCargaDepto.DataSource = "";
                    MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        private void btncbuscar_Click(object sender, EventArgs e)
        {
            this.cargarDepto(this.dataGridViewCargaDepto);
        }

        private void buttonCbuscar_Click(object sender, EventArgs e)
        {
            this.cargarDeptoTodos(this.dataGridViewCargaDepto);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.cargarDeptoName(this.dataGridViewCargaDepto);
        }

        private void SeleccionaDepto_Load(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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

        private void dataGridViewCargaDepto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCargaDepto.Rows[e.RowIndex];
                this.textBoxSidDepto.Text = row.Cells["id_departamento"].Value.ToString();
                this.textBox1.Text = row.Cells["DESCRIPCION"].Value.ToString();
            }
        }
    }
}
