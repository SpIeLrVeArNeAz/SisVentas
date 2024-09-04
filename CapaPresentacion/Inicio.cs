using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocia;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioactual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio( Usuario objusuario)
        {
            usuarioactual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermiso = new CN_Permiso().Listar(usuarioactual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items) {
            
                bool encontrado = ListaPermiso.Any( m => m.NombreMenu == iconMenu.Name);  
            
                if(encontrado== false)
                {
                    iconMenu.Visible = false;
                }
            }

            lbluser.Text = usuarioactual.NombreCompleto;
        
        }

        private void AbreForms(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbreForms((IconMenuItem)sender, new frmUsers()); 
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            AbreForms(menumantenimiento, new frmCategoria());
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            AbreForms(menumantenimiento, new frmProducto());
        }

        private void Registrar_v_Click(object sender, EventArgs e)
        {
            AbreForms(menuventas, new frmVentas());

        }
        private void Detalle_venta_Click(object sender, EventArgs e)
        {
            AbreForms(menuventas, new frmDetalleV ());
        }

        private void Registrar_c_Click(object sender, EventArgs e)
        {
            AbreForms(menucompras, new frmCompras());
        }

        private void Detalle_com_Click(object sender, EventArgs e)
        {
            AbreForms(menucompras, new frmDetalleC());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbreForms((IconMenuItem)sender, new frmClientes()); 
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbreForms((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbreForms((IconMenuItem)sender, new frmReportes());
        }

      
    }
}
