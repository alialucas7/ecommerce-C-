using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int id_venta { get; set; }
        public Usuario objUsuario { get; set; }
        public TipoFactura objTipoFact { get; set; }
        public string dniCliente { get; set; }
        public string nameCliente { get; set; }
        public float montoPago { get; set; }
        public float montoCambio { get; set; }
        public float montoTotal { get; set; }
        public string fechaRegistro { get; set; }
    }
}
