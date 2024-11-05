namespace CapaPresentacion
{
    partial class frmCompras
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guardabtn = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalpaga = new System.Windows.Forms.TextBox();
            this.agregabtn = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbcant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.preve = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtnprod = new System.Windows.Forms.TextBox();
            this.buscaprodbtn = new FontAwesome.Sharp.IconButton();
            this.txtidprod = new System.Windows.Forms.TextBox();
            this.txtprd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidprov = new System.Windows.Forms.TextBox();
            this.txtnomprov = new System.Windows.Forms.TextBox();
            this.btnbusca = new FontAwesome.Sharp.IconButton();
            this.txtnrodoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtpdoc = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcant)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guardabtn);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txttotalpaga);
            this.panel2.Controls.Add(this.agregabtn);
            this.panel2.Controls.Add(this.dgvdata);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(3, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 510);
            this.panel2.TabIndex = 3;
            // 
            // guardabtn
            // 
            this.guardabtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.guardabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.guardabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardabtn.IconColor = System.Drawing.Color.Black;
            this.guardabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardabtn.Location = new System.Drawing.Point(839, 335);
            this.guardabtn.Name = "guardabtn";
            this.guardabtn.Size = new System.Drawing.Size(232, 27);
            this.guardabtn.TabIndex = 45;
            this.guardabtn.Text = "Guardar";
            this.guardabtn.UseVisualStyleBackColor = false;
            this.guardabtn.Click += new System.EventHandler(this.guardabtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(845, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Total paga";
            // 
            // txttotalpaga
            // 
            this.txttotalpaga.AcceptsTab = true;
            this.txttotalpaga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotalpaga.Location = new System.Drawing.Point(945, 302);
            this.txttotalpaga.Multiline = true;
            this.txttotalpaga.Name = "txttotalpaga";
            this.txttotalpaga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttotalpaga.Size = new System.Drawing.Size(126, 27);
            this.txttotalpaga.TabIndex = 43;
            this.txttotalpaga.Text = "0";
            // 
            // agregabtn
            // 
            this.agregabtn.BackColor = System.Drawing.Color.LightGreen;
            this.agregabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.agregabtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.agregabtn.IconColor = System.Drawing.Color.Black;
            this.agregabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregabtn.Location = new System.Drawing.Point(845, 108);
            this.agregabtn.Name = "agregabtn";
            this.agregabtn.Size = new System.Drawing.Size(226, 77);
            this.agregabtn.TabIndex = 31;
            this.agregabtn.Text = "Agregar";
            this.agregabtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregabtn.UseVisualStyleBackColor = false;
            this.agregabtn.Click += new System.EventHandler(this.agregabtn_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.IdProducto,
            this.dc_Producto,
            this.PrecioCompra,
            this.precioventa,
            this.cantidad,
            this.subtotal,
            this.btn});
            this.dgvdata.Location = new System.Drawing.Point(3, 108);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(830, 254);
            this.dgvdata.TabIndex = 30;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbcant);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.preve);
            this.groupBox3.Controls.Add(this.txtpreco);
            this.groupBox3.Controls.Add(this.txtnprod);
            this.groupBox3.Controls.Add(this.buscaprodbtn);
            this.groupBox3.Controls.Add(this.txtidprod);
            this.groupBox3.Controls.Add(this.txtprd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 99);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(624, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(498, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Precio venta";
            // 
            // cbcant
            // 
            this.cbcant.Location = new System.Drawing.Point(637, 50);
            this.cbcant.Name = "cbcant";
            this.cbcant.Size = new System.Drawing.Size(120, 26);
            this.cbcant.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(367, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Precio compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(239, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Producto";
            // 
            // preve
            // 
            this.preve.AcceptsTab = true;
            this.preve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.preve.Location = new System.Drawing.Point(517, 49);
            this.preve.Multiline = true;
            this.preve.Name = "preve";
            this.preve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.preve.Size = new System.Drawing.Size(95, 27);
            this.preve.TabIndex = 38;
            this.preve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preve_KeyPress);
            // 
            // txtpreco
            // 
            this.txtpreco.AcceptsTab = true;
            this.txtpreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpreco.Location = new System.Drawing.Point(404, 48);
            this.txtpreco.Multiline = true;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpreco.Size = new System.Drawing.Size(95, 27);
            this.txtpreco.TabIndex = 37;
            this.txtpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_KeyPress);
            // 
            // txtnprod
            // 
            this.txtnprod.AcceptsTab = true;
            this.txtnprod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnprod.Location = new System.Drawing.Point(242, 48);
            this.txtnprod.Multiline = true;
            this.txtnprod.Name = "txtnprod";
            this.txtnprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnprod.Size = new System.Drawing.Size(156, 24);
            this.txtnprod.TabIndex = 36;
            // 
            // buscaprodbtn
            // 
            this.buscaprodbtn.BackColor = System.Drawing.Color.White;
            this.buscaprodbtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.buscaprodbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buscaprodbtn.IconColor = System.Drawing.Color.Black;
            this.buscaprodbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buscaprodbtn.IconSize = 25;
            this.buscaprodbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscaprodbtn.Location = new System.Drawing.Point(193, 48);
            this.buscaprodbtn.Name = "buscaprodbtn";
            this.buscaprodbtn.Size = new System.Drawing.Size(43, 26);
            this.buscaprodbtn.TabIndex = 35;
            this.buscaprodbtn.Text = " ";
            this.buscaprodbtn.UseVisualStyleBackColor = false;
            this.buscaprodbtn.Click += new System.EventHandler(this.buscaprodbtn_Click_1);
            // 
            // txtidprod
            // 
            this.txtidprod.AcceptsTab = true;
            this.txtidprod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidprod.Location = new System.Drawing.Point(160, 22);
            this.txtidprod.Multiline = true;
            this.txtidprod.Name = "txtidprod";
            this.txtidprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtidprod.Size = new System.Drawing.Size(36, 23);
            this.txtidprod.TabIndex = 34;
            // 
            // txtprd
            // 
            this.txtprd.AcceptsTab = true;
            this.txtprd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprd.Location = new System.Drawing.Point(33, 48);
            this.txtprd.Multiline = true;
            this.txtprd.Name = "txtprd";
            this.txtprd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtprd.Size = new System.Drawing.Size(154, 24);
            this.txtprd.TabIndex = 33;
            this.txtprd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprd_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cod. prod";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidprov);
            this.groupBox2.Controls.Add(this.txtnomprov);
            this.groupBox2.Controls.Add(this.btnbusca);
            this.groupBox2.Controls.Add(this.txtnrodoc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(499, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 82);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // txtidprov
            // 
            this.txtidprov.AcceptsTab = true;
            this.txtidprov.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidprov.Location = new System.Drawing.Point(419, 14);
            this.txtidprov.Multiline = true;
            this.txtidprov.Name = "txtidprov";
            this.txtidprov.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtidprov.Size = new System.Drawing.Size(36, 23);
            this.txtidprov.TabIndex = 31;
             // 
            // txtnomprov
            // 
            this.txtnomprov.AcceptsTab = true;
            this.txtnomprov.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomprov.Location = new System.Drawing.Point(236, 43);
            this.txtnomprov.Multiline = true;
            this.txtnomprov.Name = "txtnomprov";
            this.txtnomprov.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnomprov.Size = new System.Drawing.Size(200, 24);
            this.txtnomprov.TabIndex = 30;
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
            this.btnbusca.Location = new System.Drawing.Point(178, 43);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(43, 26);
            this.btnbusca.TabIndex = 29;
            this.btnbusca.Text = " ";
            this.btnbusca.UseVisualStyleBackColor = false;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click_1);
            // 
            // txtnrodoc
            // 
            this.txtnrodoc.AcceptsTab = true;
            this.txtnrodoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnrodoc.Location = new System.Drawing.Point(25, 42);
            this.txtnrodoc.Multiline = true;
            this.txtnrodoc.Name = "txtnrodoc";
            this.txtnrodoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnrodoc.Size = new System.Drawing.Size(147, 24);
            this.txtnrodoc.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nro. Documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtpdoc);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 82);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de compra";
            // 
            // cbtpdoc
            // 
            this.cbtpdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtpdoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbtpdoc.FormattingEnabled = true;
            this.cbtpdoc.Location = new System.Drawing.Point(180, 43);
            this.cbtpdoc.Name = "cbtpdoc";
            this.cbtpdoc.Size = new System.Drawing.Size(218, 26);
            this.cbtpdoc.TabIndex = 20;
            // 
            // txtfecha
            // 
            this.txtfecha.AcceptsTab = true;
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfecha.Location = new System.Drawing.Point(15, 43);
            this.txtfecha.Multiline = true;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfecha.Size = new System.Drawing.Size(147, 24);
            this.txtfecha.TabIndex = 18;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.txtCorreo.Location = new System.Drawing.Point(166, 22);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(128, 18);
            this.txtCorreo.TabIndex = 17;
            this.txtCorreo.Text = "Tipo documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 11);
            this.panel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 135);
            this.panel3.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Registra Compra";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 13);
            this.panel4.TabIndex = 30;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Idproducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // dc_Producto
            // 
            this.dc_Producto.HeaderText = "Producto";
            this.dc_Producto.MinimumWidth = 6;
            this.dc_Producto.Name = "dc_Producto";
            this.dc_Producto.Width = 200;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 200;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "Precioventa";
            this.precioventa.Name = "precioventa";
            this.precioventa.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 200;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 125;
            // 
            // btn
            // 
            this.btn.HeaderText = "";
            this.btn.Name = "btn";
            this.btn.Width = 50;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 575);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcant)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtpdoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnrodoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidprov;
        private System.Windows.Forms.TextBox txtnomprov;
        private FontAwesome.Sharp.IconButton btnbusca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtidprod;
        private System.Windows.Forms.TextBox txtprd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox preve;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtnprod;
        private FontAwesome.Sharp.IconButton buscaprodbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cbcant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton agregabtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalpaga;
        private FontAwesome.Sharp.IconButton guardabtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
    }
}