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
    public partial class AgregaGeneros : Form
    {
        public AgregaGeneros()
        {
            InitializeComponent();
        }
        OracleDataReader dr;
        public void cargarGeneros(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "Select * from generos where id_genero='"+publicas.id_genero.ToString()+"'";
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
        private void btnAgreagrGenero_Click(object sender, EventArgs e)
        {
            try
            {
                
                string comp = "Select seq_genero_id_genero.nextval from dual";
                OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
                publicas.id_genero = Convert.ToInt32(cpe.ExecuteScalar());
                OracleCommand comando = new OracleCommand("insertar_genero", Conexion.conectar());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_genero", OracleDbType.Int32).Value = publicas.id_genero.ToString();
                comando.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = this.textBoxdescrpcGenero.Text;
                //comando.Parameters.Add("@edad", OracleDbType.Int16).Value = this.textBoxidGnero.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                //Select para saber el numero actual.
                this.cargarGeneros(this.dataGridView1);
                //limpiar los cuadros de texto
                this.textBoxdescrpcGenero.Clear();
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

        private void AgregaGeneros_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.textBoxdescrpcGenero.Text = row.Cells["descripcion"].Value.ToString();

            }
        }

        private void textBoxdescrpcGenero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
