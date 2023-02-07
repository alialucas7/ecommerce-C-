using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Automovil
    {
        public int id_automovil{ get; set; }
        public Sucursal id_sucursal { get; set; }
        public Marca objMarcaa { get; set; }
        public Modelo objModeloo{ get; set; }
        
        public string patente { get; set; }
        public decimal precio{ get; set; }
        public int stock { get; set; }
        public bool estado { get; set; }
      
        public int nPuertas { get; set; }
        public string color { get; set; }
        public string añoFabricacion { get; set; }
        public string descripcionAuto { get; set; }
        public string fechaReg { get; set; }
    }
}

