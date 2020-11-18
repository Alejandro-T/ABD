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

namespace CreditosGallegos.carreras
{
    public partial class BorrarCarreras : Form
    {
        public BorrarCarreras()
        {
            InitializeComponent();
        }
        public void cargarCarreras(DataGridView dvg)
        {
            try
            {
                DataTable dtscarrera = new DataTable();
                string comprobacion = "Select * from carreras where id_carrera='" + this.textBoxBidCarrera.Text + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtscarrera);
                    dvg.DataSource = dtscarrera;
                }
                else
                {
                    MessageBox.Show("La carrera no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cargarCarreras(this.dataGridViewBCarreras);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM carreras where  id_carrera='" + textBoxBidCarrera.Text + "'";

                string comprobacion =
                    "SELECT id_carrera from carreras where id_carrera='" + textBoxBidCarrera.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    
                }
                else
                {
                    MessageBox.Show("La carrera no existe", "aviso", MessageBoxButtons.OK);
                }
            }
            
            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }
        }
    }
}
