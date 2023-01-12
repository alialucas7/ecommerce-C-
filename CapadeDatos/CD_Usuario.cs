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
    }
}
