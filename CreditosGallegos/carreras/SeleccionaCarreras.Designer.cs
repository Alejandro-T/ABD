namespace CreditosGallegos.carreras
{
    partial class SeleccionaCarreras
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
            this.textBoxSidCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCargaCarreras = new System.Windows.Forms.DataGridView();
            this.btncbuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCbuscar);
            this.panel1.Controls.Add(this.textBoxSidCarrera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewCargaCarreras);
            this.panel1.Controls.Add(this.btncbuscar);
            this.panel1.Location = new System.Drawing.Point(50, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 320);
            this.panel1.TabIndex = 11;
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
            // textBoxSidCarrera
            // 
            this.textBoxSidCarrera.BackColor = System.Drawing.Color.White;
            this.textBoxSidCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSidCarrera.Location = new System.Drawing.Point(136, 44);
            this.textBoxSidCarrera.Name = "textBoxSidCarrera";
            this.textBoxSidCarrera.Size = new System.Drawing.Size(100, 13);
            this.textBoxSidCarrera.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id_carrera";
            // 
            // dataGridViewCargaCarreras
            // 
            this.dataGridViewCargaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargaCarreras.Location = new System.Drawing.Point(27, 83);
            this.dataGridViewCargaCarreras.Name = "dataGridViewCargaCarreras";
            this.dataGridViewCargaCarreras.Size = new System.Drawing.Size(359, 150);
            this.dataGridViewCargaCarreras.TabIndex = 7;
            this.dataGridViewCargaCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCargaCarreras_CellContentClick);
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
            // SeleccionaCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionaCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionaCarreras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCbuscar;
        private System.Windows.Forms.TextBox textBoxSidCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCargaCarreras;
        private System.Windows.Forms.Button btncbuscar;
    }
}