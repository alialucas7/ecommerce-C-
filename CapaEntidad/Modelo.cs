using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Modelo
    {
        public int id_modelo{ get; set; }
        public Marca objMarca { get; set; }
        public string descripcion{ get; set; }
    }
}

