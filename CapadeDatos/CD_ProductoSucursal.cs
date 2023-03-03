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
    public class CD_ProductoSucursal
    {

        public List<Producto_Sucursal> Listar(Usuario objuSuario)
        {

            List<Producto_Sucursal> lista = new List<Producto_Sucursal>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                  
                    query.AppendLine("select s.id_sucursal,ps.id_automovil, a.id_marca,m2.descripcionMarca,");
                    query.AppendLine("a.id_modelo,m1.descripcionModelo,a.patente,a.precio,a.estado,");
                    query.AppendLine("a.n_puertas,a.color,a.año_fabricacion,a.descripcion,ps.stock");
                    query.AppendLine("from Producto_Sucursal ps");
                    query.AppendLine("inner join Automovil a on ps.id_automovil = a.id_automovil");
                    query.AppendLine("inner join Sucursal s on ps.id_sucursal = s.id_sucursal");
                    query.AppendLine("inner join Modelo m1 on m1.id_modelo = a.id_modelo");
                    query.AppendLine("               and				  m1.id_marca = a.id_marca");
                    query.AppendLine("inner join Marca  m2 on m2.id_marca = a.id_marca");
                    query.AppendLine("where s.id_sucursal = @id_sucursal");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    /*Recibe el parametro de la sucursal del usuario, segun corresponda*/
                    cmd.Parameters.AddWithValue("id_sucursal", objuSuario.id_sucursal);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        
                        while (dr.Read())
                        {

                            lista.Add(new Producto_Sucursal()
                            {
                                
                               
                                objetoSucursal = new Sucursal()
                                {
                                    id_sucursal = Convert.ToInt32((dr["id_sucursal"]))
                                },
                                objetoAuto = new Automovil()
                                {
                                     id_automovil = Convert.ToInt32((dr["id_automovil"])),
                                     objMarcaa = new Marca()
                                     {
                                         id_marca = Convert.ToInt32((dr["id_marca"])),
                                         descripcionMarca = (dr["descripcionMarca"]).ToString()
                                     }, 
                                     objModeloo = new Modelo()
                                     {
                                         objMarca = new Marca()
                                         {
                                             id_marca = Convert.ToInt32((dr["id_marca"])),
                                             descripcionMarca = (dr["descripcionMarca"]).ToString()
                                         },
                                         id_modelo = Convert.ToInt32((dr["id_modelo"])),
                                         descripcionModel = (dr["descripcionModelo"]).ToString()

                                     },
                                      patente = (dr["patente"]).ToString(), 
                                      precio = Convert.ToDecimal((dr["precio"])), 
                                      estado = Convert.ToBoolean((dr["estado"])),
                                      nPuertas = Convert.ToInt32((dr["n_puertas"])), 
                                      color = (dr["color"]).ToString(),
                                      añoFabricacion = (dr["año_fabricacion"]).ToString(), 
                                      descripcionAuto = (dr["descripcion"]).ToString(),
                                },
                                stock = Convert.ToInt32(dr["stock"])
                                
                            });
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto_Sucursal>();
                }

                return lista;
            }
        }











    }
}
