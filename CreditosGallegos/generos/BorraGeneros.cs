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

namespace CreditosGallegos
{
    public partial class BorraGeneros : Form
    {
        public BorraGeneros()
        {
            InitializeComponent();
        }
        public void cargarGeneros(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "Select * from generos where id_genero='" + this.textBoxBidGnero.Text + "'";
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
                MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
            }

        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            this.cargarGeneros(this.dataGridViewBGeneros);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            string query = "DELETE FROM generos where  id_genero='" + textBoxBidGnero.Text + "'";
     
            string comprobacion =
                "SELECT id_genero from generos where id_genero='" + textBoxBidGnero.Text + "'";
            OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
            OracleDataReader dr = cp.ExecuteReader();
            if (dr.Read())
            {
                OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                OracleDataReader reader = comando.ExecuteReader();
                MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El usuario no existe", "aviso", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
