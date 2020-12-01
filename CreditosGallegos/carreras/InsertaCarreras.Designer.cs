namespace CreditosGallegos.carreras
{
    partial class InsertaCarreras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgreagrCarrera = new System.Windows.Forms.Button();
            this.textBoxdescCarrera = new System.Windows.Forms.TextBox();
            this.textBoxIdtec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 151);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre de la carrera";
            // 
            // btnAgreagrCarrera
            // 
            this.btnAgreagrCarrera.Location = new System.Drawing.Point(183, 116);
            this.btnAgreagrCarrera.Name = "btnAgreagrCarrera";
            this.btnAgreagrCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnAgreagrCarrera.TabIndex = 11;
            this.btnAgreagrCarrera.Text = "Agregar";
            this.btnAgreagrCarrera.UseVisualStyleBackColor = true;
            this.btnAgreagrCarrera.Click += new System.EventHandler(this.btnAgreagrCarrera_Click);
            // 
            // textBoxdescCarrera
            // 
            this.textBoxdescCarrera.BackColor = System.Drawing.Color.White;
            this.textBoxdescCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdescCarrera.Location = new System.Drawing.Point(170, 83);
            this.textBoxdescCarrera.Name = "textBoxdescCarrera";
            this.textBoxdescCarrera.Size = new System.Drawing.Size(100, 13);
            this.textBoxdescCarrera.TabIndex = 10;
            // 
            // textBoxIdtec
            // 
            this.textBoxIdtec.BackColor = System.Drawing.Color.White;
            this.textBoxIdtec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdtec.Enabled = false;
            this.textBoxIdtec.Location = new System.Drawing.Point(170, 54);
            this.textBoxIdtec.Name = "textBoxIdtec";
            this.textBoxIdtec.Size = new System.Drawing.Size(100, 13);
            this.textBoxIdtec.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id Tec";
            // 
            // InsertaCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdtec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgreagrCarrera);
            this.Controls.Add(this.textBoxdescCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertaCarreras";
            this.Text = "InsertaCarreras";
            this.Load += new System.EventHandler(this.InsertaCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgreagrCarrera;
        private System.Windows.Forms.TextBox textBoxdescCarrera;
        private System.Windows.Forms.TextBox textBoxIdtec;
        private System.Windows.Forms.Label label2;
    }
}