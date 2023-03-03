using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto_Sucursal
    {
        public Sucursal objetoSucursal { get; set; },
        public Automovil objetoAuto { get; set; },
        public int stock { get; set; }
    }
}
