using CapaEntidad;
using CapaNegocia;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras( Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

 
        //video 14, arreglando dise;o

        private void frmCompras_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_Usuario.NombreCompleto);


            cbtpdoc.Items.Add(new Opcioncb() { Valor =  "Boleta", Texto = "Boleta" });
            cbtpdoc.Items.Add(new Opcioncb() { Valor = "Factura", Texto = "Factura"});
            cbtpdoc.DisplayMember = "Texto";
            cbtpdoc.ValueMember = "Valor";
            cbtpdoc.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
           
            txtidprov.Text = "0";
            txtidprod.Text = "0";

        }


        private void btnbusca_Click_1(object sender, EventArgs e) //buscaprovedoor
        {
            using(var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txtidprod.Text = modal.__Proveedor.IdProveedor.ToString();
                    txtnrodoc.Text = modal.__Proveedor.Documento;
                    txtnomprov.Text = modal.__Proveedor.RazonSocial;

                } else {
                    txtnrodoc.Select();
                }

            }
        }

        private void buscaprodbtn_Click_1(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidprod.Text = modal._producto.IdProducto.ToString();
                    txtprd.Text = modal._producto.Codigo;
                    txtnprod.Text = modal._producto.Nombre;

                    txtpreco. Select();
 
                }
                else
                {
                    txtprd.Select();
                }
            }
    }

        //VIdeo 15, cambiar esta parte 27:27

        private void txtprd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                Producto oProducto = new CN_Productos().Listar().Where(p => p.Codigo ==  txtprd.Text && p.Estado ==  true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtprd.BackColor = Color.Honeydew;
                    txtidprod.Text = oProducto.IdProducto.ToString();
                    txtnprod.Text = oProducto.Nombre;
                    txtpreco.Select();
                }
                else {
                    txtprd.BackColor = Color.MistyRose;
                    txtidprod.Text = "0";
                    txtnprod.Text = " ";

                    MessageBox.Show("Debe ingresar un producto existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void agregabtn_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existente = false;

            if (int.Parse(txtidprod.Text)==0)
            {
                MessageBox.Show("Debe ingresar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            if (!decimal.TryParse(txtpreco.Text, out preciocompra))
            {
                MessageBox.Show("Precio compra - Formato Moneda Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreco.Select();
                return;
            }

            if (!decimal.TryParse(preve.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato Moneda Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                preve.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["Id"].Value.ToString() == txtidprod.Text)
                {
                    producto_existente = true;
                    break;
                }
            }

            if (!producto_existente) {

                dgvdata.Rows.Add(new object[] {

               txtidprod.Text,
                txtnprod.Text,
                txtpreco.Text,
                preve.Text,
                cbcant.Value.ToString(),
                (cbcant.Value * preciocompra).ToString("0.00")

            });
                Calcula();
                limpiapro();
                txtprd.Select();
            }
        }
        private void limpiapro()
        {
            txtidprod.Text = "0";
            txtprd.Text = "";
            txtprd.BackColor = Color.White;
            txtnprod.Text = "";
            txtpreco.Text = "";
            preve.Text = "";
            cbcant.Value = 1;
        }

        private void Calcula()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count>0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());                
            }
            txttotalpaga.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.trash.Width;
                var h = Properties.Resources.trash.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            }
    }
}
