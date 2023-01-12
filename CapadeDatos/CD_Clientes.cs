using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos
{
    public class CD_Clientes
    {
        public List<Cliente> Listar()
        {

            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select id_cliente,dni,nombre,apellido,email,telefono,estado from Cliente ";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {
                            ///int idTemporal = Convert.ToInt32(dr["id_rol"]);
                            lista.Add(new Cliente()
                            {
                                id_Cliente = Convert.ToInt32(dr["id_Cliente"]),
                                obRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]) },
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
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }

                return lista;
            }
        }
    }
}
