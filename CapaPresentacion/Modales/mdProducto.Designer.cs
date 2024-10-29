namespace CapaPresentacion.Modales
{
    partial class mdProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlimpiab = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbusca = new FontAwesome.Sharp.IconButton();
            this.buscatxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbusca = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciovent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvdata);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnlimpiab);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnbusca);
            this.panel2.Controls.Add(this.buscatxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbbusca);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 382);
            this.panel2.TabIndex = 32;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.cate,
            this.Stock,
            this.preciocom,
            this.preciovent});
            this.dgvdata.Location = new System.Drawing.Point(17, 122);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(548, 248);
            this.dgvdata.TabIndex = 38;
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Listado de Producto";
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
            this.btnlimpiab.Location = new System.Drawing.Point(526, 72);
            this.btnlimpiab.Name = "btnlimpiab";
            this.btnlimpiab.Size = new System.Drawing.Size(48, 31);
            this.btnlimpiab.TabIndex = 36;
            this.btnlimpiab.Text = " ";
            this.btnlimpiab.UseVisualStyleBackColor = false;
            this.btnlimpiab.Click += new System.EventHandler(this.btnlimpiab_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 11);
            this.panel1.TabIndex = 27;
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
            this.btnbusca.Location = new System.Drawing.Point(472, 72);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(48, 31);
            this.btnbusca.TabIndex = 35;
            this.btnbusca.Text = " ";
            this.btnbusca.UseVisualStyleBackColor = false;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click_1);
            // 
            // buscatxt
            // 
            this.buscatxt.AcceptsTab = true;
            this.buscatxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscatxt.Location = new System.Drawing.Point(287, 74);
            this.buscatxt.Multiline = true;
            this.buscatxt.Name = "buscatxt";
            this.buscatxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buscatxt.Size = new System.Drawing.Size(162, 27);
            this.buscatxt.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(33, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Buscar Por";
            // 
            // cbbusca
            // 
            this.cbbusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbusca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbbusca.FormattingEnabled = true;
            this.cbbusca.Location = new System.Drawing.Point(126, 74);
            this.cbbusca.Name = "cbbusca";
            this.cbbusca.Size = new System.Drawing.Size(145, 26);
            this.cbbusca.TabIndex = 33;
            // 
            // id
            // 
            this.id.HeaderText = "Id ";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
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
            // cate
            // 
            this.cate.HeaderText = "Categoria";
            this.cate.Name = "cate";
            this.cate.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // preciocom
            // 
            this.preciocom.HeaderText = "Precio compra";
            this.preciocom.Name = "preciocom";
            this.preciocom.ReadOnly = true;
            this.preciocom.Visible = false;
            // 
            // preciovent
            // 
            this.preciovent.HeaderText = "Precio venta";
            this.preciovent.Name = "preciovent";
            this.preciovent.ReadOnly = true;
            this.preciovent.Visible = false;
            // 
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 382);
            this.Controls.Add(this.panel2);
            this.Name = "mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.mdProducto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnlimpiab;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnbusca;
        private System.Windows.Forms.TextBox buscatxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbusca;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocom;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciovent;
    }
}