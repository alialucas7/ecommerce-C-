﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapadeDatos;

namespace CapadeDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            
            List<Usuario> lista = new List<Usuario>();
           
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.id_usuario, u.dni,u.name,u.apellido,u.email,u.estado,r.id_rol,r.descripcion from Usuario u");
                    query.AppendLine("inner join rol r on r.id_rol = u.id_rol");
                        
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                   
                    cmd.CommandType = CommandType.Text;
                    
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        
                         
                            while (dr.Read())
                            {
                            ///int idTemporal = Convert.ToInt32(dr["id_rol"]);
                                lista.Add(new Usuario(){ 
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                obRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]) , descripcion = dr["descripcion"].ToString()},
                                    //obRol = new Rol(idTemporal),
                                dni = dr["dni"].ToString(),
                                name = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                pasword = dr["pasword"].ToString(),
                                state = Convert.ToBoolean(dr["estado"]),
                                
                            });
                        }
                    }
                }
                catch(Exception ex)
                {
                    lista = new List<Usuario>();
                }

                return lista;
            }
        }
	//comentario de prueba 







        public int Editar(Usuario objU,out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para registrar usser*/
                    
                    //datos de entrada
                    cmd.Parameters.AddWithValue("idRol", objU.obRol.id_rol);
                    cmd.Parameters.AddWithValue("dni",objU.dni);
                    cmd.Parameters.AddWithValue("nombre", objU.name);
                    cmd.Parameters.AddWithValue("apellido", objU.apellido);
                    cmd.Parameters.AddWithValue("email", objU.email);
                    cmd.Parameters.AddWithValue("telefono", objU.telefono);
                    cmd.Parameters.AddWithValue("estado", objU.state);
                    cmd.Parameters.AddWithValue("pasword", objU.pasword);
                    //datos de salida
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;
                    
                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }


            return idUsuarioGenerado;
        }


        public int Registrar(Usuario objU, out string Mensaje)
        {
            int respuesta = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITAR_Usuario", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para registrar usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("idRol", objU.obRol.id_rol);
                    cmd.Parameters.AddWithValue("dni", objU.dni);
                    cmd.Parameters.AddWithValue("nombre", objU.name);
                    cmd.Parameters.AddWithValue("apellido", objU.apellido);
                    cmd.Parameters.AddWithValue("email", objU.email);
                    cmd.Parameters.AddWithValue("telefono", objU.telefono);
                    cmd.Parameters.AddWithValue("estado", objU.state);
                    cmd.Parameters.AddWithValue("pasword", objU.pasword);
                    //datos de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                Mensaje = ex.Message;
            }


            return respuesta;
        }


        public int Eliminar(Usuario objU, out string Mensaje)
        {
            int respuesta = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para registrar usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("idUsuario", objU.id_usuario);
                    

                    //datos de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                Mensaje = ex.Message;
            }


            return respuesta;
        }
    }
}
