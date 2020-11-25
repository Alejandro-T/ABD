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

namespace CreditosGallegos.Alumnos
{
    public partial class MantenimientoEntrenadores : Form
    {
        public MantenimientoEntrenadores()
        {
            InitializeComponent();
        }
        OracleDataReader dr;
        public void cargarAlumnos(DataGridView dvg)
        {
            try
            {
                DataTable dtcarreras = new DataTable();
                string comprobacion = "Select * from Alumnos";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtcarreras);
                    dvg.DataSource = dtcarreras;

                }
                else
                {
                    MessageBox.Show("No hay datos", "aviso", MessageBoxButtons.OK);
                }
            }

            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }
        }
        private void MantenimientoAlumnos_Load(object sender, EventArgs e)
        {
        
            this.cargarAlumnos(dataGridViewAlumnos);
        }
    }
}
