
namespace CreditosGallegos.EqDeportivos
{
    partial class AgregaEq
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
            this.dataGridViewEntrenadores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTec = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEntrenador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEntrenadores
            // 
            this.dataGridViewEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrenadores.Location = new System.Drawing.Point(45, 169);
            this.dataGridViewEntrenadores.Name = "dataGridViewEntrenadores";
            this.dataGridViewEntrenadores.Size = new System.Drawing.Size(551, 130);
            this.dataGridViewEntrenadores.TabIndex = 5;
            this.dataGridViewEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntrenadores_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id_Tec";
            // 
            // textBoxTec
            // 
            this.textBoxTec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTec.Enabled = false;
            this.textBoxTec.Location = new System.Drawing.Point(24, 123);
            this.textBoxTec.Name = "textBoxTec";
            this.textBoxTec.Size = new System.Drawing.Size(100, 13);
            this.textBoxTec.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxTec);
            this.groupBox1.Controls.Add(this.textBoxEntrenador);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(83, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id_Entrenador";
            // 
            // textBoxEntrenador
            // 
            this.textBoxEntrenador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEntrenador.Location = new System.Drawing.Point(24, 81);
            this.textBoxEntrenador.Name = "textBoxEntrenador";
            this.textBoxEntrenador.Size = new System.Drawing.Size(100, 13);
            this.textBoxEntrenador.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(24, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 13);
            this.textBoxName.TabIndex = 1;
            // 
            // AgregaEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.dataGridViewEntrenadores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregaEq";
            this.Text = "AgregaEq";
            this.Load += new System.EventHandler(this.AgregaEq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEntrenadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEntrenador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
    }
}