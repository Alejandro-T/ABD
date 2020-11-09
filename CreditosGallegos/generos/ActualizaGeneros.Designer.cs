namespace CreditosGallegos.generos
{
    partial class ActualizaGeneros
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
            this.textBoxAidGnero = new System.Windows.Forms.TextBox();
            this.dataGridViewAGeneros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxActualizaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAidGnero
            // 
            this.textBoxAidGnero.BackColor = System.Drawing.Color.White;
            this.textBoxAidGnero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAidGnero.Location = new System.Drawing.Point(201, 47);
            this.textBoxAidGnero.Name = "textBoxAidGnero";
            this.textBoxAidGnero.Size = new System.Drawing.Size(100, 13);
            this.textBoxAidGnero.TabIndex = 10;
            // 
            // dataGridViewAGeneros
            // 
            this.dataGridViewAGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAGeneros.Location = new System.Drawing.Point(60, 181);
            this.dataGridViewAGeneros.Name = "dataGridViewAGeneros";
            this.dataGridViewAGeneros.Size = new System.Drawing.Size(389, 150);
            this.dataGridViewAGeneros.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id_Genero";
            // 
            // textBoxActualizaNombre
            // 
            this.textBoxActualizaNombre.BackColor = System.Drawing.Color.White;
            this.textBoxActualizaNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxActualizaNombre.Location = new System.Drawing.Point(201, 122);
            this.textBoxActualizaNombre.Name = "textBoxActualizaNombre";
            this.textBoxActualizaNombre.Size = new System.Drawing.Size(100, 13);
            this.textBoxActualizaNombre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre genero";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CreditosGallegos.Properties.Resources.icons8_checkmark_48px;
            this.pictureBox2.Location = new System.Drawing.Point(423, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditosGallegos.Properties.Resources.icons8_delete_48px;
            this.pictureBox1.Location = new System.Drawing.Point(90, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // ActualizaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxActualizaNombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewAGeneros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAidGnero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizaGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizaGeneros";
            this.Load += new System.EventHandler(this.ActualizaGeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAidGnero;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewAGeneros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxActualizaNombre;
        private System.Windows.Forms.Label label2;
    }
}