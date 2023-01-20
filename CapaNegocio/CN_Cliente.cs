using CapadeDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }


        public int Registrar(Cliente Cliente, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/
            if ((Cliente.nombre == "") || (Cliente.apellido == ""))
            {
                Mensaje += "Es necesario completar su nombre completo\n";
            }
            if (Cliente.dni == "")
            {
                Mensaje += "Es necesario ingresar su documento para poder loguearse\n";
            }
            if (Cliente.email == "")
            {
                Mensaje += "Es necesario ingresar su correo pa\n";
            }
            if (Cliente.email == "")
            {
                Mensaje += "Es necesario ingresar su dirección de correo\n";
            }

            if (Mensaje == string.Empty) return objcd_Cliente.Registrar(Cliente, out Mensaje);
            else return 0;
        }

        public int Editar(Cliente Cliente, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/
            if ((Cliente.nombre == "") || (Cliente.apellido == ""))
            {
                Mensaje += "Es necesario completar su nombre completo\n";
            }
            if (Cliente.dni == "")
            {
                Mensaje += "Es necesario ingresar su documento para poder loguearse\n";
            }
            if (Cliente.email == "")
            {
                Mensaje += "Es necesario ingresar su correo pa\n";
            }
            if (Cliente.email == "")
            {
                Mensaje += "Es necesario ingresar su dirección de correo\n";
            }

            if (Mensaje == string.Empty) return objcd_Cliente.Editar(Cliente, out Mensaje);
            else return 0;
        }

        public bool Eliminar(Cliente Cliente, out string Mensaje)
        {
            return objcd_Cliente.Eliminar(Cliente, out Mensaje);
        }
    }
}
