using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleFactura
    {
        public int id_detalle { get; set; }
        public Factura objFacuta { get; set; }
        public Automovil objAuto { get; set; }
        public float precioVenta { get; set; }
        public float subTotal { get; set; }
        public int cantidad { get; set; }
        public string fechaRegistro { get; set; }
    }
}
