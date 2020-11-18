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

namespace CreditosGallegos.generos
{
    public partial class ActualizaGeneros : Form
    {
        public ActualizaGeneros()
        {
            InitializeComponent();
        }
        public void cargarGeneros(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select * from generos where id_genero='" + this.textBoxAidGnero.Text + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsgenero);
                    dvg.DataSource = dtsgenero;
                    textBoxActualizaGenero.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
                }
            }

            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }

        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            this.cargarGeneros(this.dataGridViewAGeneros);
        }

        private void ActualizaGeneros_Load(object sender, EventArgs e)
        {
            textBoxActualizaGenero.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            string query = "UPDATE generos set descripcion = :descripcion where  id_genero=:genero";

            string comprobacion =
                "SELECT id_genero from generos where id_genero='" + textBoxAidGnero.Text + "'";
            OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
            OracleDataReader dr = cp.ExecuteReader();
            if (dr.Read())
            {
                OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                comando.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = this.textBoxActualizaGenero.Text;
                comando.Parameters.Add("@genero", OracleDbType.Int16).Value = this.textBoxAidGnero.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizado", "aviso", MessageBoxButtons.OK);
                this.cargarGeneros(this.dataGridViewAGeneros);
                //limpiar los cuadros de texto
                this.textBoxAidGnero.Clear();
                this.textBoxActualizaGenero.Clear();
            }
            else
            {
                MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
            }
        }

        private void dataGridViewAGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAGeneros.Rows[e.RowIndex];
                this.textBoxActualizaGenero.Text = row.Cells["descripcion"].Value.ToString();
                this.textBoxAidGnero.Text = row.Cells["id_genero"].Value.ToString();
            }
        }
    }
}
