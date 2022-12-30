using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol
    {

        public int id_rol { get; set; }
        public string descripcion { get; set; }
        public string fechaRegistro { get; set; }
       
        public int getID()
        {
            return id_rol;
        }
        public void setID(int Pid_rol)
        {
            this.id_rol = Pid_rol;
        }
    }
}
