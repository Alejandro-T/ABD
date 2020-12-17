
namespace CreditosGallegos.ArEq
{
    partial class InsertArmEq
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
            this.textBoxMatriculaAl = new System.Windows.Forms.TextBox();
            this.dataGridViewArmaEq = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgreagrArmEqui = new System.Windows.Forms.Button();
            this.textBoxid_tec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmaEq)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Matricula Alumno";
            // 
            // textBoxMatriculaAl
            // 
            this.textBoxMatriculaAl.BackColor = System.Drawing.Color.White;
            this.textBoxMatriculaAl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatriculaAl.Location = new System.Drawing.Point(205, 49);
            this.textBoxMatriculaAl.Name = "textBoxMatriculaAl";
            this.textBoxMatriculaAl.Size = new System.Drawing.Size(100, 13);
            this.textBoxMatriculaAl.TabIndex = 2;
            // 
            // dataGridViewArmaEq
            // 
            this.dataGridViewArmaEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArmaEq.Location = new System.Drawing.Point(91, 140);
            this.dataGridViewArmaEq.Name = "dataGridViewArmaEq";
            this.dataGridViewArmaEq.Size = new System.Drawing.Size(357, 151);
            this.dataGridViewArmaEq.TabIndex = 5;
            this.dataGridViewArmaEq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewArmaEq_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eq Deportivo";
            // 
            // btnAgreagrArmEqui
            // 
            this.btnAgreagrArmEqui.Location = new System.Drawing.Point(218, 111);
            this.btnAgreagrArmEqui.Name = "btnAgreagrArmEqui";
            this.btnAgreagrArmEqui.Size = new System.Drawing.Size(75, 23);
            this.btnAgreagrArmEqui.TabIndex = 4;
            this.btnAgreagrArmEqui.Text = "Agregar";
            this.btnAgreagrArmEqui.UseVisualStyleBackColor = true;
            this.btnAgreagrArmEqui.Click += new System.EventHandler(this.BtnAgreagrCarrera_Click);
            // 
            // textBoxid_tec
            // 
            this.textBoxid_tec.BackColor = System.Drawing.Color.White;
            this.textBoxid_tec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxid_tec.Enabled = false;
            this.textBoxid_tec.Location = new System.Drawing.Point(205, 20);
            this.textBoxid_tec.Name = "textBoxid_tec";
            this.textBoxid_tec.Size = new System.Drawing.Size(100, 13);
            this.textBoxid_tec.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Id_tec";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // InsertArmEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 366);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxid_tec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMatriculaAl);
            this.Controls.Add(this.dataGridViewArmaEq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgreagrArmEqui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertArmEq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertArmEq";
            this.Load += new System.EventHandler(this.InsertArmEq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmaEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMatriculaAl;
        private System.Windows.Forms.DataGridView dataGridViewArmaEq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgreagrArmEqui;
        private System.Windows.Forms.TextBox textBoxid_tec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}