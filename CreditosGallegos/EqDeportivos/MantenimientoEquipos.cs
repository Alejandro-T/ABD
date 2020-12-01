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

namespace CreditosGallegos.EqDeportivos
{
    public partial class MantenimientoEquipos : Form
    {
        public MantenimientoEquipos()
        {
            InitializeComponent();
        }
       

        public void cargarEquipos(DataGridView dvg)
        {
            try
            {
                DataTable dtequipos = new DataTable();
                string comprobacion = "select * from EQUIPOSDEPORTIVOS where ID_TEC ='" + this.textBoxId_tec.Text + "'";

                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtequipos);
                    dvg.DataSource = dtequipos;

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

        private void MantenimientoEquipos_Load(object sender, EventArgs e)
        {
            this.textBoxId_tec.Text = publicas.id_tec.ToString();
            
            this.cargarEquipos(dataGridViewEntrenadores);
        }
        public void limpiar()
        {
            this.textBoxId_equipo.Clear();
            this.textBoxNombre.Clear();
            this.textBoxEntrenadores.Clear();
            
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxClean_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClean_DoubleClick(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridViewEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewEntrenadores.Rows[e.RowIndex];
                this.textBoxNombre.Text = row.Cells["nombre"].Value.ToString();
                this.textBoxEntrenadores.Text = row.Cells["ENTRENADORES_ID_ENTRENADOR"].Value.ToString();
                this.textBoxId_equipo.Text = row.Cells["id_equipo"].Value.ToString();
                
            }
        }

        private void pictureBoxDrop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM EQUIPOSDEPORTIVOS where ID_EQUIPO='" + textBoxId_equipo.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";

                string comprobacion =
                    "SELECT id_equipo from EQUIPOSDEPORTIVOS where id_equipo='" + textBoxId_equipo.Text + "'and id_tec='" + this.textBoxId_tec + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.cargarEquipos(this.dataGridViewEntrenadores);
                    //limpiar los cuadros de texto
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("El equipo no existe", "aviso", MessageBoxButtons.OK);
                }
            }

            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1722:
                        MessageBox.Show("Numero invalido(FormatException)--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
                    case 2292:
                        MessageBox.Show("No se puede eliminar el dato, porque existe una tabla hijo con ese dato", "Aviso", MessageBoxButtons.OK);
                        break;
                    default:
                        MessageBox.Show("Formato invalido--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
                }
            }
        }
    }
}
