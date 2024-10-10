using CapaEntidad;
using CapaPresentacion.Modales;
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

            cbtpdoc.Items.Add(new Opcioncb() { Valor =  "Boleta", Texto = "Boleta" });
            cbtpdoc.Items.Add(new Opcioncb() { Valor = "Factura", Texto = "Factura"});
            cbtpdoc.DisplayMember = "Texto";
            cbtpdoc.ValueMember = "Valor";
            cbtpdoc.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
           
            txtidprov.Text = "0";
            txtidprod.Text = "0";

        }

        //private void btnbusca_Click(object sender, EventArgs e)
        //{
        //    using (var modal = new mdProducto()) { 
        //    var result = modal.ShowDialog();

        //        //if (result == DialogResult.OK) {
        //        //    txtidprov.Text = modal._producto.IdProveedor.ToString();
        //        //    txtnrodoc.Text = modal._producto.Documento;
        //        //    txtnomprov.Text = modal._producto.RazonSocial;

        //        //}
        //        else
        //        {
        //            txtnrodoc.Select();
        //        }
        //    }
        //}

        //private void buscaprodbtn_Click(object sender, EventArgs e)
        //{
        //    using (var modal = new mdProducto())
        //    {
        //        var result = modal.ShowDialog();

        //        if (result == DialogResult.OK)
        //        {
        //            txtidprod.Text = modal._producto.IdProducto.ToString();
        //            txtnprod.Text = modal._producto.Codigo;
        //            txtpreco.Text = modal._producto.PrecioCompra;
        //            preve.Text = modal._producto.PrecioVenta;


        //        }
        //        else
        //        {
        //            txtnrodoc.Select();
        //        }
        //    }
      //  }
    }
}
