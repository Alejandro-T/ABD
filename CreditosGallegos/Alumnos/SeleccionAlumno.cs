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

namespace CreditosGallegos.Alumnos
{
    public partial class SeleccionAlumno : Form
    {
        public SeleccionAlumno()
        {
            InitializeComponent();
        }

        private void SeleccionAlumno_Load(object sender, EventArgs e)
        {
            
            if (groupBox1.Enabled == true || groupBox2.Enabled == true)
            {
                


            }
            else
            {
                
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                this.groupBox1.Hide();
                this.groupBox2.Hide();
                
            }
        }


        public void seleccionacomboCarreras()
        {
            //
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "SELECT id_carrera,id_tec,nombre FROM carreras where ID_TEC ='" + publicas.id_tec.ToString() + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);

            if (dr.Read())
            {
                comboBoxCarreras.DataSource = ds.Tables[0];
                comboBoxCarreras.DisplayMember = "NOMBRE";
                comboBoxCarreras.ValueMember = "ID_CARRERA";
                
            }
            else
            {
                MessageBox.Show("no hay Carreras existentes");
            }

            //

            

        }
        public void cargarAlumno(DataGridView dvg)
        {
            try
            {
                DataTable dtalumnos = new DataTable();
                string comprobacion = "Select A.NO_CONTROL,A.NOMBRE,A.PATERNO,A.MATERNO,G.DESCRIPCION AS SEXO ,C.NOMBRE AS CARRERA,A.ID_GENERO,A.ID_CARRERA from alumnos A JOIN GENEROS G ON A.ID_GENERO=G.ID_GENERO JOIN CARRERAS C ON A.ID_CARRERA = C.ID_CARRERA where A.NO_CONTROL='" + this.textBoxSidAlumno.Text + "'and A.id_tec='" + publicas.id_tec.ToString() + "'";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtalumnos);
                    dvg.DataSource = dtalumnos;
                }
                else
                {
                    dataGridViewCargaAlumno.DataSource = "";
                    MessageBox.Show("El Alumno no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaAlumno.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }

        
        public void CargarAlumnoName(DataGridView dvg)
        {
            
            try
            {
                
                DataTable dtsEntrena = new DataTable();
                string comprobacion = "Select A.NO_CONTROL,A.NOMBRE,A.PATERNO,A.MATERNO,G.DESCRIPCION AS SEXO ,C.NOMBRE AS CARRERA,A.ID_GENERO,A.ID_CARRERA from alumnos A JOIN GENEROS G ON A.ID_GENERO=G.ID_GENERO JOIN CARRERAS C ON A.ID_CARRERA = C.ID_CARRERA where A.id_tec='" + publicas.id_tec.ToString() + "'and A.NOMBRE like '" + Convert.ToString(this.textBox1.Text).ToLower() + "%'and A.PATERNO like'" + Convert.ToString(this.textBoxPaterno.Text).ToLower() + "%' and A.MATERNO like'" + Convert.ToString(this.textBoxMaterno.Text).ToLower() + "%' and A.ID_CARRERA = '" + comboBoxCarreras.SelectedValue + "' order by A.no_control";
               
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsEntrena);
                    dvg.DataSource = dtsEntrena;
                }
                else
                {
                    dataGridViewCargaAlumno.DataSource = "";
                    MessageBox.Show("El alumno no existe", "aviso", MessageBoxButtons.OK);
                }
                
                
               
            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1722:
                        MessageBox.Show("--Error--" + ex.Number, "Aviso", MessageBoxButtons.OK);
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




        public void CargarAlumnoTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtalumnos = new DataTable();
                string comprobacion = "Select A.NO_CONTROL,A.NOMBRE,A.PATERNO,A.MATERNO,G.DESCRIPCION AS SEXO ,C.NOMBRE AS CARRERA,A.ID_GENERO,A.ID_CARRERA from alumnos A JOIN GENEROS G ON A.ID_GENERO=G.ID_GENERO JOIN CARRERAS C ON A.ID_CARRERA = C.ID_CARRERA where A.ID_tec='" + publicas.id_tec.ToString() + "' order by A.no_control";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtalumnos);
                    dvg.DataSource = dtalumnos;
                }
                else
                {
                    dataGridViewCargaAlumno.DataSource = "";
                    MessageBox.Show("El Alumno no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                dataGridViewCargaAlumno.DataSource = "";
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        private void Btncbuscar_Click_1(object sender, EventArgs e) => this.cargarAlumno(this.dataGridViewCargaAlumno);

        private void ButtonCbuscar_Click(object sender, EventArgs e) => this.CargarAlumnoTodos(this.dataGridViewCargaAlumno);

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.CargarAlumnoName(this.dataGridViewCargaAlumno);
        }

        private void TextBoxPaterno_TextChanged_1(object sender, EventArgs e) => this.CargarAlumnoName(this.dataGridViewCargaAlumno);

        private void TextBoxMaterno_TextChanged_1(object sender, EventArgs e) => this.CargarAlumnoName(this.dataGridViewCargaAlumno);


        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Show();
                groupBox2.Hide();
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                groupBox1.Hide();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                seleccionacomboCarreras();
                comboBoxCarreras.Enabled = true;
                
                groupBox2.Show();
                groupBox1.Hide();
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                groupBox2.Hide();
            }
        }

        
        int contador = 0;
        private void ComboBoxCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                this.CargarAlumnoName(this.dataGridViewCargaAlumno);
            }
            else
            {
                contador++;
            }
        }

        private void DataGridViewCargaAlumno_CellContentClick_1(object sender, DataGridViewCellEventArgs d)
        {
            if (checkBox2.Checked == true)
            {
                if (d.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCargaAlumno.Rows[d.RowIndex];
                    this.textBox1.Text = row.Cells["nombre"].Value.ToString();
                    
                    
                   // this.comboBoxCarreras.SelectedValue = row.Cells["id_carrera"].Value.ToString();

                    //this.textBoxSidAlumno.Text = row.Cells["NO_CONTROL"].Value.ToString();

                    //this.comboBoxCarreras.SelectedValue = row.Cells["id_carrera"].Value.ToString();
                }
            }
            else
            {
                DataGridViewRow row = this.dataGridViewCargaAlumno.Rows[d.RowIndex];
                this.textBoxSidAlumno.Text = row.Cells["no_control"].Value.ToString();
            }
                
        }
    }
}
