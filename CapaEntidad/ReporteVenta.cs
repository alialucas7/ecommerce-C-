using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVenta
    {
        public string fecha_creacion { get; set; }
        public string codigoFactura { get; set; }
        public string monto_Total { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string dni_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string descripcionMarca { get; set; }
        public string descripcionModelo { get; set; }
        public string precioVenta { get; set; }
        public string Cantidad { get; set; }
        public string Subtotal { get; set; }
    }
}
