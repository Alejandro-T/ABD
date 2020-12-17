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
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MantenimientoCarreras());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InsertaCarreras());
        }

       
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new SeleccionaCarreras());
        }

        private void Carreras_Load(object sender, EventArgs e)
        {

        }
    }
}
