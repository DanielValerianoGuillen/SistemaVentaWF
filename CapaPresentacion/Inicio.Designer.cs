namespace CapaPresentacion
{
    partial class Inicio
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
            menutitulo = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            toolStripTextBox7 = new ToolStripTextBox();
            toolStripTextBox6 = new ToolStripTextBox();
            toolStripTextBox5 = new ToolStripTextBox();
            toolStripTextBox4 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            iblUsuario = new ToolStripTextBox();
            menu = new MenuStrip();
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            submenuProducto = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            menutitulo.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.SteelBlue;
            menutitulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            menutitulo.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox3, toolStripTextBox7, toolStripTextBox6, toolStripTextBox5, toolStripTextBox4, toolStripTextBox2, iblUsuario });
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.Size = new Size(1034, 49);
            menutitulo.TabIndex = 0;
            menutitulo.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.AutoSize = false;
            toolStripTextBox1.BackColor = Color.SteelBlue;
            toolStripTextBox1.BorderStyle = BorderStyle.None;
            toolStripTextBox1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox1.ForeColor = Color.White;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.RightToLeft = RightToLeft.No;
            toolStripTextBox1.Size = new Size(300, 31);
            toolStripTextBox1.Text = "Sistema De Ventas";
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.BackColor = Color.SteelBlue;
            toolStripTextBox3.BorderStyle = BorderStyle.None;
            toolStripTextBox3.Enabled = false;
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 45);
            // 
            // toolStripTextBox7
            // 
            toolStripTextBox7.BackColor = Color.SteelBlue;
            toolStripTextBox7.BorderStyle = BorderStyle.None;
            toolStripTextBox7.Enabled = false;
            toolStripTextBox7.Name = "toolStripTextBox7";
            toolStripTextBox7.Size = new Size(100, 45);
            // 
            // toolStripTextBox6
            // 
            toolStripTextBox6.BackColor = Color.SteelBlue;
            toolStripTextBox6.BorderStyle = BorderStyle.None;
            toolStripTextBox6.Enabled = false;
            toolStripTextBox6.Name = "toolStripTextBox6";
            toolStripTextBox6.Size = new Size(100, 45);
            // 
            // toolStripTextBox5
            // 
            toolStripTextBox5.BackColor = Color.SteelBlue;
            toolStripTextBox5.BorderStyle = BorderStyle.None;
            toolStripTextBox5.Enabled = false;
            toolStripTextBox5.Name = "toolStripTextBox5";
            toolStripTextBox5.Size = new Size(100, 45);
            // 
            // toolStripTextBox4
            // 
            toolStripTextBox4.BackColor = Color.SteelBlue;
            toolStripTextBox4.BorderStyle = BorderStyle.None;
            toolStripTextBox4.Enabled = false;
            toolStripTextBox4.Name = "toolStripTextBox4";
            toolStripTextBox4.Size = new Size(100, 45);
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.BackColor = Color.SteelBlue;
            toolStripTextBox2.BorderStyle = BorderStyle.None;
            toolStripTextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox2.ForeColor = Color.White;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new Size(100, 45);
            toolStripTextBox2.Text = "Usuario";
            // 
            // iblUsuario
            // 
            iblUsuario.BackColor = Color.SteelBlue;
            iblUsuario.BorderStyle = BorderStyle.None;
            iblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iblUsuario.ForeColor = Color.White;
            iblUsuario.Name = "iblUsuario";
            iblUsuario.ReadOnly = true;
            iblUsuario.RightToLeft = RightToLeft.No;
            iblUsuario.Size = new Size(100, 45);
            iblUsuario.Text = "iblUsuario";
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.Items.AddRange(new ToolStripItem[] { menuUsuarios, menuMantenedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercaDe });
            menu.Location = new Point(0, 49);
            menu.Name = "menu";
            menu.Size = new Size(1034, 73);
            menu.TabIndex = 1;
            menu.Text = "menuStrip2";
            // 
            // menuUsuarios
            // 
            menuUsuarios.AutoSize = false;
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuUsuarios.IconColor = Color.Black;
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.IconSize = 50;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(80, 69);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuMantenedor
            // 
            menuMantenedor.AutoSize = false;
            menuMantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenuCategoria, submenuProducto });
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menuMantenedor.IconColor = Color.Black;
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenedor.IconSize = 50;
            menuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menuMantenedor.Name = "menuMantenedor";
            menuMantenedor.Size = new Size(80, 69);
            menuMantenedor.Text = "Mantenedor";
            menuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuCategoria
            // 
            submenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuCategoria.IconColor = Color.Black;
            submenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuCategoria.Name = "submenuCategoria";
            submenuCategoria.Size = new Size(125, 22);
            submenuCategoria.Text = "Categoria";
            submenuCategoria.Click += submenuCategoria_Click;
            // 
            // submenuProducto
            // 
            submenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuProducto.IconColor = Color.Black;
            submenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuProducto.Name = "submenuProducto";
            submenuProducto.Size = new Size(125, 22);
            submenuProducto.Text = "Producto";
            submenuProducto.Click += submenuProducto_Click;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarVenta, subMenuVerDetalleVenta });
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 50;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(80, 69);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarVenta.IconColor = Color.Black;
            subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            subMenuRegistrarVenta.Size = new Size(129, 22);
            subMenuRegistrarVenta.Text = "Registrar";
            subMenuRegistrarVenta.Click += subMenuRegistrarVenta_Click;
            // 
            // subMenuVerDetalleVenta
            // 
            subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleVenta.IconColor = Color.Black;
            subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            subMenuVerDetalleVenta.Size = new Size(129, 22);
            subMenuVerDetalleVenta.Text = "Ver Detalle";
            subMenuVerDetalleVenta.Click += subMenuVerDetalleVenta_Click;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarCompra, subMenuVerDetalleCompra });
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(80, 69);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarCompra.IconColor = Color.Black;
            subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Size = new Size(129, 22);
            subMenuRegistrarCompra.Text = "Registrar";
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // subMenuVerDetalleCompra
            // 
            subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleCompra.IconColor = Color.Black;
            subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            subMenuVerDetalleCompra.Size = new Size(129, 22);
            subMenuVerDetalleCompra.Text = "Ver Detalle";
            subMenuVerDetalleCompra.Click += subMenuVerDetalleCompra_Click;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(80, 69);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 50;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(80, 69);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 50;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(80, 69);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuReportes.Click += menuReportes_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.AutoSize = false;
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.Black;
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.IconSize = 50;
            menuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(80, 69);
            menuAcercaDe.Text = "Acerca De";
            menuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.ForeColor = Color.Black;
            contenedor.Location = new Point(0, 122);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1034, 398);
            contenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 520);
            Controls.Add(contenedor);
            Controls.Add(menu);
            Controls.Add(menutitulo);
            ForeColor = Color.SteelBlue;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            menutitulo.ResumeLayout(false);
            menutitulo.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menutitulo;
        private MenuStrip menu;
        private ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private Panel contenedor;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox iblUsuario;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripTextBox toolStripTextBox4;
        private FontAwesome.Sharp.IconMenuItem submenuCategoria;
        private FontAwesome.Sharp.IconMenuItem submenuProducto;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleCompra;
        private ToolStripTextBox toolStripTextBox7;
        private ToolStripTextBox toolStripTextBox6;
        private ToolStripTextBox toolStripTextBox5;
    }
}