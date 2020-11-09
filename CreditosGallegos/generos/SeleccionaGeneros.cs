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
        public void cargarpaciente(DataGridView dvg)
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
            }
            else
            {
                MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
            }
               
        }
        private void SeleccionaGeneros_Load(object sender, EventArgs e)
        {

        }

        private void btnSbuscar_Click(object sender, EventArgs e)
        {
            this.cargarpaciente(this.dataGridViewCargaGeneros);
        }
    }
}
