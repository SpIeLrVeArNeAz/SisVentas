namespace CapaPresentacion
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.Categoria = new FontAwesome.Sharp.IconMenuItem();
            this.Producto = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.Registrar_v = new FontAwesome.Sharp.IconMenuItem();
            this.Detalle_venta = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.Registrar_c = new FontAwesome.Sharp.IconMenuItem();
            this.Detalle_com = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.usuarioac = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menumantenimiento,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 46);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(1119, 77);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.menuusuarios.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuusuarios.IconSize = 40;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(80, 75);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuusuarios.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menumantenimiento
            // 
            this.menumantenimiento.AutoSize = false;
            this.menumantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Categoria,
            this.Producto});
            this.menumantenimiento.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menumantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menumantenimiento.IconColor = System.Drawing.Color.Black;
            this.menumantenimiento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menumantenimiento.IconSize = 40;
            this.menumantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenimiento.Name = "menumantenimiento";
            this.menumantenimiento.Size = new System.Drawing.Size(122, 75);
            this.menumantenimiento.Text = "Mantenimiento";
            this.menumantenimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menumantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Categoria
            // 
            this.Categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Categoria.IconColor = System.Drawing.Color.Black;
            this.Categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(136, 24);
            this.Categoria.Text = "Categoria";
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // Producto
            // 
            this.Producto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Producto.IconColor = System.Drawing.Color.Black;
            this.Producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(136, 24);
            this.Producto.Text = "Producto";
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Registrar_v,
            this.Detalle_venta});
            this.menuventas.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 40;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 75);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Registrar_v
            // 
            this.Registrar_v.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Registrar_v.IconColor = System.Drawing.Color.Black;
            this.Registrar_v.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Registrar_v.Name = "Registrar_v";
            this.Registrar_v.Size = new System.Drawing.Size(157, 24);
            this.Registrar_v.Text = "Registrar";
            this.Registrar_v.Click += new System.EventHandler(this.Registrar_v_Click);
            // 
            // Detalle_venta
            // 
            this.Detalle_venta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Detalle_venta.IconColor = System.Drawing.Color.Black;
            this.Detalle_venta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Detalle_venta.Name = "Detalle_venta";
            this.Detalle_venta.Size = new System.Drawing.Size(157, 24);
            this.Detalle_venta.Text = "Detalle Venta";
            this.Detalle_venta.Click += new System.EventHandler(this.Detalle_venta_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Registrar_c,
            this.Detalle_com});
            this.menucompras.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menucompras.IconSize = 40;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(80, 75);
            this.menucompras.Text = "Compras";
            this.menucompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Registrar_c
            // 
            this.Registrar_c.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Registrar_c.IconColor = System.Drawing.Color.Black;
            this.Registrar_c.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Registrar_c.Name = "Registrar_c";
            this.Registrar_c.Size = new System.Drawing.Size(169, 24);
            this.Registrar_c.Text = "Registrar";
            this.Registrar_c.Click += new System.EventHandler(this.Registrar_c_Click);
            // 
            // Detalle_com
            // 
            this.Detalle_com.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Detalle_com.IconColor = System.Drawing.Color.Black;
            this.Detalle_com.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Detalle_com.Name = "Detalle_com";
            this.Detalle_com.Size = new System.Drawing.Size(169, 24);
            this.Detalle_com.Text = "Detalle compra";
            this.Detalle_com.Click += new System.EventHandler(this.Detalle_com_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuclientes.IconSize = 40;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(80, 75);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuproveedores.IconSize = 40;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(80, 75);
            this.menuproveedores.Text = "Provedoores";
            this.menuproveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menureportes.IconSize = 40;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(80, 75);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.5F, System.Drawing.FontStyle.Italic);
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuacercade.IconSize = 40;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 75);
            this.menuacercade.Text = "acerca de";
            this.menuacercade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1119, 46);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 123);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1119, 582);
            this.contenedor.TabIndex = 3;
            // 
            // usuarioac
            // 
            this.usuarioac.AutoSize = true;
            this.usuarioac.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.usuarioac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Italic);
            this.usuarioac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuarioac.Location = new System.Drawing.Point(763, 18);
            this.usuarioac.Name = "usuarioac";
            this.usuarioac.Size = new System.Drawing.Size(124, 20);
            this.usuarioac.TabIndex = 4;
            this.usuarioac.Text = "Usuario Actual:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Italic);
            this.lbluser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbluser.Location = new System.Drawing.Point(893, 18);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(104, 17);
            this.lbluser.TabIndex = 5;
            this.lbluser.Text = "Usuario Actual:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 705);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.usuarioac);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menumantenimiento;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem Categoria;
        private FontAwesome.Sharp.IconMenuItem Producto;
        private FontAwesome.Sharp.IconMenuItem Registrar_v;
        private FontAwesome.Sharp.IconMenuItem Detalle_venta;
        private FontAwesome.Sharp.IconMenuItem Registrar_c;
        private FontAwesome.Sharp.IconMenuItem Detalle_com;
        private System.Windows.Forms.Label usuarioac;
        private System.Windows.Forms.Label lbluser;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
    }
}

