﻿namespace CapaPresentacion
{
    partial class FrmNegocio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardabtn = new FontAwesome.Sharp.IconButton();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.ruc = new System.Windows.Forms.Label();
            this.txtNombreNego = new System.Windows.Forms.Label();
            this.uploadbtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picklogo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picklogo)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 14);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 563);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.guardabtn);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.ruc);
            this.groupBox1.Controls.Add(this.txtNombreNego);
            this.groupBox1.Controls.Add(this.uploadbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picklogo);
            this.groupBox1.Location = new System.Drawing.Point(207, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // guardabtn
            // 
            this.guardabtn.BackColor = System.Drawing.Color.LightGreen;
            this.guardabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardabtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.guardabtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardabtn.IconColor = System.Drawing.Color.Black;
            this.guardabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardabtn.Location = new System.Drawing.Point(353, 299);
            this.guardabtn.Name = "guardabtn";
            this.guardabtn.Size = new System.Drawing.Size(265, 27);
            this.guardabtn.TabIndex = 34;
            this.guardabtn.Text = "Guardar";
            this.guardabtn.UseVisualStyleBackColor = false;
            this.guardabtn.Click += new System.EventHandler(this.guardabtn_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.AcceptsTab = true;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.Location = new System.Drawing.Point(353, 250);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdireccion.Size = new System.Drawing.Size(265, 24);
            this.txtdireccion.TabIndex = 33;
            // 
            // txtruc
            // 
            this.txtruc.AcceptsTab = true;
            this.txtruc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtruc.Location = new System.Drawing.Point(353, 175);
            this.txtruc.Multiline = true;
            this.txtruc.Name = "txtruc";
            this.txtruc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtruc.Size = new System.Drawing.Size(265, 28);
            this.txtruc.TabIndex = 32;
            // 
            // txtnombre
            // 
            this.txtnombre.AcceptsTab = true;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Location = new System.Drawing.Point(353, 90);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnombre.Size = new System.Drawing.Size(265, 29);
            this.txtnombre.TabIndex = 31;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.txtCorreo.Location = new System.Drawing.Point(337, 220);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(76, 18);
            this.txtCorreo.TabIndex = 30;
            this.txtCorreo.Text = "Direccion";
            // 
            // ruc
            // 
            this.ruc.AutoSize = true;
            this.ruc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.ruc.Location = new System.Drawing.Point(337, 140);
            this.ruc.Name = "ruc";
            this.ruc.Size = new System.Drawing.Size(49, 18);
            this.ruc.TabIndex = 29;
            this.ruc.Text = "R.U.C";
            // 
            // txtNombreNego
            // 
            this.txtNombreNego.AutoSize = true;
            this.txtNombreNego.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNego.Location = new System.Drawing.Point(337, 69);
            this.txtNombreNego.Name = "txtNombreNego";
            this.txtNombreNego.Size = new System.Drawing.Size(131, 18);
            this.txtNombreNego.TabIndex = 28;
            this.txtNombreNego.Text = "Nombre Negocio";
            // 
            // uploadbtn
            // 
            this.uploadbtn.BackColor = System.Drawing.Color.LightBlue;
            this.uploadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadbtn.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Italic);
            this.uploadbtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.uploadbtn.IconColor = System.Drawing.Color.Black;
            this.uploadbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.uploadbtn.IconSize = 30;
            this.uploadbtn.Location = new System.Drawing.Point(53, 299);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(247, 27);
            this.uploadbtn.TabIndex = 27;
            this.uploadbtn.Text = " ";
            this.uploadbtn.UseVisualStyleBackColor = false;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Logo";
            // 
            // picklogo
            // 
            this.picklogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picklogo.Location = new System.Drawing.Point(53, 69);
            this.picklogo.Name = "picklogo";
            this.picklogo.Size = new System.Drawing.Size(247, 224);
            this.picklogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picklogo.TabIndex = 0;
            this.picklogo.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(906, 507);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 29);
            this.panel5.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Listado de Negocios";
            // 
            // FrmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 548);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNegocio";
            this.Text = "FrmNegocio";
            this.Load += new System.EventHandler(this.FrmNegocio_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picklogo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picklogo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton uploadbtn;
        private FontAwesome.Sharp.IconButton guardabtn;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label ruc;
        private System.Windows.Forms.Label txtNombreNego;
    }
}