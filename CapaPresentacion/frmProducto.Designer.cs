namespace CapaPresentacion
{
    partial class frmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.btnlimpiab = new FontAwesome.Sharp.IconButton();
            this.btnbusca = new FontAwesome.Sharp.IconButton();
            this.buscatxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbusca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportar = new FontAwesome.Sharp.IconButton();
            this.Borrabtn = new FontAwesome.Sharp.IconButton();
            this.lablelcategoria = new System.Windows.Forms.Label();
            this.limpiabtn = new FontAwesome.Sharp.IconButton();
            this.status = new System.Windows.Forms.Label();
            this.guardabtn = new FontAwesome.Sharp.IconButton();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.labeldescr = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.codi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtindice);
            this.panel4.Controls.Add(this.btnlimpiab);
            this.panel4.Controls.Add(this.btnbusca);
            this.panel4.Controls.Add(this.buscatxt);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.cbbusca);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.regid);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dgvdata);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1118, 639);
            this.panel4.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Indice";
            // 
            // txtindice
            // 
            this.txtindice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtindice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtindice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtindice.Location = new System.Drawing.Point(341, 372);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(40, 21);
            this.txtindice.TabIndex = 30;
            this.txtindice.Text = "-1";
            // 
            // btnlimpiab
            // 
            this.btnlimpiab.BackColor = System.Drawing.Color.White;
            this.btnlimpiab.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.btnlimpiab.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiab.IconColor = System.Drawing.Color.Black;
            this.btnlimpiab.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiab.IconSize = 25;
            this.btnlimpiab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiab.Location = new System.Drawing.Point(474, 16);
            this.btnlimpiab.Name = "btnlimpiab";
            this.btnlimpiab.Size = new System.Drawing.Size(48, 31);
            this.btnlimpiab.TabIndex = 29;
            this.btnlimpiab.Text = " ";
            this.btnlimpiab.UseVisualStyleBackColor = false;
            this.btnlimpiab.Click += new System.EventHandler(this.btnlimpiab_Click);
            // 
            // btnbusca
            // 
            this.btnbusca.BackColor = System.Drawing.Color.White;
            this.btnbusca.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.btnbusca.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbusca.IconColor = System.Drawing.Color.Black;
            this.btnbusca.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbusca.IconSize = 25;
            this.btnbusca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbusca.Location = new System.Drawing.Point(420, 14);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(48, 31);
            this.btnbusca.TabIndex = 28;
            this.btnbusca.Text = " ";
            this.btnbusca.UseVisualStyleBackColor = false;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // buscatxt
            // 
            this.buscatxt.AcceptsTab = true;
            this.buscatxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscatxt.Location = new System.Drawing.Point(245, 16);
            this.buscatxt.Multiline = true;
            this.buscatxt.Name = "buscatxt";
            this.buscatxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buscatxt.Size = new System.Drawing.Size(162, 27);
            this.buscatxt.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(906, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 29);
            this.panel5.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(-3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Listado de Producto";
            // 
            // cbbusca
            // 
            this.cbbusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbusca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbbusca.FormattingEnabled = true;
            this.cbbusca.Location = new System.Drawing.Point(99, 16);
            this.cbbusca.Name = "cbbusca";
            this.cbbusca.Size = new System.Drawing.Size(140, 26);
            this.cbbusca.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID Registro Actual";
            // 
            // regid
            // 
            this.regid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.regid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.regid.Location = new System.Drawing.Point(225, 372);
            this.regid.Name = "regid";
            this.regid.Size = new System.Drawing.Size(40, 21);
            this.regid.TabIndex = 25;
            this.regid.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Buscar";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Btnseleccionar,
            this.Id,
            this.codigo,
            this.nombre,
            this.Descripcion,
            this.Idcategoria,
            this.categoria,
            this.Stock,
            this.PrecioCompra,
            this.Precioventa,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(38, 62);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(1041, 290);
            this.dgvdata.TabIndex = 1;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // Btnseleccionar
            // 
            this.Btnseleccionar.FillWeight = 50F;
            this.Btnseleccionar.HeaderText = " ";
            this.Btnseleccionar.MinimumWidth = 6;
            this.Btnseleccionar.Name = "Btnseleccionar";
            this.Btnseleccionar.ReadOnly = true;
            this.Btnseleccionar.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id ";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 130;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre ";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Idcategoria
            // 
            this.Idcategoria.HeaderText = "Idcategoria";
            this.Idcategoria.MinimumWidth = 6;
            this.Idcategoria.Name = "Idcategoria";
            this.Idcategoria.ReadOnly = true;
            this.Idcategoria.Visible = false;
            this.Idcategoria.Width = 110;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // Precioventa
            // 
            this.Precioventa.HeaderText = "Precio venta";
            this.Precioventa.Name = "Precioventa";
            this.Precioventa.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 115;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 13);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.exportar);
            this.panel2.Controls.Add(this.Borrabtn);
            this.panel2.Controls.Add(this.lablelcategoria);
            this.panel2.Controls.Add(this.limpiabtn);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.guardabtn);
            this.panel2.Controls.Add(this.txtdescripcion);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.cbestado);
            this.panel2.Controls.Add(this.cbcategoria);
            this.panel2.Controls.Add(this.labeldescr);
            this.panel2.Controls.Add(this.labelname);
            this.panel2.Controls.Add(this.codi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 118);
            this.panel2.TabIndex = 4;
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.LightBlue;
            this.exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportar.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.exportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.exportar.IconColor = System.Drawing.Color.Black;
            this.exportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportar.Location = new System.Drawing.Point(0, 85);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(130, 27);
            this.exportar.TabIndex = 25;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // Borrabtn
            // 
            this.Borrabtn.BackColor = System.Drawing.Color.LightCoral;
            this.Borrabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.Borrabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Borrabtn.IconColor = System.Drawing.Color.Black;
            this.Borrabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Borrabtn.Location = new System.Drawing.Point(958, 85);
            this.Borrabtn.Name = "Borrabtn";
            this.Borrabtn.Size = new System.Drawing.Size(130, 27);
            this.Borrabtn.TabIndex = 24;
            this.Borrabtn.Text = "Borrar";
            this.Borrabtn.UseVisualStyleBackColor = false;
            this.Borrabtn.Click += new System.EventHandler(this.Borrabtn_Click);
            // 
            // lablelcategoria
            // 
            this.lablelcategoria.AutoSize = true;
            this.lablelcategoria.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablelcategoria.Location = new System.Drawing.Point(552, 14);
            this.lablelcategoria.Name = "lablelcategoria";
            this.lablelcategoria.Size = new System.Drawing.Size(79, 18);
            this.lablelcategoria.TabIndex = 21;
            this.lablelcategoria.Text = "Categoria";
            // 
            // limpiabtn
            // 
            this.limpiabtn.BackColor = System.Drawing.Color.LightBlue;
            this.limpiabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.limpiabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.limpiabtn.IconColor = System.Drawing.Color.Black;
            this.limpiabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiabtn.Location = new System.Drawing.Point(805, 85);
            this.limpiabtn.Name = "limpiabtn";
            this.limpiabtn.Size = new System.Drawing.Size(130, 27);
            this.limpiabtn.TabIndex = 23;
            this.limpiabtn.Text = "Limpiar";
            this.limpiabtn.UseVisualStyleBackColor = false;
            this.limpiabtn.Click += new System.EventHandler(this.limpiabtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(802, 18);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(63, 18);
            this.status.TabIndex = 20;
            this.status.Text = "Estatus";
            // 
            // guardabtn
            // 
            this.guardabtn.BackColor = System.Drawing.Color.LightGreen;
            this.guardabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.guardabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardabtn.IconColor = System.Drawing.Color.Black;
            this.guardabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardabtn.Location = new System.Drawing.Point(652, 85);
            this.guardabtn.Name = "guardabtn";
            this.guardabtn.Size = new System.Drawing.Size(130, 27);
            this.guardabtn.TabIndex = 22;
            this.guardabtn.Text = "Guardar";
            this.guardabtn.UseVisualStyleBackColor = false;
            this.guardabtn.Click += new System.EventHandler(this.guardabtn_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AcceptsTab = true;
            this.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdescripcion.Location = new System.Drawing.Point(369, 39);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdescripcion.Size = new System.Drawing.Size(174, 24);
            this.txtdescripcion.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Location = new System.Drawing.Point(170, 36);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.Size = new System.Drawing.Size(174, 24);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsTab = true;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Location = new System.Drawing.Point(12, 36);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.Size = new System.Drawing.Size(138, 24);
            this.txtCodigo.TabIndex = 7;
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Location = new System.Drawing.Point(818, 39);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(194, 26);
            this.cbestado.TabIndex = 6;
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(569, 39);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(213, 26);
            this.cbcategoria.TabIndex = 5;
            // 
            // labeldescr
            // 
            this.labeldescr.AutoSize = true;
            this.labeldescr.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.labeldescr.Location = new System.Drawing.Point(357, 14);
            this.labeldescr.Name = "labeldescr";
            this.labeldescr.Size = new System.Drawing.Size(93, 18);
            this.labeldescr.TabIndex = 2;
            this.labeldescr.Text = "Descripcion";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelname.Location = new System.Drawing.Point(167, 14);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(72, 18);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Nombre ";
            // 
            // codi
            // 
            this.codi.AutoSize = true;
            this.codi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codi.Location = new System.Drawing.Point(12, 14);
            this.codi.Name = "codi";
            this.codi.Size = new System.Drawing.Size(58, 18);
            this.codi.TabIndex = 0;
            this.codi.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 14);
            this.panel1.TabIndex = 5;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnlimpiab;
        private FontAwesome.Sharp.IconButton btnbusca;
        private System.Windows.Forms.TextBox buscatxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Borrabtn;
        private System.Windows.Forms.Label lablelcategoria;
        private FontAwesome.Sharp.IconButton limpiabtn;
        private System.Windows.Forms.Label status;
        private FontAwesome.Sharp.IconButton guardabtn;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Label labeldescr;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label codi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn Btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton exportar;
    }
}