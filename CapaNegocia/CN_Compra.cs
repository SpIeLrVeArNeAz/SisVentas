using CapaData;
using CapaEntidad;
 
using System.Data;
 

namespace CapaNegocia
{
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();

        public int  ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }
        public bool Registrar(Compra obj,DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);

        }
    }
}
