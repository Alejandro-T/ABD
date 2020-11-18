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
    public partial class SeleccionaDepto : Form
    {
        public SeleccionaDepto()
        {
            InitializeComponent();
        }
        public void cargarDepto(DataGridView dvg)
        {
            try
            {
                DataTable dtsgenero = new DataTable();
                string comprobacion = "Select * from departamentos where id_departamento='" + this.textBoxSidDepto.Text + "'";
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
                    MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }


        public void cargarDeptoTodos(DataGridView dvg)
        {
            try
            {
                DataTable dtsdeptobuscar = new DataTable();
                string comprobacion = "Select * from departamentos";
                OracleDataAdapter da = new OracleDataAdapter
                    (comprobacion, Conexion.conectar());
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    da.Fill(dtsdeptobuscar);
                    dvg.DataSource = dtsdeptobuscar;
                }
                else
                {
                    MessageBox.Show("El departamento no existe", "aviso", MessageBoxButtons.OK);
                }
            }


            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }


        }
        private void buttonCbuscar_Click(object sender, EventArgs e)
        {
            cargarDeptoTodos(this.dataGridViewCargaDepto);
        }

        private void btncbuscar_Click(object sender, EventArgs e)
        {
            cargarDepto(this.dataGridViewCargaDepto);
        }
    }
}
