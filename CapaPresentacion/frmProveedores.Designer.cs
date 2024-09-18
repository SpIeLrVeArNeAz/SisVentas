namespace CapaPresentacion
{
    partial class frmProveedores
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
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportar = new FontAwesome.Sharp.IconButton();
            this.Borrabtn = new FontAwesome.Sharp.IconButton();
            this.limpiabtn = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.guardabtn = new FontAwesome.Sharp.IconButton();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorr = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel6);
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
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1118, 592);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1118, 13);
            this.panel6.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(271, 349);
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
            this.txtindice.Location = new System.Drawing.Point(331, 349);
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
            this.btnlimpiab.Location = new System.Drawing.Point(505, 31);
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
            this.btnbusca.Location = new System.Drawing.Point(451, 29);
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
            this.buscatxt.Location = new System.Drawing.Point(276, 31);
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
            this.panel5.Location = new System.Drawing.Point(903, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 29);
            this.panel5.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Listado de Clientes";
            // 
            // cbbusca
            // 
            this.cbbusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbusca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbbusca.FormattingEnabled = true;
            this.cbbusca.Location = new System.Drawing.Point(130, 31);
            this.cbbusca.Name = "cbbusca";
            this.cbbusca.Size = new System.Drawing.Size(140, 26);
            this.cbbusca.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 349);
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
            this.regid.Location = new System.Drawing.Point(215, 349);
            this.regid.Name = "regid";
            this.regid.Size = new System.Drawing.Size(40, 21);
            this.regid.TabIndex = 25;
            this.regid.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(66, 34);
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
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(52, 69);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(980, 258);
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
            this.Id.HeaderText = "IdCliente";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nuro. Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.FillWeight = 150F;
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 200;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.exportar);
            this.panel2.Controls.Add(this.Borrabtn);
            this.panel2.Controls.Add(this.limpiabtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.guardabtn);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCorr);
            this.panel2.Controls.Add(this.txtRazonSocial);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.cbestado);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 118);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 11);
            this.panel1.TabIndex = 27;
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.LightBlue;
            this.exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportar.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.exportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.exportar.IconColor = System.Drawing.Color.Black;
            this.exportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportar.Location = new System.Drawing.Point(882, 33);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(130, 27);
            this.exportar.TabIndex = 26;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            // 
            // Borrabtn
            // 
            this.Borrabtn.BackColor = System.Drawing.Color.LightCoral;
            this.Borrabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.Borrabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Borrabtn.IconColor = System.Drawing.Color.Black;
            this.Borrabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Borrabtn.Location = new System.Drawing.Point(585, 82);
            this.Borrabtn.Name = "Borrabtn";
            this.Borrabtn.Size = new System.Drawing.Size(130, 27);
            this.Borrabtn.TabIndex = 24;
            this.Borrabtn.Text = "Borrar";
            this.Borrabtn.UseVisualStyleBackColor = false;
            this.Borrabtn.Click += new System.EventHandler(this.Borrabtn_Click);
            // 
            // limpiabtn
            // 
            this.limpiabtn.BackColor = System.Drawing.Color.LightBlue;
            this.limpiabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.limpiabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.limpiabtn.IconColor = System.Drawing.Color.Black;
            this.limpiabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiabtn.Location = new System.Drawing.Point(423, 82);
            this.limpiabtn.Name = "limpiabtn";
            this.limpiabtn.Size = new System.Drawing.Size(130, 27);
            this.limpiabtn.TabIndex = 23;
            this.limpiabtn.Text = "Limpiar";
            this.limpiabtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Estatus";
            // 
            // guardabtn
            // 
            this.guardabtn.BackColor = System.Drawing.Color.LightGreen;
            this.guardabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.guardabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardabtn.IconColor = System.Drawing.Color.Black;
            this.guardabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardabtn.Location = new System.Drawing.Point(251, 82);
            this.guardabtn.Name = "guardabtn";
            this.guardabtn.Size = new System.Drawing.Size(130, 27);
            this.guardabtn.TabIndex = 22;
            this.guardabtn.Text = "Guardar";
            this.guardabtn.UseVisualStyleBackColor = false;
            this.guardabtn.Click += new System.EventHandler(this.guardabtn_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AcceptsTab = true;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Location = new System.Drawing.Point(491, 36);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.Size = new System.Drawing.Size(124, 24);
            this.txtTelefono.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(471, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono";
            // 
            // txtCorr
            // 
            this.txtCorr.AcceptsTab = true;
            this.txtCorr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorr.Location = new System.Drawing.Point(321, 36);
            this.txtCorr.Multiline = true;
            this.txtCorr.Name = "txtCorr";
            this.txtCorr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorr.Size = new System.Drawing.Size(124, 24);
            this.txtCorr.TabIndex = 15;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AcceptsTab = true;
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazonSocial.Location = new System.Drawing.Point(170, 36);
            this.txtRazonSocial.Multiline = true;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRazonSocial.Size = new System.Drawing.Size(124, 24);
            this.txtRazonSocial.TabIndex = 14;
            // 
            // txtDocumento
            // 
            this.txtDocumento.AcceptsTab = true;
            this.txtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumento.Location = new System.Drawing.Point(12, 36);
            this.txtDocumento.Multiline = true;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocumento.Size = new System.Drawing.Size(138, 24);
            this.txtDocumento.TabIndex = 7;
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Location = new System.Drawing.Point(646, 36);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(170, 26);
            this.cbestado.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.txtCorreo.Location = new System.Drawing.Point(305, 14);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(57, 18);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(167, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "RazonSocial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Documento";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
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
        private System.Windows.Forms.Panel panel6;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton exportar;
        private FontAwesome.Sharp.IconButton Borrabtn;
        private FontAwesome.Sharp.IconButton limpiabtn;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton guardabtn;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorr;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}