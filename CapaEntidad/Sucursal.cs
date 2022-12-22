using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sucursal
    {
        public int id_sucursal{ get; set; }
        public Localidad objLocalidad { get; set; }
        public Provincia objProvincia { get; set; }
        public Pais objPais { get; set; }
        public string descripcion { get; set; }
        public int piso { get; set; }
    }
}

