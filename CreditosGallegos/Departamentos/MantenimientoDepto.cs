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
    public partial class MantenimientoDepto : Form
    {
        public MantenimientoDepto()
        {
            InitializeComponent();
        }
        public void cargarDpto(DataGridView dvg)
        {
            try
            {
                DataTable dtDepto = new DataTable();
                string comprobacion = "Select * from departamentos";
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
                    MessageBox.Show("No hay datos", "aviso", MessageBoxButtons.OK);
                }
            }

            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }

        }
        private void MantenimientoDepto_Load(object sender, EventArgs e)
        {
            this.cargarDpto(this.dataGridViewDepto);
        }
        public void limpiar()
        {
            this.textBoxIdDepto.Clear();
            this.textBoxDescripcion.Clear();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            limpiar();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               
                     
                string query = "DELETE FROM departamentos where id_departamento='" + textBoxIdDepto.Text + "'";

                string comprobacion =
                    "SELECT id_departamento from departamentos where id_departamento='" + textBoxIdDepto.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.cargarDpto(this.dataGridViewDepto);
                    //limpiar los cuadros de texto
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("El departamento no existe no existe", "aviso", MessageBoxButtons.OK);
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

        private bool FormatException(Exception ex)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewDepto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDepto.Rows[e.RowIndex];
                this.textBoxDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                this.textBoxIdDepto.Text = row.Cells["id_departamento"].Value.ToString();
                this.textBoxId_tec.Text = row.Cells["id_tec"].Value.ToString();
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from tecsnm where id_tec='" + textBoxId_tec.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZADEPTO", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;


                act.Parameters.Add("id_deptoin", OracleDbType.Int16).Value = textBoxIdDepto.Text;
                
                act.Parameters.Add("nombrein", OracleDbType.Varchar2).Value = textBoxDescripcion.Text;

                //aaaa
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                //
                string comprobacion2 =
                    "SELECT id_departamento from departamentos where id_departamento='" + textBoxIdDepto.Text + "'";
                OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                OracleDataReader dr2 = cp2.ExecuteReader();
                
                if (dr.Read())
                {
                    if (dr2.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                        this.cargarDpto(this.dataGridViewDepto);
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error en la llave de departamento", "aviso", MessageBoxButtons.OK);
                    }
                        
                }
                else
                {
                    MessageBox.Show("Error en la llave foranea de Tecsnm", "aviso", MessageBoxButtons.OK);
                }

                //aaaa
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
