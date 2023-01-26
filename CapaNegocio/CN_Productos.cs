using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Prouductos autito= new CD_Prouductos();

        public List<Automovil> Listar()
        {
            return autito.Listar();
        }


        public int Registrar(Automovil auto, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/
          

            if (Mensaje == string.Empty) return autito.Registrar(auto, out Mensaje);
            else return 0;
        }

        public int Editar(Automovil auto, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/
          

            if (Mensaje == string.Empty) return autito.Editar(auto, out Mensaje);
            else return 0;
        }


        public int Eliminar(Automovil auto, out string Mensaje)
        {
            return autito.Eliminar(auto, out Mensaje);
        }
    }
}
