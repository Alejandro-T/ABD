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
    public partial class SeleccionaCarreras : Form
    {
        public SeleccionaCarreras()
        {
            InitializeComponent();
        }
        public void cargarCarreras(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select * from carreras where id_carrera='" + this.textBoxSidCarrera.Text + "'";
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
                    MessageBox.Show("La carrera no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        public void cargarCarrerasTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select * from carreras";
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
                    MessageBox.Show("La carrera no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        private void btncbuscar_Click(object sender, EventArgs e)
        {
            this.cargarCarreras(this.dataGridViewCargaCarreras);
        }

        private void buttonCbuscar_Click(object sender, EventArgs e)
        {
            this.cargarCarrerasTodos(this.dataGridViewCargaCarreras);
        }

        private void dataGridViewCargaCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCargaCarreras.Rows[e.RowIndex];
                this.textBoxSidCarrera.Text = row.Cells["id_tec"].Value.ToString();
                
            }
        }
    }
}
