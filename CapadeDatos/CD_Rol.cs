using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;


namespace CapadeDatos
{
    public class CD_Rol
    {


        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query2 = new StringBuilder();
                    query2.AppendLine("select * from Rol");
                   

                    SqlCommand cmd = new SqlCommand(query2.ToString(), conexion);
                    
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                id_rol =  Convert.ToInt32(dr["id_rol"]),
                                descripcion = dr["descripcion"].ToString()

                                

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }

                return lista;
            }
        }
    }
}
