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

namespace CreditosGallegos
{
    public partial class AgregaGeneros : Form
    {
        public AgregaGeneros()
        {
            InitializeComponent();
        }

        private void btnAgreagrGenero_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("insertar_genero", Conexion.conectar());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = this.textBoxdescrpcGenero.Text;
            //comando.Parameters.Add("@edad", OracleDbType.Int16).Value = this.textBoxidGnero.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("insertado", "aviso", MessageBoxButtons.OK);
        }

        private void AgregaGeneros_Load(object sender, EventArgs e)
        {

        }
    }
}
