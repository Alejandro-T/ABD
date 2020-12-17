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

namespace CreditosGallegos.Participaciones
{
    public partial class MantenimientoParticipaciones : Form
    {
        public MantenimientoParticipaciones()
        {
            InitializeComponent();
        }
        public void CargarParticipa(DataGridView dvg)
        {
            try
            {
                DataTable dtParti = new DataTable();
                string comprobacion = "select P.ID_EQUIPO,EQ.NOMBRE AS NOMBRE_EQUIPO,P.FECHA_PARTICIPA from participaciones P JOIN EQUIPOSDEPORTIVOS EQ ON P.ID_EQUIPO = EQ.ID_EQUIPO where P.ID_TEC ='" + this.textBoxId_tec.Text + "' order by P.fecha_participa";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtParti);
                    dvg.DataSource = dtParti;

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
        private void MantenimientoParticipaciones_Load(object sender, EventArgs e)
        {
            this.textBoxId_tec.Text = publicas.id_tec.ToString();
            this.CargarParticipa(dataGridViewAlumnos);
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAlumnos.Rows[e.RowIndex];
                this.textBoxId_Equipo.Text = row.Cells["id_equipo"].Value.ToString();
               
                this.dateTimePicker1.Text = row.Cells["fecha_participa"].Value.ToString();
                publicas.id_Parti = (dateTimePicker1.Text);
            }
        }

        private void pictureBoxClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            this.textBoxId_Equipo.Clear();
            //this.textBoxDescripcion.Clear();
            
            
        }

        private void pictureBoxDrop_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "DELETE FROM participaciones where  id_equipo='" + textBoxId_Equipo.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "' and fecha_participa = '" + dateTimePicker1.Text + "'";
                string comprobacion =
              "select id_equipo FROM participaciones where  id_equipo='" + textBoxId_Equipo.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "' and fecha_participa = '" + dateTimePicker1.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.CargarParticipa(this.dataGridViewAlumnos);
                    //limpiar los cuadros de texto
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("El equipo o fecha no existen", "aviso", MessageBoxButtons.OK);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionaParti sPart = new SeleccionaParti();
            sPart.Show();
        }

        private void pictureBoxUpdate_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from tecsnm where id_tec='" + textBoxId_tec.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZPARTI", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;


                act.Parameters.Add("PARTI_ID_EQUIPOIN", OracleDbType.Int16).Value = textBoxId_Equipo.Text;
                act.Parameters.Add("PARTI_FECHAIN", OracleDbType.Date).Value = (publicas.id_Parti.ToString());
                act.Parameters.Add("FECHA_PARTICIPA_NUEVO", OracleDbType.Varchar2).Value = dateTimePicker1.Text;

                //aaaa
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                string comprobacion2 =
                   "select id_equipo FROM participaciones where  id_equipo='" + textBoxId_Equipo.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                OracleDataReader dr2 = cp2.ExecuteReader();
                if (dr.Read())
                {
                    if (dr2.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                        this.CargarParticipa(this.dataGridViewAlumnos);
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("La participacion no existe", "aviso", MessageBoxButtons.OK);
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
                        MessageBox.Show("Formato invalido--Error--" + ex.Number+" :"+ex, "Aviso", MessageBoxButtons.OK);
                        break;
                }
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
