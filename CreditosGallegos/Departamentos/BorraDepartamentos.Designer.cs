namespace CreditosGallegos.Departamentos
{
    partial class BorraDepartamentos
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBDepto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBidDepto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBDepto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CreditosGallegos.Properties.Resources.icons8_checkmark_48px;
            this.pictureBox2.Location = new System.Drawing.Point(335, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditosGallegos.Properties.Resources.icons8_delete_48px;
            this.pictureBox1.Location = new System.Drawing.Point(163, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // dataGridViewBDepto
            // 
            this.dataGridViewBDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBDepto.Location = new System.Drawing.Point(72, 184);
            this.dataGridViewBDepto.Name = "dataGridViewBDepto";
            this.dataGridViewBDepto.Size = new System.Drawing.Size(389, 150);
            this.dataGridViewBDepto.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id_Departamento";
            // 
            // textBoxBidDepto
            // 
            this.textBoxBidDepto.BackColor = System.Drawing.Color.White;
            this.textBoxBidDepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBidDepto.Location = new System.Drawing.Point(196, 49);
            this.textBoxBidDepto.Name = "textBoxBidDepto";
            this.textBoxBidDepto.Size = new System.Drawing.Size(100, 13);
            this.textBoxBidDepto.TabIndex = 21;
            // 
            // BorraDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 401);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewBDepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBidDepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorraDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorraDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBDepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBDepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBidDepto;
    }
}