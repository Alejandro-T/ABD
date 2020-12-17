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
    public partial class MantenimientoEntrenadores : Form
    {
        public MantenimientoEntrenadores()
        {
            InitializeComponent();
        }

        private void MantenimientoAlumnos_Load(object sender, EventArgs e)
        {
            this.textBoxId_tec.Text = publicas.id_tec.ToString();
            this.SeleccionacomboCarreras();
            this.SeleccionacomboGenero();
            this.CargarAlumnos(dataGridViewAlumnos);
        }

        public void SeleccionacomboGenero()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "SELECT id_genero,descripcion FROM generos";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);

            if (dr.Read())
            {
                comboBoxGeneros.DataSource = ds.Tables[0];
                comboBoxGeneros.DisplayMember = "descripcion";
                comboBoxGeneros.ValueMember = "id_genero";
            }
            else
            {
                MessageBox.Show("no hay generos existentes");
            }
        }


        public void SeleccionacomboCarreras()
        {

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string depto = "SELECT id_carrera,id_tec,nombre FROM carreras where ID_TEC ='" + this.textBoxId_tec.Text + "'";
            OracleDataAdapter da = new OracleDataAdapter
                (depto, Conexion.conectar());
            OracleCommand cmd = new OracleCommand(depto, Conexion.conectar());

            OracleDataReader dr = cmd.ExecuteReader();
            da.Fill(ds);
            if (dr.Read())
            {


                comboBoxCarreras.DataSource = ds.Tables[0];
                comboBoxCarreras.DisplayMember = "nombre";
                comboBoxCarreras.ValueMember = "id_carrera";

            }
            else
            {
                MessageBox.Show("no hay Carreras existentes");
                Conexion.cerrar();
            }

        }

        public void CargarAlumnos(DataGridView dvg)
        {
            try
            {
                DataTable dtentrenadores = new DataTable();
                string comprobacion = "Select A.NO_CONTROL,A.NOMBRE,A.PATERNO,A.MATERNO,G.DESCRIPCION AS SEXO ,C.NOMBRE AS CARRERA,A.ID_GENERO,A.ID_CARRERA from alumnos A JOIN GENEROS G ON A.ID_GENERO=G.ID_GENERO JOIN CARRERAS C ON A.ID_CARRERA = C.ID_CARRERA where A.ID_TEC ='" + this.textBoxId_tec.Text + "' order by A.no_control";

                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtentrenadores);
                    dvg.DataSource = dtentrenadores;

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




        private void PictureBoxClean_DoubleClick(object sender, EventArgs e) => Limpiar();

        private void PictureBoxDrop_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM alumnos where NO_CONTROL='" + textBoxId_Alumno.Text + "'and ID_TEC='"+this.textBoxId_tec.Text+"'";

                string comprobacion =
                    "SELECT NO_CONTROL from alumnos where NO_CONTROL='" + textBoxId_Alumno.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.CargarAlumnos(this.dataGridViewAlumnos);
                    //limpiar los cuadros de texto
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("El Alumno no existe", "aviso", MessageBoxButtons.OK);
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

        private void PictureBoxUpdate_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from tecsnm where id_tec='" + textBoxId_tec.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZALUMNOS", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;

                act.Parameters.Add("id_NO_CONTROLIN", OracleDbType.Int16).Value = textBoxId_Alumno.Text;
                act.Parameters.Add("id_generoin", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxGeneros.SelectedValue);
                act.Parameters.Add("ID_TECIN", OracleDbType.Int16).Value = textBoxId_tec.Text;
                act.Parameters.Add("ID_CARRERAIN", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxCarreras.SelectedValue);

                act.Parameters.Add("nombrein", OracleDbType.Varchar2).Value = textBoxNombre.Text;
                act.Parameters.Add("paternoin", OracleDbType.Varchar2).Value = textBoxPaterno.Text;
                act.Parameters.Add("maternoin", OracleDbType.Varchar2).Value = textBoxMaterno.Text;
                //aaaa
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                //
                string comprobacion2 =
                    "SELECT NO_CONTROL from alumnos where NO_CONTROL='" + textBoxId_Alumno.Text + "'and ID_TEC='" + this.textBoxId_tec.Text + "'";
                OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                OracleDataReader dr2 = cp2.ExecuteReader();

                if (dr.Read())
                {
                    if (dr2.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                        this.CargarAlumnos(this.dataGridViewAlumnos);
                        this.Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El Alumno no existe", "aviso", MessageBoxButtons.OK);
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

        private void DataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAlumnos.Rows[e.RowIndex];
                this.textBoxNombre.Text = row.Cells["nombre"].Value.ToString();
                this.textBoxPaterno.Text = row.Cells["paterno"].Value.ToString();
                this.textBoxMaterno.Text = row.Cells["materno"].Value.ToString();
                // this.textBoxIdDepto.Text = row.Cells["id_departamento"].Value.ToString();
               
                this.textBoxId_Alumno.Text = row.Cells["NO_CONTROL"].Value.ToString();
                this.comboBoxGeneros.SelectedValue = row.Cells["id_genero"].Value.ToString();
                this.comboBoxCarreras.SelectedValue = row.Cells["id_carrera"].Value.ToString();
            }
        }

        private void PictureBoxClean_DoubleClick_1(object sender, EventArgs e) => Limpiar();
        public void Limpiar()
        {
            this.textBoxId_Alumno.Clear();
            this.textBoxNombre.Clear();
            this.textBoxPaterno.Clear();
            this.textBoxMaterno.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SeleccionAlumno selectAlum = new SeleccionAlumno();
            selectAlum.Show();
        }
    }
}