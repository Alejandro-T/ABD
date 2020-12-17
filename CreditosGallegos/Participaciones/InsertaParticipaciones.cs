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
    public partial class InsertaParticipaciones : Form
    {
        public InsertaParticipaciones()
        {
            InitializeComponent();
        }
        public void CargarPartici(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "select P.ID_EQUIPO,EQ.NOMBRE AS NOMBRE_EQUIPO,P.FECHA_PARTICIPA from participaciones P JOIN EQUIPOSDEPORTIVOS EQ ON P.ID_EQUIPO = EQ.ID_EQUIPO where P.id_equipo='" + textBox1.Text + "'and P.FECHA_PARTICIPA = '" + this.dateTimePicker1.Text+"'";
            OracleDataAdapter da = new OracleDataAdapter
            (comprobacion, Conexion.conectar());
            OracleCommand cp = new OracleCommand(comprobacion,Conexion.conectar());
            OracleDataReader dr = cp.ExecuteReader();
            if (dr.Read())
            {
                da.Fill(dtsgenero);
                dvg.DataSource = dtsgenero;
            }
            else
            {
                MessageBox.Show("la fecha no existe", "aviso", MessageBoxButtons.OK);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //string comprobacion =
                // "select id_equipo from equiposdeportivos where id_tec = '" + publicas.id_tec.ToString() + "'and id_equipo = '" + this.textBox1.Text + "'";
                string comprobacion =
                    "select H.ALUMNOS_NO_CONTROL FROM alumnos_has_equiposdeportivos H WHERE H.ID_TEC = '" + publicas.id_tec.ToString() + "' AND H.EQUIPOSDEPORTIVOS_ID_EQUIPO = '"+this.textBox1.Text+"'";
                OracleCommand cpp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader drp = cpp.ExecuteReader();
                string SQL = "insert into PARTICIPACIONES(ID_EQUIPO,id_tec,FECHA_PARTICIPA)values(:PARTICIPACIONES_ID_EQUIPO,:PARTICIPACIONES_id_tec,:PARTICIPACIONES_FECHA_PARTICIPA)";
                if (drp.Read())
                {
                    //  string date = monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();

                    Conexion.conectar();
                    OracleCommand comandoinse = new OracleCommand("", Conexion.conectar());
                    comandoinse.CommandType = CommandType.Text;
                    comandoinse.CommandText = "insert into PARTICIPACIONES values('" + this.textBox1.Text + "', '" + publicas.id_tec.ToString() + "', '" + this.dateTimePicker1.Text + "')";

                    //comandoinse.Parameters.Add("PARTICIPACIONES_ID_EQUIPO", OracleDbType.Int32).Value = textBox1.Text;
                    //comandoinse.Parameters.Add("PARTICIPACIONES_id_tec", OracleDbType.Int16).Value = publicas.id_tec.ToString();
                    //

                    //comandoinse.Parameters.Add("PARTICIPACIONES_FECHA_PARTICIPA", OracleDbType.Date).Value = "07/06/2020";



                    comandoinse.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el numero actual.


                    this.CargarPartici(this.dataGridView1);
                    //actualizasecuencia();
                }
                else
                {
                    MessageBox.Show("no existe el equipo", "aviso", MessageBoxButtons.OK);
                }
            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1:
                        MessageBox.Show("Ya existe este registro--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
                        break;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //textBox1.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //textBox1.Text = dateTimePicker1.Text;
        }
    }
}
