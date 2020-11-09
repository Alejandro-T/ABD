namespace CreditosGallegos
{
    partial class AgregaGeneros
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
            this.textBoxdescrpcGenero = new System.Windows.Forms.TextBox();
            this.textBoxidGnero = new System.Windows.Forms.TextBox();
            this.btnAgreagrGenero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxdescrpcGenero
            // 
            this.textBoxdescrpcGenero.BackColor = System.Drawing.Color.White;
            this.textBoxdescrpcGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdescrpcGenero.Location = new System.Drawing.Point(172, 145);
            this.textBoxdescrpcGenero.Name = "textBoxdescrpcGenero";
            this.textBoxdescrpcGenero.Size = new System.Drawing.Size(100, 13);
            this.textBoxdescrpcGenero.TabIndex = 6;
            // 
            // textBoxidGnero
            // 
            this.textBoxidGnero.BackColor = System.Drawing.Color.White;
            this.textBoxidGnero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxidGnero.Location = new System.Drawing.Point(172, 97);
            this.textBoxidGnero.Name = "textBoxidGnero";
            this.textBoxidGnero.Size = new System.Drawing.Size(100, 13);
            this.textBoxidGnero.TabIndex = 5;
            // 
            // btnAgreagrGenero
            // 
            this.btnAgreagrGenero.Location = new System.Drawing.Point(183, 189);
            this.btnAgreagrGenero.Name = "btnAgreagrGenero";
            this.btnAgreagrGenero.Size = new System.Drawing.Size(75, 23);
            this.btnAgreagrGenero.TabIndex = 7;
            this.btnAgreagrGenero.Text = "Agregar";
            this.btnAgreagrGenero.UseVisualStyleBackColor = true;
            this.btnAgreagrGenero.Click += new System.EventHandler(this.btnAgreagrGenero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del genero";
            // 
            // ActualizarGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgreagrGenero);
            this.Controls.Add(this.textBoxdescrpcGenero);
            this.Controls.Add(this.textBoxidGnero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregaGeneros";
            this.Load += new System.EventHandler(this.AgregaGeneros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxdescrpcGenero;
        private System.Windows.Forms.TextBox textBoxidGnero;
        private System.Windows.Forms.Button btnAgreagrGenero;
        private System.Windows.Forms.Label label1;
    }
}