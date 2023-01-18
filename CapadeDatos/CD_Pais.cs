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
    public class CD_Pais
    {

        public List<Pais> Listar()
        {
            List<Pais> lista = new List<Pais>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query2 = new StringBuilder();
                    query2.AppendLine("select * from Pais");


                    SqlCommand cmd = new SqlCommand(query2.ToString(), conexion);

                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Pais()
                            {
                                id_pais = Convert.ToInt32(dr["id_pais"]),
                                descripcionPais = dr["descripcion"].ToString()



                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Pais>();
                }

                return lista;
            }
        }
    }
}
