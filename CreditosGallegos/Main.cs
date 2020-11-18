using CreditosGallegos.carreras;
using CreditosGallegos.Departamentos;
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
    public partial class InsertarCarreras : Form
    {
        public int LUser = 0;
        public InsertarCarreras()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generos g = new Generos();
            g.Show();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Generos());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
            timer1.Interval = 100;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCarreras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Carreras());
        }

        private void buttonDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Depto());
        }


        int posx = 0;
        int posy = 0;
        private void InsertarCarreras_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult yes;
            yes = MessageBox.Show("¿Deseas salir?", "Aviso", MessageBoxButtons.YesNo);
            if(yes == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
