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

namespace CreditosGallegos.Entrenadores
{
    public partial class SeleccionaEntrena : Form
    {
        public SeleccionaEntrena()
        {
            InitializeComponent();
        }

        public void cargarEntra(DataGridView dvg)
        {
            try
            {
                DataTable dtEntrena = new DataTable();
                string comprobacion = "select E.ID_ENTRENADOR,E.NOMBRE,E.PATERNO,E.MATERNO,G.DESCRIPCION AS GENERO,D.DESCRIPCION AS DEPARTAMENTO,G.ID_GENERO,D.ID_DEPARTAMENTO from entrenadores E JOIN DEPARTAMENTOS D ON D.ID_DEPARTAMENTO = E.ID_DEPARTAMENTO JOIN GENEROS G ON E.ID_GENERO = G.ID_GENERO where E.ID_ENTRENADOR='" + this.textBoxSidEntrena.Text + "'and E.id_tec='" + publicas.id_tec.ToString() + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtEntrena);
                    dvg.DataSource = dtEntrena;
                }
                else
                {
                    dataGridViewCargaEntrena.DataSource = "";
                    MessageBox.Show("El Entrenador no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        public void cargarEntrenaName(DataGridView dvg)
        {
            try
            {
                DataTable dtsEntrena = new DataTable();
                string comprobacion = "select E.ID_ENTRENADOR,E.NOMBRE,E.PATERNO,E.MATERNO,G.DESCRIPCION AS GENERO,D.DESCRIPCION AS DEPARTAMENTO,G.ID_GENERO,D.ID_DEPARTAMENTO from entrenadores E JOIN DEPARTAMENTOS D ON D.ID_DEPARTAMENTO = E.ID_DEPARTAMENTO JOIN GENEROS G ON E.ID_GENERO = G.ID_GENERO where E.id_tec='" + publicas.id_tec.ToString() + "'and E.NOMBRE like '" + Convert.ToString(this.textBox1.Text).ToLower() + "%'and E.PATERNO like'" + Convert.ToString(this.textBoxPaterno.Text).ToLower() + "%' and E.MATERNO like'" + Convert.ToString(this.textBoxMaterno.Text).ToLower() + "%'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsEntrena);
                    dvg.DataSource = dtsEntrena;
                }
                else
                {
                    dataGridViewCargaEntrena.DataSource = "";
                    MessageBox.Show("El entrenador no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }




        public void cargarEntrenaTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtsEntrena = new DataTable();
                string comprobacion = "select E.ID_ENTRENADOR,E.NOMBRE,E.PATERNO,E.MATERNO,G.DESCRIPCION AS GENERO,D.DESCRIPCION AS DEPARTAMENTO,G.ID_GENERO,D.ID_DEPARTAMENTO from entrenadores E JOIN DEPARTAMENTOS D ON D.ID_DEPARTAMENTO = E.ID_DEPARTAMENTO JOIN GENEROS G ON E.ID_GENERO = G.ID_GENERO where E.ID_tec='" + publicas.id_tec.ToString() + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsEntrena);
                    dvg.DataSource = dtsEntrena;
                }
                else
                {
                    dataGridViewCargaEntrena.DataSource = "";
                    MessageBox.Show("El Entrenador no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        private void btncbuscar_Click(object sender, EventArgs e)
        {
            this.cargarEntra(this.dataGridViewCargaEntrena);
        }
        private void buttonCbuscar_Click_1(object sender, EventArgs e)
        {
            this.cargarEntrenaTodos(this.dataGridViewCargaEntrena);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.cargarEntrenaName(this.dataGridViewCargaEntrena);
        }

        private void SeleccionaEntrena_Load(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void dataGridViewCargaDepto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCargaEntrena.Rows[e.RowIndex];
                    this.textBoxSidEntrena.Text = row.Cells["id_entrenador"].Value.ToString();
                    //this.textBox1.Text = row.Cells["materno"].Value.ToString();
                    
                    //this.textBoxMaterno.Text = row.Cells["materno"].Value.ToString();

                }
            }
        }

        private void textBoxPaterno_TextChanged(object sender, EventArgs e)
        {
            this.cargarEntrenaName(this.dataGridViewCargaEntrena);
        }

        private void textBoxMaterno_TextChanged(object sender, EventArgs e)
        {
            this.cargarEntrenaName(this.dataGridViewCargaEntrena);
        }
    }
}
