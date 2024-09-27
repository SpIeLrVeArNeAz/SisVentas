using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaData
{

   //video 13
    public  class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                { 
                conexion.Open();

                    string query = "Select IdNegocio,Nombre,RUC,Direccion  from Negocio where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query,conexion);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RUC = dr["RUC"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };
                        }
                    }
                }
            }
             catch (Exception ex)
            {
                obj = new Negocio();
            }
            return obj;
        }

        public bool GuardaData(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Negocio set Nombre = @Nombre,");
                    query.AppendLine("RUC = @Ruc,");
                    query.AppendLine("Direccion = @Direccion");
                    query.AppendLine("where IdNegocio = 1;");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombre",objeto.Nombre);
                    cmd.Parameters.AddWithValue("@ruc", objeto.RUC);
                    cmd.Parameters.AddWithValue("@direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;
                    if (cmd.ExecuteNonQuery() < 1) {
                        mensaje = "No se pudo guardar data";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                     respuesta=false;   
            }

            return respuesta;

        }

        public byte[] ObtenerLogo (out bool obtenido){ 
        obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "Select Logo  from Negocio where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion); 
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];

                            //obj = new Negocio()
                            //{
                            //    IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                            //    Nombre = dr["Nombre"].ToString(),
                            //    RUC = dr["RUC"].ToString(),
                            //    Direccion = dr["Direccion"].ToString()
                            //};
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }








    }
}
