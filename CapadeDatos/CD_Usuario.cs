using System;
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
                    //string query = "select * from Usuario";

                    query.AppendLine("select u.id_Usuario,u.id_sucursal,r.id_rol, r.descripcion, u.dni, u.nombre, u.apellido, u.email,u.telefono, u.estado,u.pasword from Usuario u");

                    query.AppendLine("inner join Rol r on r.id_rol = u.id_rol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {
                            ///int idTemporal = Convert.ToInt32(dr["id_rol"]);
                            lista.Add(new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dr["id_Usuario"]),
                                id_sucursal = Convert.ToInt32(dr["id_sucursal"]),
                                obRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]), descripcion = dr["descripcion"].ToString() },
                                //obRol = new Rol(idTemporal),
                                dni = dr["dni"].ToString(),
                                name = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                state = Convert.ToBoolean(dr["estado"]),
                                pasword = dr["pasword"].ToString()


                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }

                return lista;
            }
        }
        //comentario de prueba 


        public int Registrar(Usuario objU, out string Mensaje)
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
                    cmd.Parameters.AddWithValue("id_sucursal", objU.id_sucursal);
                    cmd.Parameters.AddWithValue("dni", objU.dni);
                    cmd.Parameters.AddWithValue("nombre", objU.name);
                    cmd.Parameters.AddWithValue("apellido", objU.apellido);
                    cmd.Parameters.AddWithValue("email", objU.email);
                    cmd.Parameters.AddWithValue("telefono", objU.telefono);
                    cmd.Parameters.AddWithValue("estado", objU.state);
                    cmd.Parameters.AddWithValue("pasword", objU.pasword);
                    //datos de salida
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

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


        public int Editar(Usuario objU, out string Mensaje)
        {
            int respuesta = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITAR_Usuarioo", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para editar usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("idUsuario", objU.id_usuario);
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
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

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
                    /*Procedo a ejecutar el procedimiento almacenado para eliminar el usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("idUsuario", objU.id_usuario);


                    //datos de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

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
