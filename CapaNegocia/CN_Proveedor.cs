using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocia
{
    public class CN_Proveedor
    {
        public CD_Provedoor objcd_Provedoor = new CD_Provedoor();

        public List<Proveedores> Listar()
        {
            return objcd_Provedoor.Listar();
        }

        public int Registrar(Proveedores obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del Cliente\n";
            }
            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario la Razon Social del Cliente\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Provedoor.Registrar(obj, out Mensaje);
            }

        }
        public bool Editar(Proveedores obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del Provedoor\n";
            }
            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario la razon del Provedoor\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Provedoor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Provedoor.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Proveedores  obj, out string Mensaje)
        {
            return objcd_Provedoor.Eliminar(obj, out Mensaje);
        }
    }
}
