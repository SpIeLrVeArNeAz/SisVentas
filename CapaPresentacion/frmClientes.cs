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
    }
}
