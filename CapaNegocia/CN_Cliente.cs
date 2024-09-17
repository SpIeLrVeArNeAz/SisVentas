using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocia
{
    public class CN_Cliente
    {
        public CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del Cliente\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el Nombre del Cliente\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesarioel telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }

        }
        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del Cliente\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el Nombre del Cliente\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_Cliente.Eliminar(obj, out Mensaje);
        }

    }
}

