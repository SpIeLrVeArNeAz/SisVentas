using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocia;
namespace CapaPresentacion
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new Opcioncb() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new Opcioncb() { Valor = 0, Texto = "No Activo" });
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cbrol.Items.Add(new Opcioncb() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cbrol.DisplayMember = "Texto";
            cbrol.ValueMember = "Valor";
            cbrol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true && columna.Name != "Btnseleccionar")
                {
                    cbbusca.Items.Add(new Opcioncb() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbbusca.DisplayMember = "Texto";
            cbbusca.ValueMember = "Valor";
            cbbusca.SelectedIndex = 0;

            //Mostrar todos los usuarios

            List<Usuario> listaUsuario = new CN_usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dgvdata.Rows.Add(new object[] { "", item.IdUsuario,item.Documento, item.NombreCompleto, item.Correo, item.clave,
               item.oRol.IdRol,
               item.oRol.Descripcion,
               item.Estado ==true ? 1 : 0,
               item.Estado ==true ? "Activo" : "No Activo"

            });

            }

        }


        private void guardabtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(regid.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                clave = txtClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((Opcioncb)cbrol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((Opcioncb)cbestado.SelectedItem).Valor) == 1 ? true : false
            };

            if(objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "",idusuariogenerado,txtDocumento.Text,txtNombreCompleto.Text, txtCorr.Text, txtClave.Text,
               ((Opcioncb)cbrol.SelectedItem).Valor.ToString(),
               ((Opcioncb)cbrol.SelectedItem).Texto.ToString(),
               ((Opcioncb)cbestado.SelectedItem).Valor.ToString(),
               ((Opcioncb)cbestado.SelectedItem).Texto.ToString(),
            });
           
                Limpia(); 
                
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else {
                 bool resultado = new CN_usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = regid.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Correo"].Value = txtCorr.Text;
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["IdRol"].Value = ((Opcioncb)cbrol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((Opcioncb)cbrol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((Opcioncb)cbestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((Opcioncb)cbestado.SelectedItem).Texto.ToString();

                    Limpia(); 

                }

                else
                {
                    MessageBox.Show(mensaje);
                }

            }


        }

        private void Limpia()
        {
            txtindice.Text = "-1";
            regid.Text = "0";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorr.Text = "";
            txtClave.Text = "";
            txtConfirma.Text = "";
            cbrol.SelectedIndex = 0;
            cbestado.SelectedIndex = 0;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "Btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    regid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorr.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirma.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    string estado = dgvdata.Rows[indice].Cells["Estado"].Value.ToString();
                    foreach (Opcioncb oc in cbrol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indicecb = cbrol.Items.IndexOf(oc);
                            cbrol.SelectedIndex = indicecb;
                            break;
                        }
                        //foreach (Opcioncb co in cbestado.Items)
                        //{
                        //    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Estado"].Value))
                        //    {
                        //        int indicecb = cbestado.Items.IndexOf(co);
                        //        cbestado.SelectedIndex = indicecb;
                        //        break;
                        //    }
                        //}

                    }
                    if (estado.Equals("Activo"))
                    {
                        cbestado.SelectedIndex = 0;
                    }
                    else
                    {
                        cbestado.SelectedIndex = 1;
                    }
                }
            }
        }

        private void Borrabtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(regid.Text) != 0)
            {
                if(MessageBox.Show("Deseas eliminar el usuario?","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario() { 

                        IdUsuario = Convert.ToInt32(regid.Text)
                    };

                    bool respuesta = new CN_usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta) { 
                    
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpia();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((Opcioncb)cbbusca.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0) {

                foreach (DataGridViewRow row in dgvdata.Rows) {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(buscatxt.Text.Trim().ToUpper()))
                    row.Visible = true;
                    else
                    row.Visible = false;
                  
                }
            }
        }

        private void btnlimpiab_Click(object sender, EventArgs e)
        {
            buscatxt.Text = "";
            foreach(DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void limpiabtn_Click(object sender, EventArgs e)
        {
            Limpia();
        }
    }
}
