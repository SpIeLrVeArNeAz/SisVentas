using CapaEntidad;
using CapaNegocia;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new Opcioncb() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new Opcioncb() { Valor = 0, Texto = "No Activo" });
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;

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


            List<Proveedores> listaProveedores = new CN_Proveedor().Listar();

            foreach (Proveedores item in listaProveedores)
            {

                dgvdata.Rows.Add(new object[] { "", item.IdProveedor,item.Documento, item.RazonSocial, item.Correo, item.Telefono,
               item.Estado ==true ? 1 : 0,
               item.Estado ==true ? "Activo" : "No Activo"

            });

            }
        }

        private void guardabtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedores obj  = new Proveedores()
            {
                IdProveedor = Convert.ToInt32(regid.Text),
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((Opcioncb)cbestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProveedor == 0)
            {
                int IdProveedor = new CN_Proveedor().Registrar(obj , out mensaje);

                if (IdProveedor != 0)
                {
                    dgvdata.Rows.Add(new object[] { "",IdProveedor,txtDocumento.Text,txtRazonSocial.Text, txtCorr.Text, txtTelefono.Text,
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
            else
            {
                bool resultado = new CN_Proveedor().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = regid.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["RazonSocial"].Value = txtRazonSocial.Text;
                    row.Cells["Correo"].Value = txtCorr.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
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
            txtRazonSocial.Text = "";
            txtCorr.Text = "";
            txtTelefono.Text = "";
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
                    txtRazonSocial.Text = dgvdata.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txtCorr.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
                    string estado = dgvdata.Rows[indice].Cells["Estado"].Value.ToString();
                    //foreach (Opcioncb oc in cbestado.Items)
                    //{
                    //    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Estado"].Value))
                    //    {
                    //        int indicecb = cbestado.Items.IndexOf(oc);
                    //        cbestado.SelectedIndex = indicecb;
                    //        break;
                    //    }
                    // }
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
            if (Convert.ToInt32(regid.Text) != 0)
            {
                if (MessageBox.Show("Deseas eliminar el Proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedores obj  = new Proveedores()
                    {

                        IdProveedor = Convert.ToInt32(regid.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(obj , out mensaje);

                    if (respuesta)
                    {

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

            if (dgvdata.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dgvdata.Rows)
                {

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
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
