using CapaEntidad;
using CapaNegocia;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new Opcioncb() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new Opcioncb() { Valor = 0, Texto = "No Activo" });
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;

            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                cbcategoria.Items.Add(new Opcioncb() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbcategoria.DisplayMember = "Texto";
            cbcategoria.ValueMember = "Valor";
            cbcategoria.SelectedIndex = 0;


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

 
            List<Producto> listaProducto = new CN_Productos().Listar();

            foreach (Producto item in listaProducto)
            {

                dgvdata.Rows.Add(new object[] {
               "",
               item.IdProducto,
               item.Codigo,
               item.Nombre,
               item.Descripcion,
               item.oCategoria.IdCategoria,
               item.oCategoria.Descripcion,
               item.Stock,
               item.PrecioCompra,
               item.PrecioVenta,
               item.Estado ==true ? 1 : 0,
               item.Estado ==true ? "Activo" : "No Activo"

            });

            }
        }

        private void guardabtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto objproducto = new Producto()
            {
                IdProducto = Convert.ToInt32(regid.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtdescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((Opcioncb)cbcategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((Opcioncb)cbestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objproducto.IdProducto == 0)
            {
                int idprodgenerado = new CN_Productos().Registrar(objproducto, out mensaje);

                if (idprodgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                            "",idprodgenerado,
                           txtCodigo.Text,
                           txtNombre.Text,
                           txtdescripcion.Text,
                           ((Opcioncb)cbcategoria.SelectedItem).Valor.ToString(),
                           ((Opcioncb)cbcategoria.SelectedItem).Texto.ToString(),
                           "0",
                           "0.00",
                           "0.00",
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
                bool resultado = new CN_Productos().Editar(objproducto, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = regid.Text;
                    row.Cells["codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["Idcategoria"].Value = ((Opcioncb)cbcategoria.SelectedItem).Valor.ToString();
                    row.Cells["categoria"].Value = ((Opcioncb)cbcategoria.SelectedItem).Texto.ToString();                
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
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtdescripcion.Text = "";
             
            cbcategoria.SelectedIndex = 0;
            cbestado.SelectedIndex = 0;

            txtCodigo.Select();
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
                    
                    txtCodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();

                    string categoria = dgvdata.Rows[indice].Cells["categoria"].Value.ToString();
                    string estado = dgvdata.Rows[indice].Cells["Estado"].Value.ToString();
                    foreach (Opcioncb oc in cbcategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Idcategoria"].Value))
                        {
                            int indicecb = cbcategoria.Items.IndexOf(oc);
                            cbcategoria.SelectedIndex = indicecb;
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

        private void Borrabtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(regid.Text) != 0)
            {
                if (MessageBox.Show("Deseas eliminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objproducto = new Producto()
                    {

                        IdProducto = Convert.ToInt32(regid.Text)
                    };

                    bool respuesta = new CN_Productos().Eliminar(objproducto, out mensaje);

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

        private void limpiabtn_Click(object sender, EventArgs e)
        {
            Limpia();
        }


        //Reporte
        private void exportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count<1)
            {
                MessageBox.Show("No hay datos para exportar","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach(DataGridViewColumn colum in dgvdata.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                }
                foreach(DataGridViewRow row in dgvdata.Rows){
                    if (row.Visible)
                        dt.Rows.Add(new object[]{
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),                          
                            row.Cells[11].Value.ToString(),
                        });
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto_{0}.xlsx",
                    DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK) {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte Generado","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch {
                        MessageBox.Show("Error al Generar Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
    
