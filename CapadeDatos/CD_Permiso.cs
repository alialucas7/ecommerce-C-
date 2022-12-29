using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;


namespace CapadeDatos
{
    public class CD_Permiso
    {
        //funcion que lista los permisos--// misma que en CD_usuarios
        public List<Permiso> Listar(int id_usuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query2 = new StringBuilder();
                    query2.AppendLine("select p.id_rol, p.nombreMenu from Permiso p");
                    query2.AppendLine("inner join Rol r on r.id_rol = p.id_rol");
                    query2.AppendLine("inner join Usuario u on u.id_rol = r.id_rol");
                    query2.AppendLine("where u.id_usuario = @id_usuario");
                 
                    SqlCommand cmd = new SqlCommand(query2.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@id_usuario",id_usuario);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                objtRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]) },
                                nameMenu = dr["nombreMenu"].ToString(),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }

                return lista;
            }
        }

         

    }
}
