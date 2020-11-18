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
    public partial class ActualizaCarreras : Form
    {
        public ActualizaCarreras()
        {
            InitializeComponent();
        }
        OracleDataReader dr;
        public void cargarCarreras(DataGridView dvg)
        {
            try
            {
                DataTable dtpaciente = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter
                    ("Select * from carreras where id_carrera='" + this.textBoxbusca_id_carrera.Text + "'", Conexion.conectar());
                da.Fill(dtpaciente);
                dvg.DataSource = dtpaciente;
            }
            
             catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }
        }
        public void cargarcheckbix()
        {
            try
            {
                String query1 = "select * from carreras where id_carrera='" + this.textBoxbusca_id_carrera.Text + "'";
                OracleCommand cm = new OracleCommand(query1, Conexion.conectar());
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    textBoxName.Text = dr["nombre"].ToString();
                    textBox2.Text = dr["id_tec"].ToString();

                }
                else
                {
                    MessageBox.Show("Carrera no encontrada");
                }
            }
            
            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            this.cargarCarreras(this.dataGridViewCarrera);
            this.cargarcheckbix();
        }

        private void ActualizaCarreras_Load(object sender, EventArgs e)
        {
            textBoxName.Hide();
            textBox2.Hide();
        }

        private void checkBoxid_tec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxid_name.Checked.ToString().Equals("True"))
            {
                textBoxName.Show();
            }
            else
            {
                if (checkBoxid_name.Checked.ToString().Equals("False"))
                {
                    textBoxName.Hide();
                }

            }
        }

        private void checkBoxNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxid.Checked.ToString().Equals("True"))
            {
                textBox2.Show();
            }
            else
            {
                if (checkBoxid.Checked.ToString().Equals("False"))
                {
                    textBox2.Hide();
                }

            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from carreras where id_tec='" + textBox2.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZACARRERAS", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;
 
               
                act.Parameters.Add("id_carrerain", OracleDbType.Int16).Value = textBoxbusca_id_carrera.Text;
                act.Parameters.Add("id_tecin", OracleDbType.Int16).Value = textBox2.Text;
                act.Parameters.Add("nombrein", OracleDbType.Varchar2).Value = textBoxName.Text;
               
                if (checkBoxid.Checked.ToString().Equals("True"))
                {
                    OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                    OracleDataReader dr = cp.ExecuteReader();
                    if (dr.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error en la llave foranea de Tecsnm","aviso", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (checkBoxid.Checked.ToString().Equals("False"))
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                    }

                }
            }
            
            
            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Hay un campo sin datos");
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        private void dataGridViewCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
