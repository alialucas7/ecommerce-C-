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
    public class CD_Modelo
    {

        public List<Modelo> Listar(int id_marca)
        {
            List<Modelo> lista = new List<Modelo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query2 = new StringBuilder();
                    query2.AppendLine("Select m.id_modelo, m.descripcion from  Modelo m where id_marca = @id_marca");


                    SqlCommand cmd = new SqlCommand(query2.ToString(), conexion);

                    cmd.Parameters.AddWithValue("id_marca", id_marca);

                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Modelo()
                            {
                                id_modelo = Convert.ToInt32(dr["id_modelo"]),
                                descripcion = dr["descripcion"].ToString()



                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Modelo>();
                }

                return lista;
            }
        }
    }
}
