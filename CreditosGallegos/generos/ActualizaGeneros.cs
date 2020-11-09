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
                textBoxActualizaNombre.Enabled = true;
            }
            else
            {
                MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
            }

        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            this.cargarGeneros(this.dataGridViewAGeneros);
        }

        private void ActualizaGeneros_Load(object sender, EventArgs e)
        {
            textBoxActualizaNombre.Enabled = false;
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
                comando.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = this.textBoxActualizaNombre.Text;
                comando.Parameters.Add("@genero", OracleDbType.Int16).Value = this.textBoxAidGnero.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizado", "aviso", MessageBoxButtons.OK);
                this.cargarGeneros(this.dataGridViewAGeneros);
            }
            else
            {
                MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
            }
        }
    }
}
