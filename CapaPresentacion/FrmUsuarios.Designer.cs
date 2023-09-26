namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDocumento = new TextBox();
            txtNombreCompleto = new TextBox();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtConfirmarClave = new TextBox();
            label7 = new Label();
            comboRol = new ComboBox();
            comboEstado = new ComboBox();
            label8 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            dgvDataUsuarios = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label10 = new Label();
            txtId = new TextBox();
            label11 = new Label();
            comboBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtIndice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDataUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 405);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(25, 37);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(25, 81);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(26, 125);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(25, 55);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(199, 23);
            txtDocumento.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(25, 99);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(199, 23);
            txtNombreCompleto.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(25, 143);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(199, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(25, 187);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(199, 23);
            txtClave.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(25, 169);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 7;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(25, 213);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 9;
            label6.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(25, 231);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.Size = new Size(199, 23);
            txtConfirmarClave.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(26, 257);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 11;
            label7.Text = "Rol:";
            // 
            // comboRol
            // 
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(25, 275);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(199, 23);
            comboRol.TabIndex = 12;
            // 
            // comboEstado
            // 
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(25, 319);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(199, 23);
            comboEstado.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(25, 301);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "Estado:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(25, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RoyalBlue;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 16;
            btnLimpiar.Location = new Point(106, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 16;
            btnEliminar.Location = new Point(187, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(25, 0);
            label9.Name = "label9";
            label9.Size = new Size(153, 28);
            label9.TabIndex = 18;
            label9.Text = "Detalle Usuarios";
            // 
            // dgvDataUsuarios
            // 
            dgvDataUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDataUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdUsuario, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvDataUsuarios.Location = new Point(278, 81);
            dgvDataUsuarios.MultiSelect = false;
            dgvDataUsuarios.Name = "dgvDataUsuarios";
            dgvDataUsuarios.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvDataUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDataUsuarios.RowTemplate.Height = 28;
            dgvDataUsuarios.Size = new Size(754, 312);
            dgvDataUsuarios.TabIndex = 19;
            dgvDataUsuarios.CellContentClick += dgvDataUsuarios_CellContentClick;
            dgvDataUsuarios.CellPainting += dgvDataUsuarios_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Contraseña";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(278, 14);
            label10.Name = "label10";
            label10.Size = new Size(754, 64);
            label10.TabIndex = 20;
            label10.Text = "Lista de usuarios";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Location = new Point(187, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 21;
            txtId.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(503, 37);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 22;
            label11.Text = "Buscar Por:";
            // 
            // comboBusqueda
            // 
            comboBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBusqueda.FormattingEnabled = true;
            comboBusqueda.Location = new Point(575, 34);
            comboBusqueda.Name = "comboBusqueda";
            comboBusqueda.Size = new Size(163, 23);
            comboBusqueda.TabIndex = 23;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(744, 34);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(155, 23);
            txtBusqueda.TabIndex = 24;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.White;
            btnLimpiarBuscador.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Popup;
            btnLimpiarBuscador.ForeColor = Color.White;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarBuscador.IconColor = Color.Black;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 18;
            btnLimpiarBuscador.Location = new Point(958, 34);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(47, 23);
            btnLimpiarBuscador.TabIndex = 26;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 18;
            btnBuscar.Location = new Point(905, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(47, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(144, 26);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(37, 23);
            txtIndice.TabIndex = 27;
            txtIndice.Text = "-1";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1039, 405);
            Controls.Add(txtIndice);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(comboBusqueda);
            Controls.Add(label11);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(dgvDataUsuarios);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(comboEstado);
            Controls.Add(comboRol);
            Controls.Add(label7);
            Controls.Add(txtConfirmarClave);
            Controls.Add(label6);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDocumento;
        private TextBox txtNombreCompleto;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label label5;
        private Label label6;
        private TextBox txtConfirmarClave;
        private Label label7;
        private ComboBox comboRol;
        private ComboBox comboEstado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label9;
        private DataGridView dgvDataUsuarios;
        private Label label10;
        private TextBox txtId;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Label label11;
        private ComboBox comboBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtIndice;
    }
}