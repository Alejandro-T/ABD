﻿using Oracle.DataAccess.Client;
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
    public partial class MantenimientoEntrena : Form
    {
        public MantenimientoEntrena()
        {
            InitializeComponent();
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
                comboBoxGeneros.Items.Clear();
                while (dr.Read())
                {
                    comboBoxGeneros.DataSource = dt;
                    comboBoxGeneros.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxGeneros.ValueMember = dt.Columns[0].ColumnName;
                }
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
                comboBoxDpto.Items.Clear();
                while (dr.Read())
                {
                    comboBoxDpto.DataSource = dt;
                    comboBoxDpto.DisplayMember = dt.Columns[2].ColumnName;
                    comboBoxDpto.ValueMember = dt.Columns[0].ColumnName;
                }
            }
        }





        public void cargarEntrenadores(DataGridView dvg)
        {
            try
            {
                DataTable dtentrenadores = new DataTable();
                string comprobacion = "Select * from entrenadores";
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
        private void MantenimientoEntrena_Load(object sender, EventArgs e)
        {
            this.seleccionacomboDepto();
            this.seleccionacomboGenero();
            this.cargarEntrenadores(dataGridViewEntrenadores);
        }

        private void dataGridViewEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewEntrenadores.Rows[e.RowIndex];
                this.textBoxNombre.Text = row.Cells["nombre"].Value.ToString();
                this.textBoxPaterno.Text = row.Cells["paterno"].Value.ToString();
                this.textBoxMaterno.Text = row.Cells["materno"].Value.ToString();
                // this.textBoxIdDepto.Text = row.Cells["id_departamento"].Value.ToString();
                this.textBoxId_tec.Text = row.Cells["id_tec"].Value.ToString();
                this.textBoxId_entrena.Text = row.Cells["id_entrenador"].Value.ToString();
                this.comboBoxGeneros.SelectedValue = row.Cells["id_genero"].Value.ToString();
                this.comboBoxDpto.SelectedValue = row.Cells["id_departamento"].Value.ToString();
            }
        }

        private void pictureBoxClean_DoubleClick(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            this.textBoxId_tec.Clear();
            this.textBoxMaterno.Clear();
            this.textBoxNombre.Clear();
            this.textBoxPaterno.Clear();
            this.textBoxId_entrena.Clear();
            //this.comboBoxDpto.Items.Clear();
            //this.comboBoxGeneros.Items.Clear();
        }

        private void pictureBoxDrop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM entrenadores where id_entrenador='" + textBoxId_entrena.Text + "'";

                string comprobacion =
                    "SELECT id_entrenador from entrenadores where id_entrenador='" + textBoxId_entrena.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand(query, Conexion.conectar());
                    OracleDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Borrado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el valor actual.
                    this.cargarEntrenadores(this.dataGridViewEntrenadores);
                    //limpiar los cuadros de texto
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("El entrenador no existe no existe", "aviso", MessageBoxButtons.OK);
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

        private void pictureBoxUpdate_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string comprobacion = "select id_tec from tecsnm where id_tec='" + textBoxId_tec.Text + "'";
                OracleCommand act = new OracleCommand("ACTUALIZAENTRENA", Conexion.conectar());
                act.CommandType = System.Data.CommandType.StoredProcedure;

                act.Parameters.Add("id_ENTRENADORIN", OracleDbType.Int16).Value = textBoxId_entrena.Text;
                act.Parameters.Add("id_generoin", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxGeneros.SelectedValue);
                act.Parameters.Add("ID_TECIN", OracleDbType.Int16).Value = textBoxId_tec.Text;
                act.Parameters.Add("ID_DEPARTAMENTOIN", OracleDbType.Int16).Value = Convert.ToInt16(comboBoxDpto.SelectedValue);

                act.Parameters.Add("nombrein", OracleDbType.Varchar2).Value = textBoxNombre.Text;
                act.Parameters.Add("paternoin", OracleDbType.Varchar2).Value = textBoxPaterno.Text;
                act.Parameters.Add("maternoin", OracleDbType.Varchar2).Value = textBoxMaterno.Text;
                //aaaa
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                //
                string comprobacion2 =
                    "SELECT id_entrenador from entrenadores where id_entrenador='" + textBoxId_entrena.Text + "'";
                OracleCommand cp2 = new OracleCommand(comprobacion2, Conexion.conectar());
                OracleDataReader dr2 = cp2.ExecuteReader();

                if (dr.Read())
                {
                    if (dr2.Read())
                    {
                        act.ExecuteNonQuery();
                        MessageBox.Show("Dato actualizado con exito", "exito", MessageBoxButtons.OK);
                        this.cargarEntrenadores(this.dataGridViewEntrenadores);
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
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}