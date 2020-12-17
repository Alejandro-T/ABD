namespace CreditosGallegos.Entrenadores
{
    partial class MantenimientoEntrena
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxDrop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClean = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEntrenadores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxId_entrena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxId_tec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGeneros = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDpto = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClean)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(511, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 267);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Selecciona Entrenador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = global::CreditosGallegos.Properties.Resources.icons8_update_left_rotation_48px;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(16, 161);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUpdate.TabIndex = 8;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.DoubleClick += new System.EventHandler(this.pictureBoxUpdate_DoubleClick);
            // 
            // pictureBoxDrop
            // 
            this.pictureBoxDrop.Image = global::CreditosGallegos.Properties.Resources.icons8_trash_48px_7;
            this.pictureBoxDrop.Location = new System.Drawing.Point(16, 99);
            this.pictureBoxDrop.Name = "pictureBoxDrop";
            this.pictureBoxDrop.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDrop.TabIndex = 7;
            this.pictureBoxDrop.TabStop = false;
            this.pictureBoxDrop.DoubleClick += new System.EventHandler(this.pictureBoxDrop_DoubleClick);
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
            this.pictureBoxClean.DoubleClick += new System.EventHandler(this.pictureBoxClean_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewEntrenadores);
            this.groupBox2.Location = new System.Drawing.Point(7, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 220);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Datos";
            // 
            // dataGridViewEntrenadores
            // 
            this.dataGridViewEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrenadores.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEntrenadores.Name = "dataGridViewEntrenadores";
            this.dataGridViewEntrenadores.Size = new System.Drawing.Size(476, 186);
            this.dataGridViewEntrenadores.TabIndex = 9;
            this.dataGridViewEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntrenadores_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxId_entrena);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxMaterno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPaterno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Id_entrena";
            // 
            // textBoxId_entrena
            // 
            this.textBoxId_entrena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId_entrena.Location = new System.Drawing.Point(84, 26);
            this.textBoxId_entrena.Name = "textBoxId_entrena";
            this.textBoxId_entrena.Size = new System.Drawing.Size(100, 13);
            this.textBoxId_entrena.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Materno";
            // 
            // textBoxMaterno
            // 
            this.textBoxMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaterno.Location = new System.Drawing.Point(84, 106);
            this.textBoxMaterno.Name = "textBoxMaterno";
            this.textBoxMaterno.Size = new System.Drawing.Size(229, 13);
            this.textBoxMaterno.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Paterno";
            // 
            // textBoxPaterno
            // 
            this.textBoxPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPaterno.Location = new System.Drawing.Point(84, 80);
            this.textBoxPaterno.Name = "textBoxPaterno";
            this.textBoxPaterno.Size = new System.Drawing.Size(229, 13);
            this.textBoxPaterno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Location = new System.Drawing.Point(84, 52);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(229, 13);
            this.textBoxNombre.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id_Tec";
            // 
            // textBoxId_tec
            // 
            this.textBoxId_tec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId_tec.Enabled = false;
            this.textBoxId_tec.Location = new System.Drawing.Point(387, 40);
            this.textBoxId_tec.Name = "textBoxId_tec";
            this.textBoxId_tec.Size = new System.Drawing.Size(100, 13);
            this.textBoxId_tec.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Departamento";
            // 
            // comboBoxGeneros
            // 
            this.comboBoxGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGeneros.FormattingEnabled = true;
            this.comboBoxGeneros.Location = new System.Drawing.Point(379, 76);
            this.comboBoxGeneros.Name = "comboBoxGeneros";
            this.comboBoxGeneros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGeneros.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Generos";
            // 
            // comboBoxDpto
            // 
            this.comboBoxDpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDpto.FormattingEnabled = true;
            this.comboBoxDpto.Location = new System.Drawing.Point(379, 123);
            this.comboBoxDpto.Name = "comboBoxDpto";
            this.comboBoxDpto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDpto.TabIndex = 7;
            // 
            // MantenimientoEntrena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 389);
            this.Controls.Add(this.comboBoxDpto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxGeneros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxId_tec);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MantenimientoEntrena";
            this.Text = "MantenimientoEntrena";
            this.Load += new System.EventHandler(this.MantenimientoEntrena_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClean)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.PictureBox pictureBoxDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxClean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewEntrenadores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxId_tec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPaterno;
        private System.Windows.Forms.ComboBox comboBoxGeneros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxDpto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxId_entrena;
        private System.Windows.Forms.Button button1;
    }
}