using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditosGallegos
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //## Settings
                //Path to store the oracle dump
                string path = @"C:\backup";
                string backupFileName = textBox1.Text + ".dmp";
                //your ORACLE_HOME enviroment variable must be setted or you need to set the path here:
                string oracleHome = Environment.GetEnvironmentVariable(@"C:\oraclexe\app\oracle\product\11.2.0\server");
                string oracleUser = "gallegos";
                string oraclePassword = "patito";
                string oracleSID = "xe";
                //###

                ProcessStartInfo psi = new ProcessStartInfo();

                //Exp is the tool used to export data.
                //this tool is inside $ORACLE_HOME\bin directory
                psi.FileName = Path.Combine(@"C:\oraclexe\app\oracle\product\11.2.0\server", "bin", "exp");
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                string dumpFile = Path.Combine(path, backupFileName);
                //The command line is: exp user/password@database file=backupname.dmp [OPTIONS....]
                psi.Arguments = string.Format(oracleUser + "/" + oraclePassword + "@" + oracleSID + " FULL=y FILE=" + dumpFile);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);
                process.WaitForExit();
                process.Close();
                MessageBox.Show("Backup Completado");
                this.Close();
            }
           
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("No existe la ruta del Path de Oracle","Aviso",MessageBoxButtons.OK);
            }
        }
    }
}
