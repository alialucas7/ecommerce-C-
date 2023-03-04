using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;

using System.Data.SqlClient;
using System.Data;

namespace CapadeDatos
{
    public class CD_Backup
    {

        public int generarBackup(String consulta, out string mensaje)
        {
            //string mensajeee = string.Empty;
            int bandera = 1;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //StringBuilder query = new StringBuilder();
                    //query.AppendLine("select count(*) +1 from Factura");
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    mensaje = "El Bakup se realizo correctamente :)";
                    conexion.Close();
                    //conexion.Close();.
                    
                }
                catch (Exception ex)
                {
                    mensaje = ex.ToString();
                    bandera = 0;
                }
            }
            return bandera;
        }
    }
}
