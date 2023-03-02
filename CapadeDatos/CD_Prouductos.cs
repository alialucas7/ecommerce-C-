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
    public class CD_Prouductos
    {


        public List<Automovil> Listar()
        {

            List<Automovil> lista = new List<Automovil>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    //string query = "select * from Usuario";
                    query.AppendLine("select a.id_automovil, m2.id_marca, m2.descripcionMarca, m1.id_modelo, m1.descripcionModelo, a.patente, a.precio, a.estado, a.n_puertas, a.color, a.año_fabricacion, a.descripcion, a.fecha_registro from Automovil a");
                    query.AppendLine("inner join Modelo m1 on m1.id_modelo = a.id_modelo");
                    query.AppendLine("and				  m1.id_marca = a.id_marca");
                    query.AppendLine("inner join Marca  m2 on m2.id_marca = a.id_marca");




                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {
                            
                            lista.Add(new Automovil()
                            {
                                id_automovil = Convert.ToInt32(dr["id_automovil"]),
                                //id_sucursal = new Sucursal() { id_sucursal = Convert.ToInt32(dr["id_sucursal"]) },
                                objMarcaa = new Marca() { id_marca = Convert.ToInt32(dr["id_marca"]), descripcionMarca = dr["descripcionMarca"].ToString() },
                                objModeloo = new Modelo() { objMarca = new Marca() { id_marca = Convert.ToInt32(dr["id_marca"]), descripcionMarca = dr["descripcionMarca"].ToString() },
                                id_modelo = Convert.ToInt32(dr["id_modelo"]), descripcionModel = dr["descripcionModelo"].ToString()},
                                patente = dr["patente"].ToString(),
                                precio = Convert.ToDecimal(dr["precio"]),
                                //stock = Convert.ToInt32(dr["stock"]),
                                estado = Convert.ToBoolean(dr["estado"]),
                                nPuertas = Convert.ToInt32(dr["n_puertas"]),
                                color = dr["color"].ToString(),
                                añoFabricacion = dr["año_fabricacion"].ToString(),
                                descripcionAuto = dr["descripcion"].ToString(),
                                fechaReg = dr["fecha_registro"].ToString()

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Automovil>();
                }

                return lista;
            }
        }




        public int Registrar(Automovil objAuto, out string Mensaje)
        {
            int resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProductoo", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para registrar usser*/

                    //datos de entrada
                   // cmd.Parameters.AddWithValue("id_automovil", objAuto.id_automovil);
                   // cmd.Parameters.AddWithValue("id_sucursal", objAuto.id_sucursal.id_sucursal);
                    cmd.Parameters.AddWithValue("id_modelo", objAuto.objModeloo.id_modelo);
                    cmd.Parameters.AddWithValue("id_marca", objAuto.objMarcaa.id_marca);
                    cmd.Parameters.AddWithValue("patente", objAuto.patente);
                    cmd.Parameters.AddWithValue("precio", objAuto.precio);
                   //cmd.Parameters.AddWithValue("stock", objAuto.stock);
                    cmd.Parameters.AddWithValue("estado", objAuto.estado);
                    cmd.Parameters.AddWithValue("n_puertas", objAuto.nPuertas);
                    cmd.Parameters.AddWithValue("color", objAuto.color);
                    cmd.Parameters.AddWithValue("año_fabricacion", objAuto.añoFabricacion);
                    cmd.Parameters.AddWithValue("descripcion", objAuto.descripcionAuto);
                    //datos de salida
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

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








        public int Editar(Automovil objAuto, out string Mensaje)
        {
            int resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProductoo", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para editar usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("id_automovil", objAuto.id_automovil);
                 //   cmd.Parameters.AddWithValue("id_sucursal", objAuto.id_sucursal.id_sucursal);
                    cmd.Parameters.AddWithValue("id_modelo", objAuto.objModeloo.id_modelo);
                    cmd.Parameters.AddWithValue("id_marca", objAuto.objMarcaa.id_marca);
                    cmd.Parameters.AddWithValue("patente", objAuto.patente);
                    cmd.Parameters.AddWithValue("precio", objAuto.precio);
                  //  cmd.Parameters.AddWithValue("stock", objAuto.stock);
                    cmd.Parameters.AddWithValue("estado", objAuto.estado);
                    cmd.Parameters.AddWithValue("n_puertas", objAuto.nPuertas);
                    cmd.Parameters.AddWithValue("color", objAuto.color);
                    cmd.Parameters.AddWithValue("año_fabricacion", objAuto.añoFabricacion);
                    cmd.Parameters.AddWithValue("descripcion", objAuto.descripcionAuto);
                    //datos de salida
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                Mensaje = ex.Message;
            }


            return resultado;
        }












        public int Eliminar(Automovil objAuto, out string Mensaje)
        {
            int respuesta = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Eliminar_Producto", conexion);
                    /*Procedo a ejecutar el procedimiento almacenado para eliminar el usser*/

                    //datos de entrada
                    cmd.Parameters.AddWithValue("id_automovil", objAuto.id_automovil);


                    //datos de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    //storesprocedure xq es un proc almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
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
    }





}

