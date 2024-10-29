using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocia;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancelarbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accederbtn_Click_1(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_usuario().Listar();

            Usuario oUsuario = new CN_usuario().Listar().Where(u => u.Documento == txtDoc.Text && u.clave == txtPass.Text).FirstOrDefault();

            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("User no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDoc.Text = "";
            txtPass.Text = "";
            this.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
