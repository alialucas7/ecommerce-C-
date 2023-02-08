using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {
        public int id_venta { get; set; }
        public Usuario objUsuario { get; set; }
        public TipoFactura objTipoFact { get; set; }
        public string dniCliente { get; set; }
        public string nameCliente { get; set; }
        public decimal montoPago { get; set; }
        public decimal montoCambio { get; set; }
        public decimal montoTotal { get; set; }
        public int codigoFactu { get; set; }
        public List<DetalleFactura> oDetalle_Factur { get; set; }
        public string fechaRegistro { get; set; }

    }
}
