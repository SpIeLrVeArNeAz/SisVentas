using CapaEntidad;
using CapaNegocia;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{

    /// <summary>
    /// arreglar 14, no selecciona
    /// </summary>
    public partial class mdProducto : Form
    {
        public Producto _producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true)
                {
                    cbbusca.Items.Add(new Opcioncb() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbbusca.DisplayMember = "Texto";
            cbbusca.ValueMember = "Valor";
            cbbusca.SelectedIndex = 0;

            List<Producto> listaProd = new CN_Productos().Listar();

            foreach (Producto item in listaProd)
            {
                dgvdata.Rows.Add(new object[] {
               item.IdProducto,
               item.Codigo,
               item.Nombre,
               item.oCategoria.Descripcion,
               item.Stock,
               item.PrecioCompra,
               item.PrecioVenta,
                });
            }
        }
        private void dgvdata_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int icolum = e.ColumnIndex;
            if (iRow >= 0 && icolum > 0)
            {
                _producto = new Producto()
                { 
                    IdProducto = Convert.ToInt32(dgvdata.Rows[iRow].Cells["id"].Value.ToString()),
                    Codigo = dgvdata.Rows[iRow].Cells["codigo"].Value.ToString(),
                    Nombre = dgvdata.Rows[iRow].Cells["nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["preciocom"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["preciovent"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnbusca_Click_1(object sender, EventArgs e)
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
        private void btnlimpiab_Click_1(object sender, EventArgs e)
        {
            buscatxt.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
    }
 
