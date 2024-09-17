using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocia
{
    public class CN_Productos
    {

        public CD_Productos objcd_Productos = new CD_Productos();

        public List<Producto> Listar()
        {
            return objcd_Productos.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
 
            if (obj.Codigo  == "")
            {
                Mensaje += "Es necesario el Codigo del Producto\n";
            }
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre completo del Productos\n";
            }
            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la Descripcion  del Productos\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Productos.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el Codigo del Producto\n";
            }
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre completo del Producto\n";
            }
            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesariala Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Productos.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Productos.Eliminar(obj, out Mensaje);
        }

    }

}

