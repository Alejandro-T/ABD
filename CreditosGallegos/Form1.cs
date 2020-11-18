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

namespace CreditosGallegos
{
    public partial class Form1 : Form
    {
        public static int id=0;
        public Form1()
        {
            InitializeComponent();
        }
        public int id_tec = 0;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.conectar();
                
            }
            catch
            {
                MessageBox.Show("Conexion con errores", "aviso", MessageBoxButtons.OK);
            }
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }
        int posx = 0;
        int posy = 0;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
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
        public byte intento = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string comp = "Select id_tec from tecsnm where id_tec='" + this.textBoxUser.Text + "'";
            
         
            OracleCommand cpe = new OracleCommand(comp, Conexion.conectar());
            OracleDataReader dre = cpe.ExecuteReader();
            if (dre.Read())
            {
                
                string comprobacion2 = "Select * from tecsnm where nombre='" + this.textBoxPassword.Text + "'";
                
               
                cpe = new OracleCommand(comprobacion2, Conexion.conectar());
                dre = cpe.ExecuteReader();
                if (dre.Read())
                {
                    MessageBox.Show("BIENVENIDO "+textBoxPassword.Text, "aviso", MessageBoxButtons.OK);

                    //Mostar menu
                    
                    InsertarCarreras m = new InsertarCarreras();
                    m.ShowDialog();
                    this.Close();




                }
                else
                {
                    intento += 1;
                }
            }
            else
            {
                intento += 1;
                if (intento == 3)
                {
                    MessageBox.Show("Adios", "aviso", MessageBoxButtons.OK);
                    Application.Exit();
                }
                MessageBox.Show("Error no existe", "aviso", MessageBoxButtons.OK);
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            DialogResult yes;
            yes = MessageBox.Show("¿Desea salir?","Aviso",MessageBoxButtons.YesNo);
            if(yes == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
