using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public Rol obRol{ get; set; }
        public string dni{ get; set; }
        public string name{ get; set; }
        public string apellido{ get; set; }
        public string email{ get; set; }
        public string telefono { get; set; }
        
        public bool state{ get; set; }
        public string feharegistro { get; set; }
        public string pasword    { get; set; }
    }
}
