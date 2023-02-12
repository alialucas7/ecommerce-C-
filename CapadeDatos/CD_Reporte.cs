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
                string query = "select a.id_sucursal, count(a.id_sucursal)[Cantidad de Automoviles] from Automovil a group by a.id_sucursal";
                SqlCommand cmd = new SqlCommand(query, oconexion);
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
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
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
                                descripcionMarca = dr["descripcionMarca"].ToString(),
                                descripcionModelo = dr["descripcionModelo"].ToString(),
                                precioVenta = dr["precioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                Subtotal = dr["Sub Total"].ToString(),
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

    }

}
