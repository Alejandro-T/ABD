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
    public partial class AgregaEq : Form
    {
        public AgregaEq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobacion =
               "SELECT id_tec from tecsnm where id_tec='" + textBoxTec.Text + "'";
                OracleCommand cpp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader drp = cpp.ExecuteReader();
                if (drp.Read())
                {
                    string comprobacion2 =
                    "SELECT id_entrenador from entrenadores where id_entrenador='" + textBoxEntrenador.Text + "'and id_tec='"+this.textBoxTec.Text+"'";
                    OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                    OracleDataReader dr2 = cp2.ExecuteReader();
                    if (dr2.Read())
                    {
                        string comp = "Select seq_equipos_id_equipos.nextval from dual";
                        OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
                        publicas.id_equipo = Convert.ToInt32(cpe.ExecuteScalar());

                        OracleCommand comandoinse = new OracleCommand("insertar_equipo", Conexion.conectar());
                        comandoinse.CommandType = CommandType.StoredProcedure;

                        comandoinse.Parameters.Add("@ID_equipo", OracleDbType.Int32).Value = publicas.id_equipo.ToString();
                        comandoinse.Parameters.Add("@ENTRENADORES_ID_ENTRENADOR", OracleDbType.Int16).Value = textBoxEntrenador.Text;
                        comandoinse.Parameters.Add("@nombre", OracleDbType.Varchar2).Value = this.textBoxName.Text;
                        comandoinse.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxTec.Text;
                        comandoinse.ExecuteNonQuery();
                        MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                        //Select para saber el numero actual.


                        // this.cargarEntrena(this.dataGridViewEntrenadores);
                        //actualizasecuencia();
                    }
                    else
                    {
                        MessageBox.Show("El entrenador no existe no existe", "aviso", MessageBoxButtons.OK);
                    }

                    //




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
                    case 2291:
                        MessageBox.Show("Error en Llave foranea--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
                    default:
                        MessageBox.Show("Formato invalido--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
                }
            }
        }

        private void AgregaEq_Load(object sender, EventArgs e)
        {
            textBoxTec.Text = publicas.id_tec.ToString();
        }
    }
}
