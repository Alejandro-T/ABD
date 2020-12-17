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
    public partial class MantenimientoCarreras : Form
    {
        public MantenimientoCarreras()
        {
            InitializeComponent();
        }
        
        public void cargarCarreras(DataGridView dvg)
        {
            try
            {
                DataTable dtcarreras = new DataTable();
                string comprobacion = "select id_carrera,nombre from carreras where ID_TEC ='" + this.textBoxId_tec.Text + "' order by id_carrera";
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
        private void MantenimientoCarreras_Load(object sender, EventArgs e)
        {
            this.textBoxId_tec.Text = publicas.id_tec.ToString();
            this.cargarCarreras(dataGridViewCarreras);
            
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from tecsnm where id_tec='" + textBoxId_tec.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZACARRERAS", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;


                act.Parameters.Add("id_carrerain", OracleDbType.Int16).Value = textBoxIdCarrera.Text;
                act.Parameters.Add("id_tecin", OracleDbType.Int16).Value = textBoxId_tec.Text;
                act.Parameters.Add("nombrein", OracleDbType.Varchar2).Value = textBoxDescripcion.Text;

                //aaaa
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                string comprobacion2 =
                    "SELECT id_carrera from carreras where id_carrera='" + textBoxIdCarrera.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                OracleDataReader dr2 = cp2.ExecuteReader();
                if (dr.Read())
                {
                    if (dr2.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                        this.cargarCarreras(this.dataGridViewCarreras);
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("La carrera no existe", "aviso", MessageBoxButtons.OK);
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
            finally
            {
                Conexion.cerrar();
            }
        }
        public void limpiar()
        {
            this.textBoxIdCarrera.Clear();
            this.textBoxDescripcion.Clear();
        }

        private void dataGridViewCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCarreras.Rows[e.RowIndex];
                this.textBoxDescripcion.Text = row.Cells["nombre"].Value.ToString();
                this.textBoxIdCarrera.Text = row.Cells["id_carrera"].Value.ToString();
                
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                string query = "DELETE FROM carreras where  id_carrera='" + textBoxIdCarrera.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                string comprobacion =
                    "SELECT id_carrera from carreras where id_carrera='" + textBoxIdCarrera.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.cargarCarreras(this.dataGridViewCarreras);
                    //limpiar los cuadros de texto
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("La carrera no existe", "aviso", MessageBoxButtons.OK);
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
            finally
            {
                Conexion.cerrar();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionaCarreras se = new SeleccionaCarreras();
            se.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
