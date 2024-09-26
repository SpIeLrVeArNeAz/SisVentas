using CapaEntidad;
using CapaNegocia;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
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


            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {

                dgvdata.Rows.Add(new object[] { "", item.IdCliente,item.Documento, item.NombreCompleto, item.Correo, item.Telefono,              
               item.Estado ==true ? 1 : 0,
               item.Estado ==true ? "Activo" : "No Activo"

            });

            }

      
          }

        private void guardabtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Cliente objCliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(regid.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,               
                Estado = Convert.ToInt32(((Opcioncb)cbestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objCliente.IdCliente == 0)
            {
                int IdCliente = new CN_Cliente().Registrar(objCliente, out mensaje);

                if (IdCliente != 0)
                {
                    dgvdata.Rows.Add(new object[] { "",IdCliente,txtDocumento.Text,txtNombreCompleto.Text, txtCorr.Text, txtTelefono.Text,
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
                bool resultado = new CN_Cliente().Editar(objCliente, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = regid.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
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
            txtNombreCompleto.Text = "";
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
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
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
                if (MessageBox.Show("Deseas eliminar el Cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objCliente = new Cliente()
                    {

                        IdCliente = Convert.ToInt32(regid.Text)
                    };

                    bool respuesta = new CN_Cliente().Eliminar(objCliente, out mensaje);

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

        private void exportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else   //////////////////////////////checking
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn colum in dgvdata.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]{
                            row.Cells[0].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            //row.Cells[6].Value.ToString(),

                        });
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteClientes_{0}.xlsx",
                    DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al Generar Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
    }
    }
}
