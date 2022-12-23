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
        public Modelo objModeloo{ get; set; }
        public Marca objMarcaa{ get; set; }
        public int patente { get; set; }
        public float precio{ get; set; }
        public int stock { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }
        public int nPuertas { get; set; }
        public string color { get; set; }
        public string añoFabricacion { get; set; }

    }
}

