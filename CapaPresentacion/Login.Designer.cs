﻿namespace CapaPresentacion
{
    partial class Login
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.accederbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 362);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.txtPass);
            this.panel5.Controls.Add(this.txtDoc);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.accederbtn);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.cancelarbtn);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(268, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 284);
            this.panel5.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPass.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtPass.Location = new System.Drawing.Point(216, 117);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(153, 28);
            this.txtPass.TabIndex = 41;
            // 
            // txtDoc
            // 
            this.txtDoc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtDoc.Location = new System.Drawing.Point(216, 78);
            this.txtDoc.Multiline = true;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(152, 30);
            this.txtDoc.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(108, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 30);
            this.label10.TabIndex = 37;
            this.label10.Text = "Documento:";
            // 
            // accederbtn
            // 
            this.accederbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.accederbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accederbtn.Location = new System.Drawing.Point(112, 165);
            this.accederbtn.Name = "accederbtn";
            this.accederbtn.Size = new System.Drawing.Size(110, 40);
            this.accederbtn.TabIndex = 38;
            this.accederbtn.Text = "Proceder";
            this.accederbtn.UseVisualStyleBackColor = false;
            this.accederbtn.Click += new System.EventHandler(this.accederbtn_Click_1);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(107, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 28);
            this.label11.TabIndex = 36;
            this.label11.Text = "Clave:";
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.BackColor = System.Drawing.Color.MintCream;
            this.cancelarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarbtn.Location = new System.Drawing.Point(259, 165);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(110, 40);
            this.cancelarbtn.TabIndex = 39;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = false;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(-5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "INICIO SESION";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 363);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 362);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button accederbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}