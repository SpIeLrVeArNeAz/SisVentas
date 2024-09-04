using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public List<Det_Compra> oDetCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedores oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
