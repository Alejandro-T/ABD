namespace CreditosGallegos.carreras
{
    partial class ActualizaCarreras
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxid_name = new System.Windows.Forms.CheckBox();
            this.checkBoxid = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewCarrera = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxbusca_id_carrera = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxid_name);
            this.groupBox2.Controls.Add(this.checkBoxid);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Location = new System.Drawing.Point(49, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 108);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecciona campo a actualizar";
            // 
            // checkBoxid_name
            // 
            this.checkBoxid_name.AutoSize = true;
            this.checkBoxid_name.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.checkBoxid_name.Location = new System.Drawing.Point(39, 31);
            this.checkBoxid_name.Name = "checkBoxid_name";
            this.checkBoxid_name.Size = new System.Drawing.Size(84, 20);
            this.checkBoxid_name.TabIndex = 4;
            this.checkBoxid_name.Text = "Nombre";
            this.checkBoxid_name.UseVisualStyleBackColor = true;
            this.checkBoxid_name.CheckedChanged += new System.EventHandler(this.checkBoxid_tec_CheckedChanged);
            // 
            // checkBoxid
            // 
            this.checkBoxid.AutoSize = true;
            this.checkBoxid.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.checkBoxid.Location = new System.Drawing.Point(174, 31);
            this.checkBoxid.Name = "checkBoxid";
            this.checkBoxid.Size = new System.Drawing.Size(70, 20);
            this.checkBoxid.TabIndex = 5;
            this.checkBoxid.Text = "Id_tec";
            this.checkBoxid.UseVisualStyleBackColor = true;
            this.checkBoxid.CheckedChanged += new System.EventHandler(this.checkBoxNombre_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(27, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditosGallegos.Properties.Resources.icons8_checkmark_48px;
            this.pictureBox1.Location = new System.Drawing.Point(431, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // dataGridViewCarrera
            // 
            this.dataGridViewCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrera.Location = new System.Drawing.Point(67, 150);
            this.dataGridViewCarrera.Name = "dataGridViewCarrera";
            this.dataGridViewCarrera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCarrera.RowHeadersVisible = false;
            this.dataGridViewCarrera.Size = new System.Drawing.Size(372, 87);
            this.dataGridViewCarrera.TabIndex = 21;
            this.dataGridViewCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrera_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxbusca_id_carrera);
            this.groupBox1.Location = new System.Drawing.Point(121, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 126);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CreditosGallegos.Properties.Resources.icons8_checkmark_48px;
            this.pictureBox2.Location = new System.Drawing.Point(105, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa id_carrera";
            // 
            // textBoxbusca_id_carrera
            // 
            this.textBoxbusca_id_carrera.Location = new System.Drawing.Point(25, 37);
            this.textBoxbusca_id_carrera.Name = "textBoxbusca_id_carrera";
            this.textBoxbusca_id_carrera.Size = new System.Drawing.Size(100, 20);
            this.textBoxbusca_id_carrera.TabIndex = 0;
            // 
            // ActualizaCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizaCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizaCarreras";
            this.Load += new System.EventHandler(this.ActualizaCarreras_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxid_name;
        private System.Windows.Forms.CheckBox checkBoxid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewCarrera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxbusca_id_carrera;
    }
}