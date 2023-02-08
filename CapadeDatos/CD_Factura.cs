using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;


namespace CapadeDatos
{
    public class CD_Factura
    {
        public int obtenerCorrelativo()
        {
            int id_correlativo = 0;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) +1 from Factura");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    id_correlativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch(Exception ex)
                {
                    id_correlativo = 0;
                }
            }
            return id_correlativo;
        }



        /*Metodo que actualiza el stock en tiempo real*/
        public bool restarStock(int cantidad, int id_automovil)
        {
            bool respuesta = true;
            using (SqlConnection conexionn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Automovil set stock = stock - @cantidad where id_automovil=@id_automovil");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexionn);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_automovil", id_automovil);
                    cmd.CommandType = CommandType.Text;
                    conexionn.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch(Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool sumarStock(int cantidad, int id_automovil)
        {
            bool respuesta = true;
            using (SqlConnection conexionn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Automovil set stock = stock + @cantidad where id_automovil=@id_automovil");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexionn);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_automovil", id_automovil);
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




        /*Funcion de registrar factura*/
        public bool RegistrarFactura(Factura factu, DataTable Detalle_Factura, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection conexioni = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVentAAx", conexioni);
                    cmd.Parameters.AddWithValue("idUsser", factu.objUsuario.id_usuario);
                    cmd.Parameters.AddWithValue("tipoFactura",factu.objTipoFact.id_tipoFact);
                    cmd.Parameters.AddWithValue("dni",factu.dniCliente);
                    cmd.Parameters.AddWithValue("nameCliente",factu.nameCliente);
                    cmd.Parameters.AddWithValue("montoPago",factu.montoPago);
                    cmd.Parameters.AddWithValue("montoCambio",factu.montoCambio);
                    cmd.Parameters.AddWithValue("monto_Total",factu.montoTotal);
                    cmd.Parameters.AddWithValue("detalleVenta", Detalle_Factura);
                    cmd.Parameters.AddWithValue("codigoFactura", factu.codigoFactu);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexioni.Open();
                    cmd.ExecuteNonQuery();

                    //salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message; 
            }
            return respuesta;
        }




        /*con este metodo traigo la factura y lo filtro con codigoFactura*/
        public Factura obtenerFactura(int number)
        {
            Factura objFactu = new Factura();

            try
            {
                using (SqlConnection conexioni = new SqlConnection(Conexion.cadena))
                {
                    conexioni.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select f.id_factura,u.id_usuario,u.nombre, u.apellido,tp.id_tipo,tp.descripcion, f.dni_cliente,f.nombre_cliente, ");
                    query.AppendLine("f.montopago,f.montocambio,f.monto_Total,f.codigoFactura,");
                    query.AppendLine("convert (char(10),f.fecha_creacion,103)[fecha_creacion] from Factura f");
                    query.AppendLine("inner join Usuario u on u.id_usuario = f.id_usuario");
                    query.AppendLine("inner join Tipo_Factura tp on tp.id_tipo = f.id_tipo");
                    query.AppendLine("where f.codigoFactura = @numero");
                    //query.AppendLine("");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexioni);
                    cmd.Parameters.AddWithValue("@numero", number);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objFactu = new Factura()
                            {
                                id_venta = int.Parse(dr["id_factura"].ToString()),
                                objUsuario = new Usuario() { id_usuario = int.Parse(dr["id_usuario"].ToString()), name = dr["nombre"].ToString(), apellido = dr["apellido"].ToString() },
                                objTipoFact = new TipoFactura() { id_tipoFact = int.Parse(dr["id_tipo"].ToString()), descripcion = dr["descripcion"].ToString() },
                                dniCliente = dr["dni_cliente"].ToString(),
                                nameCliente = dr["nombre_cliente"].ToString(),
                                montoPago = Convert.ToDecimal(dr["montopago"].ToString()),
                                montoCambio = Convert.ToDecimal(dr["montocambio"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["monto_Total"].ToString()),
                                codigoFactu = Convert.ToInt32(dr["codigoFactura"].ToString()),
                                fechaRegistro = dr["fecha_creacion"].ToString()
                            };
         
    
                        }
                    }

                }
            }
            catch 
            {
                objFactu = new Factura();
            }

            return objFactu;
        }





        public List<DetalleFactura> obtenerDetallito(int id_detlle)
        {
            string mensaje = "";
            List<DetalleFactura> oLista = new List<DetalleFactura>();

            try
            {
                using (SqlConnection conexioni = new SqlConnection(Conexion.cadena))
                {
                    conexioni.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select m2.descripcionMarca,m1.descripcionModelo,df.precioVenta,df.cantidad,df.subTotal from Detalle_Factura df");
                    query.AppendLine("inner join Automovil a on a.id_automovil= df.id_automovil");
                    query.AppendLine("inner join Modelo m1 on m1.id_modelo = a.id_modelo");
                    query.AppendLine("and				  m1.id_marca = a.id_marca");
                    query.AppendLine("inner join Marca  m2 on m2.id_marca = a.id_marca");
                    query.AppendLine("where df.id_factura =@id_detlle");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexioni);
                    cmd.Parameters.AddWithValue("@id_detlle", id_detlle);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleFactura()
                            {
                                objAuto = new Automovil()
                                {
                                    objMarcaa = new Marca() { descripcionMarca = dr["descripcionMarca"].ToString() },
                                    objModeloo = new Modelo() { descripcionModel = dr["descripcionModelo"].ToString() },
                                },
                                precioVenta = Convert.ToDecimal(dr["precioVenta"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                subTotal = Convert.ToDecimal(dr["subTotal"].ToString()),

                            });
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                oLista = new List<DetalleFactura>();
               mensaje= ex.Message;
            }

            return oLista;
        }






    }
}
