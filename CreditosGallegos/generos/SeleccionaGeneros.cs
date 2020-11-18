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
    public partial class SeleccionaGeneros : Form
    {
        public SeleccionaGeneros()
        {
            InitializeComponent();
        }
        public void cargarGeneros(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select * from generos where id_genero='" + this.textBoxSidGnero.Text + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsgenero);
                    dvg.DataSource = dtsgenero;
                    this.textBoxSidGnero.Clear();
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


        public void cargarGenerosTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select * from generos";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsgenero);
                    dvg.DataSource = dtsgenero;
                    this.textBoxSidGnero.Clear();
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
        private void SeleccionaGeneros_Load(object sender, EventArgs e)
        {

        }

        private void btnSbuscar_Click(object sender, EventArgs e)
        {
            this.cargarGeneros(this.dataGridViewCargaGeneros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cargarGenerosTodos(this.dataGridViewCargaGeneros);
        }

        private void dataGridViewCargaGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCargaGeneros.Rows[e.RowIndex];
                this.textBoxSidGnero.Text = row.Cells["id_genero"].Value.ToString();

            }
        }
    }
}
