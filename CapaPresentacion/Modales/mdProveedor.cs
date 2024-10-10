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

//video 14 arreglar
namespace CapaPresentacion.Modales
{
   
    public partial class mdProveedor : Form
    {
        public Proveedores __Proveedor {  get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true  )
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
                dgvdata.Rows.Add(new object[] { item.IdProveedor,item.Documento, item.RazonSocial, item.Correo, item.Telefono });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int icolum = e.ColumnIndex;

            if (iRow >=0 && icolum>0)
            {
                __Proveedor = new Proveedores()
                {
                    IdProveedor = Convert.ToInt32(dgvdata.Rows[iRow].Cells["id"].Value.ToString()),
                    Documento = dgvdata.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvdata.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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
