
namespace CreditosGallegos.ArEq
{
    partial class SelectArmEq
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEquipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSidAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonCbuscar = new System.Windows.Forms.Button();
            this.dataGridViewCargaAlumno = new System.Windows.Forms.DataGridView();
            this.btncbuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar Equipo por id o por nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.buttonCbuscar);
            this.panel1.Controls.Add(this.dataGridViewCargaAlumno);
            this.panel1.Controls.Add(this.btncbuscar);
            this.panel1.Location = new System.Drawing.Point(80, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 445);
            this.panel1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxEquipo);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(300, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 66);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Equipo";
            // 
            // comboBoxEquipo
            // 
            this.comboBoxEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEquipo.FormattingEnabled = true;
            this.comboBoxEquipo.Location = new System.Drawing.Point(26, 33);
            this.comboBoxEquipo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBoxEquipo.Name = "comboBoxEquipo";
            this.comboBoxEquipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipo.TabIndex = 4;
            this.comboBoxEquipo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEquipo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSidAlumno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(37, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 56);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // textBoxSidAlumno
            // 
            this.textBoxSidAlumno.BackColor = System.Drawing.Color.White;
            this.textBoxSidAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSidAlumno.Location = new System.Drawing.Point(14, 26);
            this.textBoxSidAlumno.Name = "textBoxSidAlumno";
            this.textBoxSidAlumno.Size = new System.Drawing.Size(100, 13);
            this.textBoxSidAlumno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id_Alumno";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(375, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Nombre";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Id Alumno";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // buttonCbuscar
            // 
            this.buttonCbuscar.Location = new System.Drawing.Point(404, 366);
            this.buttonCbuscar.Name = "buttonCbuscar";
            this.buttonCbuscar.Size = new System.Drawing.Size(141, 23);
            this.buttonCbuscar.TabIndex = 6;
            this.buttonCbuscar.Text = "Buscar Todos";
            this.buttonCbuscar.UseVisualStyleBackColor = true;
            this.buttonCbuscar.Click += new System.EventHandler(this.ButtonCbuscar_Click);
            // 
            // dataGridViewCargaAlumno
            // 
            this.dataGridViewCargaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargaAlumno.Location = new System.Drawing.Point(20, 178);
            this.dataGridViewCargaAlumno.Name = "dataGridViewCargaAlumno";
            this.dataGridViewCargaAlumno.Size = new System.Drawing.Size(545, 150);
            this.dataGridViewCargaAlumno.TabIndex = 7;
            this.dataGridViewCargaAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCargaAlumno_CellContentClick);
            // 
            // btncbuscar
            // 
            this.btncbuscar.Location = new System.Drawing.Point(78, 366);
            this.btncbuscar.Name = "btncbuscar";
            this.btncbuscar.Size = new System.Drawing.Size(75, 23);
            this.btncbuscar.TabIndex = 5;
            this.btncbuscar.Text = "Buscar";
            this.btncbuscar.UseVisualStyleBackColor = true;
            this.btncbuscar.Click += new System.EventHandler(this.Btncbuscar_Click);
            // 
            // SelectArmEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "SelectArmEq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectArmEq";
            this.Load += new System.EventHandler(this.SelectArmEq_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargaAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSidAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonCbuscar;
        private System.Windows.Forms.DataGridView dataGridViewCargaAlumno;
        private System.Windows.Forms.Button btncbuscar;
    }
}