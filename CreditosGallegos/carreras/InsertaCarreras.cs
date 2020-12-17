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
    public partial class InsertaCarreras : Form
    {
        
        public InsertaCarreras()
        {
            InitializeComponent();
        }
        
        public void CargarCarreras(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "Select ID_CARRERA,nombre from carreras where  ID_CARRERA='" + publicas.id_carrera.ToString() + "'";
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
        private void BtnAgreagrCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobacion =
               "SELECT id_tec from tecsnm where id_tec='" + textBoxIdtec.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    string comp = "Select seq_carrera_id_carrera.nextval from dual";
                    OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
                    publicas.id_carrera = Convert.ToInt32(cpe.ExecuteScalar());

                    OracleCommand comando = new OracleCommand("insertar_carreras", Conexion.conectar());
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@id_carrera", OracleDbType.Int32).Value = publicas.id_carrera.ToString();
                    comando.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxIdtec.Text;
                    comando.Parameters.Add("@nombre", OracleDbType.Varchar2).Value = this.textBoxdescCarrera.Text;

                    comando.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el numero actual.
                    this.CargarCarreras(this.dataGridView1);
                    this.textBoxdescCarrera.Clear();
                }
                else
                {
                    MessageBox.Show("no existe el tec", "aviso", MessageBoxButtons.OK);
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

        private void InsertaCarreras_Load(object sender, EventArgs e)
        {
            textBoxIdtec.Text = publicas.id_tec.ToString();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.textBoxdescCarrera.Text = row.Cells["nombre"].Value.ToString();
                

            }
        }
    }
}
