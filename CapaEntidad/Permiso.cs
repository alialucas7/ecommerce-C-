using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int id_permiso{ get; set; }
        public Rol objtRol { get; set; }
        public string nameMenu { get; set; }
        public string feharegistro { get; set; }
    }
}
