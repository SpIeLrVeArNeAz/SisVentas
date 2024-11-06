using CapaEntidad;
using CapaNegocia;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            var dt = dgvdata;
            InitializeComponent();
        }

        //hay una exepcion aquis Curso de Sistema de Ventas en C# y SQL Server - Parte 16/ 39:29

        private void frmCompras_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show(_Usuario.NombreCompleto);


            cbtpdoc.Items.Add(new Opcioncb() { Valor = "Boleta", Texto = "Boleta" });
            cbtpdoc.Items.Add(new Opcioncb() { Valor = "Factura", Texto = "Factura" });
            cbtpdoc.DisplayMember = "Texto";
            cbtpdoc.ValueMember = "Valor";
            cbtpdoc.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidprov.Text = "0";
            txtidprod.Text = "0";

        }


        private void btnbusca_Click_1(object sender, EventArgs e) //buscaprovedoor
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidprov.Text = modal.__Proveedor.IdProveedor.ToString();
                    txtnrodoc.Text = modal.__Proveedor.Documento;
                    txtnomprov.Text = modal.__Proveedor.RazonSocial;

                }
                else
                {
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

                    txtpreco.Select();

                }
                else
                {
                    txtprd.Select();
                }
            }
        }

       
        private void txtprd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Productos().Listar().Where(p => p.Codigo == txtprd.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtprd.BackColor = Color.Honeydew;
                    txtidprod.Text = oProducto.IdProducto.ToString();
                    txtnprod.Text = oProducto.Nombre;
                    txtpreco.Select();
                }
                else
                {
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

            if (int.Parse(txtidprod.Text) == 0)
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

            if (!producto_existente)
            {

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
            if (dgvdata.Rows.Count > 0)
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
                if (dgvdata.Columns[e.ColumnIndex].Name == "btn")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        dgvdata.Rows.RemoveAt(indice);
                        Calcula();
                    }
                }
            }
        }

        private void txtpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreco.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false ;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void preve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreco.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void guardabtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidprov.Text)==0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdata.Rows.Count <1)
            {
                MessageBox.Show("Debe Ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto",typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows) 
            {
                detalle_compra.Rows.Add(
                    new object[]
                    {
                       Convert.ToInt32( row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       txttotalpaga.Text.ToString(),
                    });
             }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
               // oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario},
                oProveedor = new Proveedores() { IdProveedor = Convert.ToInt32(txtidprov.Text)},
                TipoDocumento =((Opcioncb)cbtpdoc.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txttotalpaga.Text),
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra,detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generado: \n"+numerodocumento + "\n\n Deseas copiar al PortaPapel?","Mensaje"
                    ,MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (result == DialogResult.Yes) {
                    Clipboard.SetText(numerodocumento);

                    txtidprov.Text = "0";
                    txtnrodoc.Text = "";
                    txtnomprov.Text = "";
                    dgvdata.Rows.Clear();
                    Calcula();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        
        }

    
    }
}
