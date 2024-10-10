namespace CapaPresentacion.Modales
{
    partial class mdProveedor
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
            this.cbbusca = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buscatxt = new System.Windows.Forms.TextBox();
            this.btnbusca = new FontAwesome.Sharp.IconButton();
            this.btnlimpiab = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
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
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
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
            this.btnlimpiab.Click += new System.EventHandler(this.btnlimpiab_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Listado de Proveedores";
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
            this.panel2.TabIndex = 31;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
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
            this.Id,
            this.Documento,
            this.RazonSocial});
            this.dgvdata.Location = new System.Drawing.Point(17, 109);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(605, 258);
            this.dgvdata.TabIndex = 37;
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 11);
            this.panel1.TabIndex = 27;
            // 
            // mdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 382);
            this.Controls.Add(this.panel2);
            this.Name = "mdProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProveedor";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbusca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox buscatxt;
        private FontAwesome.Sharp.IconButton btnbusca;
        private FontAwesome.Sharp.IconButton btnlimpiab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
    }
}