namespace CreditosGallegos.Departamentos
{
    partial class SeleccionaDepto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCbuscar = new System.Windows.Forms.Button();
            this.textBoxSidDepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCargaDepto = new System.Windows.Forms.DataGridView();
            this.btncbuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaDepto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCbuscar);
            this.panel1.Controls.Add(this.textBoxSidDepto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewCargaDepto);
            this.panel1.Controls.Add(this.btncbuscar);
            this.panel1.Location = new System.Drawing.Point(70, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 320);
            this.panel1.TabIndex = 12;
            // 
            // buttonCbuscar
            // 
            this.buttonCbuscar.Location = new System.Drawing.Point(234, 271);
            this.buttonCbuscar.Name = "buttonCbuscar";
            this.buttonCbuscar.Size = new System.Drawing.Size(141, 23);
            this.buttonCbuscar.TabIndex = 10;
            this.buttonCbuscar.Text = "Buscar Todos";
            this.buttonCbuscar.UseVisualStyleBackColor = true;
            this.buttonCbuscar.Click += new System.EventHandler(this.buttonCbuscar_Click);
            // 
            // textBoxSidDepto
            // 
            this.textBoxSidDepto.BackColor = System.Drawing.Color.White;
            this.textBoxSidDepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSidDepto.Location = new System.Drawing.Point(136, 44);
            this.textBoxSidDepto.Name = "textBoxSidDepto";
            this.textBoxSidDepto.Size = new System.Drawing.Size(100, 13);
            this.textBoxSidDepto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id_Departamento";
            // 
            // dataGridViewCargaDepto
            // 
            this.dataGridViewCargaDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargaDepto.Location = new System.Drawing.Point(27, 83);
            this.dataGridViewCargaDepto.Name = "dataGridViewCargaDepto";
            this.dataGridViewCargaDepto.Size = new System.Drawing.Size(359, 150);
            this.dataGridViewCargaDepto.TabIndex = 7;
            // 
            // btncbuscar
            // 
            this.btncbuscar.Location = new System.Drawing.Point(63, 271);
            this.btncbuscar.Name = "btncbuscar";
            this.btncbuscar.Size = new System.Drawing.Size(75, 23);
            this.btncbuscar.TabIndex = 8;
            this.btncbuscar.Text = "Buscar";
            this.btncbuscar.UseVisualStyleBackColor = true;
            this.btncbuscar.Click += new System.EventHandler(this.btncbuscar_Click);
            // 
            // SeleccionaDepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 432);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionaDepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionaDepto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaDepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCbuscar;
        private System.Windows.Forms.TextBox textBoxSidDepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCargaDepto;
        private System.Windows.Forms.Button btncbuscar;
    }
}