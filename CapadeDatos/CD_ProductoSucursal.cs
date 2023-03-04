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




        public int AltaProduct(Producto_Sucursal objeto, out string Mensaje)
        {
            int resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_AltaProductoSucursaaal", conexion);
                   
                    cmd.Parameters.AddWithValue("id_automovil", objeto.objetoAuto.id_automovil);
                    cmd.Parameters.AddWithValue("id_sucursal", objeto.objetoSucursal.id_sucursal);
                    cmd.Parameters.AddWithValue("stock", objeto.stock);
                   
                    //datos de salida
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                Mensaje = ex.Message;
            }


            return resultado;
        }


        public int bajaProducto(Producto_Sucursal objeto, out string Mensaje)
        {
            int resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_BajitaSucursal", conexion);

                    cmd.Parameters.AddWithValue("id_automovil", objeto.objetoAuto.id_automovil);
                    cmd.Parameters.AddWithValue("id_sucursal", objeto.objetoSucursal.id_sucursal);
                    

                    //datos de salida
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                Mensaje = ex.Message;
            }


            return resultado;
        }

        /*Metodo que actualiza el stock en tiempo real*/
        public bool restarStock(int cantidad, int id_automovil, int id_sucursal)
        {
            bool respuesta = true;
            using (SqlConnection conexionn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto_Sucursal set stock = stock - @cantidad where id_automovil=@id_automovil and id_sucursal=@id_sucursal");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexionn);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_automovil", id_automovil);
                    cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                    cmd.CommandType = CommandType.Text;
                    conexionn.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool sumarStock(int cantidad, int id_automovil, int id_sucursal)
        {
            bool respuesta = true;
            using (SqlConnection conexionn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto_Sucursal set stock = stock + @cantidad where id_automovil=@id_automovil and id_sucursal=@id_sucursal");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexionn);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_automovil", id_automovil);
                    cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                    cmd.CommandType = CommandType.Text;
                    conexionn.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }
}
