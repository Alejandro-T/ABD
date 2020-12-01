namespace CreditosGallegos.Departamentos
{
    partial class InsertaDepartamentos
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdtec = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgreagrDept = new System.Windows.Forms.Button();
            this.textBoxdescDpto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Tec";
            // 
            // textBoxIdtec
            // 
            this.textBoxIdtec.BackColor = System.Drawing.Color.White;
            this.textBoxIdtec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdtec.Enabled = false;
            this.textBoxIdtec.Location = new System.Drawing.Point(186, 69);
            this.textBoxIdtec.Name = "textBoxIdtec";
            this.textBoxIdtec.Size = new System.Drawing.Size(100, 13);
            this.textBoxIdtec.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 151);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre del Departamento";
            // 
            // btnAgreagrDept
            // 
            this.btnAgreagrDept.Location = new System.Drawing.Point(199, 131);
            this.btnAgreagrDept.Name = "btnAgreagrDept";
            this.btnAgreagrDept.Size = new System.Drawing.Size(75, 23);
            this.btnAgreagrDept.TabIndex = 17;
            this.btnAgreagrDept.Text = "Agregar";
            this.btnAgreagrDept.UseVisualStyleBackColor = true;
            this.btnAgreagrDept.Click += new System.EventHandler(this.btnAgreagrDept_Click);
            // 
            // textBoxdescDpto
            // 
            this.textBoxdescDpto.BackColor = System.Drawing.Color.White;
            this.textBoxdescDpto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdescDpto.Location = new System.Drawing.Point(186, 98);
            this.textBoxdescDpto.Name = "textBoxdescDpto";
            this.textBoxdescDpto.Size = new System.Drawing.Size(100, 13);
            this.textBoxdescDpto.TabIndex = 16;
            // 
            // InsertaDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdtec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgreagrDept);
            this.Controls.Add(this.textBoxdescDpto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertaDepartamentos";
            this.Text = "AgregaDepartamentos";
            this.Load += new System.EventHandler(this.InsertaDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdtec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgreagrDept;
        private System.Windows.Forms.TextBox textBoxdescDpto;
    }
}