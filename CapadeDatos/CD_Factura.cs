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


    }
}
