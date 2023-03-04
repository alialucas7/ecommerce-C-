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
    public class CD_Reporte
    {
        public DataTable grafico()
        {

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                StringBuilder query = new StringBuilder();
                //string query = "select * from Usuario";
                query.AppendLine("select s.descripcionSucur,count (s.descripcionSucur) [cantidad de autos vendidos] from Factura f ");
                query.AppendLine("inner join Usuario u on f.id_usuario = u.id_usuario");
                query.AppendLine("inner join Sucursal s on s.id_sucursal = u.id_sucursal");
                query.AppendLine("where f.fecha_creacion between '2023-03-03' and '2023-03-07'");
                query.AppendLine("group by s.descripcionSucur");

                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                return tabla;
            }
            
        }

        public List <ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentaass", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                fecha_creacion = dr["fecha_creacion"].ToString(),
                                codigoFactura = dr["codigoFactura"].ToString(),
                                monto_Total = dr["monto_Total"].ToString(),
                                Nombre_Usuario = dr["Nombre_Usuario"].ToString(),
                                Apellido_Usuario = dr["Apellido_Usuario"].ToString(),
                                dni_cliente = dr["dni_cliente"].ToString(),
                                nombre_cliente = dr["nombre_cliente"].ToString(),
                                
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }

            return lista;
        }





        public DataTable grafico2()
        {

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                StringBuilder query = new StringBuilder();
                //string query = "select * from Usuario";
                query.AppendLine("select  m2.descripcionMarca , count(m2.descripcionMarca)[cantidad mas vendida] from Detalle_Factura df ");
                query.AppendLine("inner join Automovil a on a.id_automovil = df.id_automovil");
                query.AppendLine("inner join Modelo m on m.id_modelo = a.id_modelo");
                query.AppendLine("and m.id_marca = a.id_marca");
                query.AppendLine("inner join Marca m2 on m2.id_marca = a.id_marca");
                query.AppendLine("group by m2.descripcionMarca");
                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                return tabla;
            }

        }



    }

}
