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
            txtTitulo = new TextBox();
            cmbCategoria = new ComboBox();
            label10 = new Label();
            txtPrecio = new TextBox();
            txtDesarrolladora = new TextBox();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            groupBox2 = new GroupBox();
            txtNuevoPrecio = new TextBox();
            label5 = new Label();
            txtNuevoDesarrolladora = new TextBox();
            txtNuevoDescripcion = new TextBox();
            txtNuevoTitulo = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            btnModificar = new Button();
            groupBox3 = new GroupBox();
            txtEliminarID = new TextBox();
            label9 = new Label();
            btnEliminar = new Button();
            dgvAplicaciones = new DataGridView();
            groupBox4 = new GroupBox();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAplicaciones).BeginInit();
            groupBox4.SuspendLayout();
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
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDesarrolladora);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(128, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(131, 29);
            txtTitulo.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(128, 195);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(189, 29);
            cmbCategoria.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(11, 201);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 10;
            label10.Text = "Categoria";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(128, 154);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(131, 29);
            txtPrecio.TabIndex = 3;
            // 
            // txtDesarrolladora
            // 
            txtDesarrolladora.Font = new Font("Segoe UI", 12F);
            txtDesarrolladora.Location = new Point(128, 106);
            txtDesarrolladora.Name = "txtDesarrolladora";
            txtDesarrolladora.Size = new Size(131, 29);
            txtDesarrolladora.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(128, 62);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(189, 29);
            txtDescripcion.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(11, 160);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 4;
            label3.Text = "Desarrolladora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 2;
            label1.Text = "Titulo";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(170, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Confirmar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNuevoPrecio);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtNuevoDesarrolladora);
            groupBox2.Controls.Add(txtNuevoDescripcion);
            groupBox2.Controls.Add(txtNuevoTitulo);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(12, 364);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 236);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar";
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Font = new Font("Segoe UI", 12F);
            txtNuevoPrecio.Location = new Point(128, 201);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.Size = new Size(131, 29);
            txtNuevoPrecio.TabIndex = 23;
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
            // txtNuevoDesarrolladora
            // 
            txtNuevoDesarrolladora.Font = new Font("Segoe UI", 12F);
            txtNuevoDesarrolladora.Location = new Point(128, 157);
            txtNuevoDesarrolladora.Name = "txtNuevoDesarrolladora";
            txtNuevoDesarrolladora.Size = new Size(131, 29);
            txtNuevoDesarrolladora.TabIndex = 17;
            // 
            // txtNuevoDescripcion
            // 
            txtNuevoDescripcion.Font = new Font("Segoe UI", 12F);
            txtNuevoDescripcion.Location = new Point(128, 109);
            txtNuevoDescripcion.Name = "txtNuevoDescripcion";
            txtNuevoDescripcion.Size = new Size(337, 29);
            txtNuevoDescripcion.TabIndex = 15;
            // 
            // txtNuevoTitulo
            // 
            txtNuevoTitulo.Font = new Font("Segoe UI", 12F);
            txtNuevoTitulo.Location = new Point(128, 65);
            txtNuevoTitulo.Name = "txtNuevoTitulo";
            txtNuevoTitulo.Size = new Size(131, 29);
            txtNuevoTitulo.TabIndex = 14;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(128, 25);
            txtID.Name = "txtID";
            txtID.Size = new Size(78, 29);
            txtID.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 204);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 21;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(11, 160);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 20;
            label7.Text = "Desarrolladora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(11, 112);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 18;
            label8.Text = "Descripcion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(11, 68);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 16;
            label11.Text = "Titulo";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(318, 177);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(147, 53);
            btnModificar.TabIndex = 12;
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
            groupBox3.Location = new Point(489, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 133);
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
            txtEliminarID.TabIndex = 13;
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
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvAplicaciones
            // 
            dgvAplicaciones.AllowUserToAddRows = false;
            dgvAplicaciones.AllowUserToDeleteRows = false;
            dgvAplicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAplicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAplicaciones.Location = new Point(6, 22);
            dgvAplicaciones.MultiSelect = false;
            dgvAplicaciones.Name = "dgvAplicaciones";
            dgvAplicaciones.ReadOnly = true;
            dgvAplicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAplicaciones.Size = new Size(921, 316);
            dgvAplicaciones.TabIndex = 4;
            dgvAplicaciones.SelectionChanged += dgvAplicaciones_SelectionChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvAplicaciones);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(354, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(933, 344);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aplicaciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(576, 541);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(147, 53);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 611);
            Controls.Add(btnSalir);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAIStore";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAplicaciones).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrador;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtPrecio;
        private TextBox txtDesarrolladora;
        private TextBox txtDescripcion;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button btnModificar;
        private GroupBox groupBox3;
        private TextBox txtEliminarID;
        private Label label9;
        private Button btnEliminar;
        private ComboBox cmbCategoria;
        private Label label10;
        private DataGridView dgvAplicaciones;
        private GroupBox groupBox4;
        private TextBox txtNuevoPrecio;
        private Label label5;
        private TextBox txtNuevoDesarrolladora;
        private TextBox txtNuevoDescripcion;
        private TextBox txtNuevoTitulo;
        private TextBox txtID;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private TextBox txtTitulo;
        private Button btnSalir;
    }
}
