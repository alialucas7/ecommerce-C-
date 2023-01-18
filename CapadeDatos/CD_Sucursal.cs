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
    public class CD_Sucursal
    {


        

            public List<Sucursal> Listar()
            {
                List<Sucursal> lista = new List<Sucursal>();

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        StringBuilder query2 = new StringBuilder();
                        query2.AppendLine("select s.id_sucursal,s.descripcionSucur,l.id_localidad, l.descripcionLocality ,p1.id_provincia, p1.descripcionProv,p2.id_pais, p2.descripcionPais from Sucursal s ");
                        query2.AppendLine("inner join Localidad l on s.id_localidad = l.id_localidad");
                        query2.AppendLine("inner join Provincia p1 on l.id_provincia = p1.id_provincia");
                        query2.AppendLine("and						   l.id_pais=p1.id_pais");
                        query2.AppendLine("inner join Pais p2 on      l.id_pais= p2.id_pais");

                    SqlCommand cmd = new SqlCommand(query2.ToString(), conexion);

                        cmd.CommandType = CommandType.Text;
                        conexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Sucursal()
                                {
                                    id_sucursal = Convert.ToInt32(dr["id_sucursal"]),
                                    descripcion = dr["descripcionSucur"].ToString(),
                                    objLocalidad = new Localidad() { id_localidad = Convert.ToInt32(dr["id_localidad"]), descripcionLocal = dr["descripcionLocality"].ToString() },
                                    objProvincia = new Provincia() { id_provincia = Convert.ToInt32(dr["id_provincia"]), descripcionPro = dr["descripcionProv"].ToString() },
                                    objPais = new Pais() { id_pais = Convert.ToInt32(dr["id_pais"]), descripcionPais = dr["descripcionPais"].ToString() }
                                


                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lista = new List<Sucursal>();
                    }

                    return lista;
                }
            }

        }
    
}

