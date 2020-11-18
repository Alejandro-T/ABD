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
    public partial class InsertaCarreras : Form
    {
        
        public InsertaCarreras()
        {
            InitializeComponent();
        }
        OracleDataReader dr;
        public void cargarCarreras(DataGridView dvg)
        {
            DataTable dtsgenero = new DataTable();
            string comprobacion = "Select * from carreras where nombre='" + this.textBoxdescCarrera.Text + "'";
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

        }
        private void btnAgreagrCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobacion =
               "SELECT id_tec from tecsnm where id_tec='" + textBoxIdtec.Text + "'";
                OracleCommand cp = new OracleCommand(comprobacion, Conexion.conectar());
                OracleDataReader dr = cp.ExecuteReader();
                if (dr.Read())
                {
                    OracleCommand comando = new OracleCommand("insertar_carreras", Conexion.conectar());
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id_tec", OracleDbType.Int16).Value = this.textBoxIdtec.Text;
                    comando.Parameters.Add("@nombre", OracleDbType.Varchar2).Value = this.textBoxdescCarrera.Text;

                    comando.ExecuteNonQuery();
                    MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
                    //Select para saber el numero actual.
                    this.cargarCarreras(this.dataGridView1);
                }
                else
                {
                    MessageBox.Show("no existe el tec", "aviso", MessageBoxButtons.OK);
                }
            }
            catch (Oracle.DataAccess.Client.OracleException)
            {
                MessageBox.Show("Formato invalido", "Aviso", MessageBoxButtons.OK);
            }
            
           
               
        }
    }
}
