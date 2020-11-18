namespace CreditosGallegos
{
    partial class SeleccionaGeneros
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
            this.textBoxSidGnero = new System.Windows.Forms.TextBox();
            this.dataGridViewCargaGeneros = new System.Windows.Forms.DataGridView();
            this.btnSbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaGeneros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSidGnero
            // 
            this.textBoxSidGnero.BackColor = System.Drawing.Color.White;
            this.textBoxSidGnero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSidGnero.Location = new System.Drawing.Point(136, 44);
            this.textBoxSidGnero.Name = "textBoxSidGnero";
            this.textBoxSidGnero.Size = new System.Drawing.Size(100, 13);
            this.textBoxSidGnero.TabIndex = 6;
            // 
            // dataGridViewCargaGeneros
            // 
            this.dataGridViewCargaGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargaGeneros.Location = new System.Drawing.Point(27, 83);
            this.dataGridViewCargaGeneros.Name = "dataGridViewCargaGeneros";
            this.dataGridViewCargaGeneros.Size = new System.Drawing.Size(359, 150);
            this.dataGridViewCargaGeneros.TabIndex = 7;
            this.dataGridViewCargaGeneros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCargaGeneros_CellContentClick);
            // 
            // btnSbuscar
            // 
            this.btnSbuscar.Location = new System.Drawing.Point(63, 271);
            this.btnSbuscar.Name = "btnSbuscar";
            this.btnSbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnSbuscar.TabIndex = 8;
            this.btnSbuscar.Text = "Buscar";
            this.btnSbuscar.UseVisualStyleBackColor = true;
            this.btnSbuscar.Click += new System.EventHandler(this.btnSbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id_Genero";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxSidGnero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewCargaGeneros);
            this.panel1.Controls.Add(this.btnSbuscar);
            this.panel1.Location = new System.Drawing.Point(50, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 320);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionaGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionaGeneros";
            this.Load += new System.EventHandler(this.SeleccionaGeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaGeneros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSidGnero;
        private System.Windows.Forms.DataGridView dataGridViewCargaGeneros;
        private System.Windows.Forms.Button btnSbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}