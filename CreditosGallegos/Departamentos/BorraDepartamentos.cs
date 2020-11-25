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
    public partial class BorraDepartamentos : Form
    {
        public BorraDepartamentos()
        {
            InitializeComponent();
        }
        public void cargarDepto(DataGridView dvg)
        {
            try
            {
                DataTable dtscarrera = new DataTable();
                string comprobacion = "Select * from departamentos where id_departamento='" + this.textBoxBidDepto.Text + "'";
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
                    MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            cargarDepto(this.dataGridViewBDepto);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM departamentos where  id_departamento='" + textBoxBidDepto.Text + "'";

                string comprobacion =
                    "SELECT id_departamento from departamentos where id_departamento='" + textBoxBidDepto.Text + "'";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
