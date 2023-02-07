using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Localidad
    {
        public int id_localidad { get; set; }
        public Provincia objProvincia{ get; set; }
        public Pais objPais { get; set; }
        public string descripcionLocal { get; set; }
    }
}
