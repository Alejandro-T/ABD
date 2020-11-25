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
    public partial class MantenimientoGeneros : Form
    {
        public MantenimientoGeneros()
        {
            InitializeComponent();
        }
        public void cargarGeneros(DataGridView dvg)
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
        private void MantenimientoGeneros_Load(object sender, EventArgs e)
        {
            this.cargarGeneros(dataGridViewGeneros);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewGeneros.Rows[e.RowIndex];
                this.textBoxDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                this.textBoxIdGenero.Text = row.Cells["id_genero"].Value.ToString();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.limpiar();
        }
        public void limpiar()
        {
            this.textBoxIdGenero.Clear();
            this.textBoxDescripcion.Clear();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            string query = "UPDATE generos set descripcion = :descripcion where  id_genero=:genero";

            string comprobacion =
                "SELECT id_genero from generos where id_genero='" + textBoxIdGenero.Text + "'";
            OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
            OracleDataReader dr = cp.ExecuteReader();
            if (dr.Read())
            {
                OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                comando.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = this.textBoxDescripcion.Text;
                comando.Parameters.Add("@id_genero", OracleDbType.Int16).Value = this.textBoxIdGenero.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizado", "aviso", MessageBoxButtons.OK);
                this.cargarGeneros(this.dataGridViewGeneros);
                //limpiar los cuadros de texto
                this.limpiar();
            }
            else
            {
                MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            string query = "DELETE FROM generos where  id_genero='" + textBoxIdGenero.Text + "'";
            try
            {


                string comprobacion =
                    "SELECT id_genero from generos where id_genero='" + textBoxIdGenero.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.cargarGeneros(this.dataGridViewGeneros);
                    //limpiar los cuadros de texto
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("El Genero no existe", "aviso", MessageBoxButtons.OK);
                }
            }
            ///<summary>
            ///<exception cref="FormatException">
            ///Error cuando se mete un numero incorrecto en un textbox o combobox
            /// </exception>
            ///<exception cref="OracleException">
            ///Intentar eliminar un dato padre que ha sido insertado en una tabla hijo previamente
            ///</exception>
            ///</summary>
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
