
namespace CreditosGallegos.ArEq
{
    partial class MantenimientoArmEq
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
            this.comboBoxEquipos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxDrop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClean = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewArmEq = new System.Windows.Forms.DataGridView();
            this.textBoxId_tec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxId_Alumno = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClean)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmEq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEquipos
            // 
            this.comboBoxEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEquipos.FormattingEnabled = true;
            this.comboBoxEquipos.Location = new System.Drawing.Point(369, 78);
            this.comboBoxEquipos.Name = "comboBoxEquipos";
            this.comboBoxEquipos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipos.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pictureBoxUpdate);
            this.groupBox3.Controls.Add(this.pictureBoxDrop);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBoxClean);
            this.groupBox3.Location = new System.Drawing.Point(501, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 267);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Selecciona Equipos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = global::CreditosGallegos.Properties.Resources.icons8_update_left_rotation_48px;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(16, 161);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUpdate.TabIndex = 8;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.PictureBoxUpdate_Click);
            // 
            // pictureBoxDrop
            // 
            this.pictureBoxDrop.Image = global::CreditosGallegos.Properties.Resources.icons8_trash_48px_7;
            this.pictureBoxDrop.Location = new System.Drawing.Point(16, 99);
            this.pictureBoxDrop.Name = "pictureBoxDrop";
            this.pictureBoxDrop.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDrop.TabIndex = 7;
            this.pictureBoxDrop.TabStop = false;
            this.pictureBoxDrop.Click += new System.EventHandler(this.PictureBoxDrop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Actualizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Borrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Limpiar";
            // 
            // pictureBoxClean
            // 
            this.pictureBoxClean.Image = global::CreditosGallegos.Properties.Resources.icons8_broom_52px_1;
            this.pictureBoxClean.Location = new System.Drawing.Point(16, 43);
            this.pictureBoxClean.Name = "pictureBoxClean";
            this.pictureBoxClean.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClean.TabIndex = 3;
            this.pictureBoxClean.TabStop = false;
            this.pictureBoxClean.Click += new System.EventHandler(this.PictureBoxClean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Id_Tec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Equipos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewArmEq);
            this.groupBox2.Location = new System.Drawing.Point(-3, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 220);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Datos";
            // 
            // dataGridViewArmEq
            // 
            this.dataGridViewArmEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArmEq.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewArmEq.Name = "dataGridViewArmEq";
            this.dataGridViewArmEq.Size = new System.Drawing.Size(476, 186);
            this.dataGridViewArmEq.TabIndex = 5;
            this.dataGridViewArmEq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewArmEq_CellContentClick);
            // 
            // textBoxId_tec
            // 
            this.textBoxId_tec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId_tec.Enabled = false;
            this.textBoxId_tec.Location = new System.Drawing.Point(382, 34);
            this.textBoxId_tec.Name = "textBoxId_tec";
            this.textBoxId_tec.Size = new System.Drawing.Size(100, 13);
            this.textBoxId_tec.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxId_Alumno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 140);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Id_Alumno";
            // 
            // textBoxId_Alumno
            // 
            this.textBoxId_Alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId_Alumno.Location = new System.Drawing.Point(83, 26);
            this.textBoxId_Alumno.Name = "textBoxId_Alumno";
            this.textBoxId_Alumno.Size = new System.Drawing.Size(100, 13);
            this.textBoxId_Alumno.TabIndex = 1;
            // 
            // MantenimientoArmEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 413);
            this.Controls.Add(this.comboBoxEquipos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxId_tec);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoArmEq";
            this.Text = "MantenimientoArmEq";
            this.Load += new System.EventHandler(this.MantenimientoArmEq_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClean)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmEq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEquipos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.PictureBox pictureBoxDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxClean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewArmEq;
        private System.Windows.Forms.TextBox textBoxId_tec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxId_Alumno;
    }
}