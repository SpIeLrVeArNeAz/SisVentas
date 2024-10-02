using CapaData;
using CapaEntidad;


namespace CapaNegocia
{
    public class CN_Negocio
    {

      private CD_Negocio objcd_negocio = new  CD_Negocio();
        public Negocio ObtenerDatos()
        {
            return objcd_negocio.ObtenerDatos();
        }

        public bool GuardaData(Negocio obj, out string Mensaje) {
        
            Mensaje = string.Empty;
            if(obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre \n";
            }
            if (obj.RUC == "")
            {
                Mensaje += "Es necesario el RUC \n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion \n";
            }
            if (Mensaje != string.Empty)
            {
                return false ;
            }
            else { 
                return objcd_negocio.GuardaData(obj, out Mensaje);
            }
        }

        public byte[]  ObtenerLogo( out bool obtenido)
        {
            return objcd_negocio.ObtenerLogo( out obtenido);
        }

        public bool ActualizaLogo(byte[] imagen, out string mensaje)
        {
        return objcd_negocio.ActualizaLogo(imagen, out mensaje);        
        }



    }
}
