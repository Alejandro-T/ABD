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
    public partial class InsertaDepartamentos : Form
    {
        public InsertaDepartamentos()
        {
            InitializeComponent();
        }
        
        public void cargardepto(DataGridView dvg)
        {
            DataTable dtDepto = new DataTable();
            string comprobacion = "select ID_DEPARTAMENTO,descripcion from departamentos where ID_DEPARTAMENTO ='" + publicas.id_departamento.ToString() + "'";
            
            OracleDataAdapter da = new OracleDataAdapter
                (comprobacion, Conexion.conectar());
            OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
            OracleDataReader dr = cp.ExecuteReader();
            if (dr.Read())
            {
                da.Fill(dtDepto);
                dvg.DataSource = dtDepto;
            }
            else
            {
                MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
            }

        }
        private void btnAgreagrDept_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobacion =
               "SELECT id_tec from tecsnm where id_tec='" + textBoxIdtec.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    string comp = "Select seq_departa_id_departa.nextval from dual";
                    OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
                    publicas.id_departamento = Convert.ToInt32(cpe.ExecuteScalar());

                    OracleCommand comando = new OracleCommand("insertar_depto", Conexion.conectar());
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@ID_DEPARTAMENTO", OracleDbType.Int32).Value = publicas.id_departamento.ToString();
                    comando.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxIdtec.Text;
                    comando.Parameters.Add("@DESCRIPCION", OracleDbType.Varchar2).Value = this.textBoxdescDpto.Text;

                    comando.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    limpiar();
                    //Select para saber el numero actual.
                    this.cargardepto(this.dataGridView1);
                    Conexion.cerrar();
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

        private void InsertaDepartamentos_Load(object sender, EventArgs e)
        {
            textBoxIdtec.Text = publicas.id_tec.ToString(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.textBoxdescDpto.Text = row.Cells["descripcion"].Value.ToString();
                
            }
        }
        public void limpiar()
        {
            this.textBoxdescDpto.Clear();
        }
    }
}
