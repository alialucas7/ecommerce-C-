using CapaEntidad;
using CapadeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos
{
    public class CD_Cliente
    {
        //Listar Clientes
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    //string query = "select * from Cliente";
                    query.AppendLine("select id_cliente,dni,nombre,apellido,email,telefono,estado,fecha_creacion from Cliente");

                    //Hace referencia a un tipo de dato texto
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                dni = dr["dni"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                fecha_creacion = dr["fecha_creacion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }

                return lista;
            }
        }
        
        //Registrar Cliente
        public int Registrar(Cliente objU, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para registrar usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("dni", objU.dni);
                    cmd.Parameters.AddWithValue("nombre", objU.nombre);
                    cmd.Parameters.AddWithValue("apellido", objU.apellido);
                    cmd.Parameters.AddWithValue("email", objU.email);
                    cmd.Parameters.AddWithValue("telefono", objU.telefono);
                    cmd.Parameters.AddWithValue("estado",objU.estado);

;
                    //datos de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }


            return idClienteGenerado;
        }

        //Editar Cliente
        public int Editar(Cliente objU, out string Mensaje)
        {
            int respuesta = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarCliente", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para editar usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("id_cliente", objU.id_cliente);
                    cmd.Parameters.AddWithValue("dni", objU.dni);
                    cmd.Parameters.AddWithValue("nombre", objU.nombre);
                    cmd.Parameters.AddWithValue("apellido", objU.apellido);
                    cmd.Parameters.AddWithValue("email", objU.email);
                    cmd.Parameters.AddWithValue("telefono", objU.telefono);
                    cmd.Parameters.AddWithValue("estado", objU.estado);

                    //datos de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
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

        //Eliminar Cliente
        public bool Eliminar(Cliente objU, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from cliente where id_cliente = @id_cliente", conexion);
                    cmd.Parameters.AddWithValue("@id_cliente", objU.id_cliente);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
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
