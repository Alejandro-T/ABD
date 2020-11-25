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

namespace CreditosGallegos.Entrenadores
{
    public partial class InsertaEntrenador : Form
    {
        public InsertaEntrenador()
        {
            InitializeComponent();
        }
        
       
        private void InsertaEntrenador_Load(object sender, EventArgs e)
        {
            actualizasecuencia();
            seleccionacomboGenero();
            seleccionacomboDepto();
           
            //
            
            Conexion.cerrar();

        }
        public void actualizasecuencia()
        {
           // OracleCommand loCmd = Conexion.conectar().CreateCommand();
           // loCmd.CommandType = CommandType.Text;
           // loCmd.CommandText = "select seq_entrena_id_entrena.nextval from dual";
           // long lnNextVal = Convert.ToInt64(loCmd.ExecuteScalar());
           // textBox1.Text = lnNextVal.ToString();
        }
        public void seleccionacomboGenero()
        {
            DataTable dt = new DataTable();

            string depto = "SELECT id_genero,descripcion FROM generos";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(dt);

            if (dr.HasRows)
            {
               comboBoxGenero.Items.Clear();
                while (dr.Read())
                {
                    comboBoxGenero.DataSource = dt;
                    comboBoxGenero.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxGenero.ValueMember = dt.Columns[0].ColumnName;
                }
                comboBoxGenero.SelectedIndex = 1;
                Conexion.cerrar();
            }
        }


        public void seleccionacomboDepto()
        {
            DataTable dt = new DataTable();

            string depto = "SELECT id_departamento,id_tec,descripcion FROM departamentos";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(dt);

            if (dr.HasRows)
            {
                comboBoxDepartamento.Items.Clear();
                while (dr.Read())
                {
                    comboBoxDepartamento.DataSource = dt;
                    comboBoxDepartamento.DisplayMember = dt.Columns[2].ColumnName;
                    comboBoxDepartamento.ValueMember = dt.Columns[0].ColumnName;
                }
                comboBoxDepartamento.SelectedIndex = 1;
                Conexion.cerrar();
            }
        }
        public void cargarDepto(DataGridView dvg)
        {
          /*  DataTable dtsgenero = new DataTable();
            string comprobacion = "Select * from carreras where id_carrera='" + this.textBox1.Text + "'";
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
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string comprobacion =
               "SELECT id_tec from tecsnm where id_tec='" + textBoxTec.Text + "'";
                OracleCommand cpp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader drp = cpp.ExecuteReader();
                if (drp.Read())
                {
                    OracleCommand comandoinse = new OracleCommand("insertar_entrena", Conexion.conectar());
                    comandoinse.CommandType = CommandType.StoredProcedure;


                comandoinse.Parameters.Add("@id_genero", OracleDbType.Int16).Value= Convert.ToInt16(comboBoxGenero.SelectedValue);
                    comandoinse.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxTec.Text;
                //
                    comandoinse.Parameters.Add("@ID_DEPARTAMENTO", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxDepartamento.SelectedValue);
                    comandoinse.Parameters.Add("@nombre", OracleDbType.Varchar2).Value = this.textBoxName.Text;
                    comandoinse.Parameters.Add("@paterno", OracleDbType.Varchar2).Value = this.textBoxPaterno.Text;
                    comandoinse.Parameters.Add("@materno", OracleDbType.Varchar2).Value = this.textBoxMaterno.Text;
                 

                    comandoinse.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el numero actual.
                    

                    this.cargarDepto(this.dataGridViewEntrenadores);
                    //actualizasecuencia();
            }
                else
                {
                    MessageBox.Show("no existe el tec", "aviso", MessageBoxButtons.OK);
                }
            
            
        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBoxDepartamento.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
