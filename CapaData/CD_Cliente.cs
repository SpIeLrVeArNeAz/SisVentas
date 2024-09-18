﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(" select IdCliente,Documento,NombreCompleto,Correo,Telefono,Estado From cliente\r\n");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {

                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Cliente>();
                }
            }

            return lista;
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            int resultado = 0; 
            Mensaje = string.Empty;
 
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_RegistraCliente".ToString(), oConexion);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                Mensaje = ex.Message;

            }

            return resultado;
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EditaCliente".ToString(), oConexion);
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;

            }

            return resultado;
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from cliente where IdCliente = @Id ", oConexion);
                    cmd.Parameters.AddWithValue("@id", obj.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
 

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;

            }

            return respuesta;
        }
    }
}
 
