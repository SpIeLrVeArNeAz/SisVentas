using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;
using CapaEntidad;

namespace CapaNegocia
{
    public class CN_usuario
    {
        public CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        { 
        return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "") {
                Mensaje += "Es necesario el Documento del usuario\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el Nombre del usuario\n";
            }
            if (obj.clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if(Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del usuario\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el Nombre del usuario\n";
            }
            if (obj.clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }

    }
}
