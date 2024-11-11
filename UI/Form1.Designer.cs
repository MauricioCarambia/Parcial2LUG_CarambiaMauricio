namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBorrador = new Button();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            dtpFecha = new DateTimePicker();
            txtNombre = new TextBox();
            cmbCurso = new ComboBox();
            label10 = new Label();
            txtPromedio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            groupBox2 = new GroupBox();
            cmbNuevoCurso = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtNuevoPromedio = new TextBox();
            txtNuevoNombre = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label11 = new Label();
            btnModificar = new Button();
            groupBox3 = new GroupBox();
            txtEliminarID = new TextBox();
            label9 = new Label();
            btnEliminar = new Button();
            dgvEstudiantes = new DataGridView();
            groupBox4 = new GroupBox();
            btnSalir = new Button();
            groupBox5 = new GroupBox();
            dgvCursos = new DataGridView();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(11, 241);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(147, 53);
            btnBorrador.TabIndex = 5;
            btnBorrador.Text = "Guardar Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbCurso);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPromedio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 313);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(91, 182);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 53);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar de uno";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(117, 66);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(189, 29);
            dtpFecha.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 29);
            txtNombre.TabIndex = 0;
            // 
            // cmbCurso
            // 
            cmbCurso.Font = new Font("Segoe UI", 12F);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(117, 147);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(189, 29);
            cmbCurso.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(11, 155);
            label10.Name = "label10";
            label10.Size = new Size(51, 21);
            label10.TabIndex = 10;
            label10.Text = "Curso";
            // 
            // txtPromedio
            // 
            txtPromedio.Font = new Font("Segoe UI", 12F);
            txtPromedio.Location = new Point(117, 106);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(131, 29);
            txtPromedio.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(11, 114);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 5;
            label4.Text = "Promedio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 66);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 4;
            label3.Text = "Fecha Nac.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(170, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Confirmar Borrador";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbNuevoCurso);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtNuevoPromedio);
            groupBox2.Controls.Add(txtNuevoNombre);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(12, 372);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 254);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar";
            // 
            // cmbNuevoCurso
            // 
            cmbNuevoCurso.Font = new Font("Segoe UI", 12F);
            cmbNuevoCurso.FormattingEnabled = true;
            cmbNuevoCurso.Location = new Point(128, 149);
            cmbNuevoCurso.Name = "cmbNuevoCurso";
            cmbNuevoCurso.Size = new Size(189, 29);
            cmbNuevoCurso.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 157);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 24;
            label6.Text = "Curso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(11, 28);
            label5.Name = "label5";
            label5.Size = new Size(25, 21);
            label5.TabIndex = 22;
            label5.Text = "ID";
            // 
            // txtNuevoPromedio
            // 
            txtNuevoPromedio.Font = new Font("Segoe UI", 12F);
            txtNuevoPromedio.Location = new Point(128, 109);
            txtNuevoPromedio.Name = "txtNuevoPromedio";
            txtNuevoPromedio.Size = new Size(131, 29);
            txtNuevoPromedio.TabIndex = 9;
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Font = new Font("Segoe UI", 12F);
            txtNuevoNombre.Location = new Point(128, 65);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(178, 29);
            txtNuevoNombre.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(128, 25);
            txtID.Name = "txtID";
            txtID.Size = new Size(78, 29);
            txtID.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(11, 112);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 20;
            label7.Text = "Promedio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(11, 68);
            label11.Name = "label11";
            label11.Size = new Size(68, 21);
            label11.TabIndex = 16;
            label11.Text = "Nombre";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(170, 184);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(147, 53);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEliminarID);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(360, 372);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 138);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar";
            // 
            // txtEliminarID
            // 
            txtEliminarID.Font = new Font("Segoe UI", 12F);
            txtEliminarID.Location = new Point(87, 28);
            txtEliminarID.Name = "txtEliminarID";
            txtEliminarID.Size = new Size(98, 29);
            txtEliminarID.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(11, 31);
            label9.Name = "label9";
            label9.Size = new Size(25, 21);
            label9.TabIndex = 17;
            label9.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(87, 63);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 53);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(6, 22);
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(921, 285);
            dgvEstudiantes.TabIndex = 4;
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged_1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvEstudiantes);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(354, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(933, 313);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Estudiantes";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(447, 556);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(147, 53);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvCursos);
            groupBox5.Font = new Font("Segoe UI", 12F);
            groupBox5.Location = new Point(622, 372);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(659, 254);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Cursos";
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(6, 22);
            dgvCursos.MultiSelect = false;
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new Size(647, 226);
            dgvCursos.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(103, 338);
            label2.Name = "label2";
            label2.Size = new Size(717, 21);
            label2.TabIndex = 15;
            label2.Text = "Puede seleccionar en el datagrid  para completar los campos automaticamente de modificar y eliminar\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 642);
            Controls.Add(label2);
            Controls.Add(groupBox5);
            Controls.Add(btnSalir);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudiantes Gestion";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrador;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtPromedio;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button btnModificar;
        private GroupBox groupBox3;
        private TextBox txtEliminarID;
        private Label label9;
        private Button btnEliminar;
        private ComboBox cmbCurso;
        private Label label10;
        private DataGridView dgvEstudiantes;
        private GroupBox groupBox4;
        private Label label5;
        private TextBox txtNuevoPromedio;
        private TextBox txtNuevoNombre;
        private TextBox txtID;
        private Label label7;
        private Label label8;
        private Label label11;
        private TextBox txtNombre;
        private Button btnSalir;
        private DateTimePicker dtpFecha;
        private Button btnAgregar;
        private ComboBox cmbNuevoCurso;
        private Label label6;
        private GroupBox groupBox5;
        private DataGridView dgvCursos;
    }
}
