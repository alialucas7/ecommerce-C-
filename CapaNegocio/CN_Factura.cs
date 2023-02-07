using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using System.Data;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Factura
    {

        private CD_Factura obj_Factu = new CD_Factura();

        public bool restarStock(int cantidad, int id_automovil)
        {
            return obj_Factu.restarStock(cantidad, id_automovil);
        }

        public bool sumrStock(int cantidad, int id_automovil)
        {
            return obj_Factu.sumarStock(cantidad, id_automovil);
        }


        public int obtenerCorrelativo()
        {
            return obj_Factu.obtenerCorrelativo();
        }

        public bool registrar(Factura facturi, DataTable detalle_factu, out string mensaje)
        {
            return obj_Factu.RegistrarFactura(facturi, detalle_factu, out mensaje);
        }

    }
}
