using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        
        public int Registrar(Usuario usuario, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/
            if ((usuario.name == "") || (usuario.apellido == ""))
            {
                Mensaje += "Es necesario completar su nombre completo\n";
            }
            if (usuario.dni == "")
            {
                Mensaje += "Es necesario ingresar su documento para poder loguearse\n";
            }
            if (usuario.email == "")
            {
                Mensaje += "Es necesario ingresar su correo pa\n";
            }
            if (usuario.pasword == "")
            {
                Mensaje += "Es necesario que ponga una contraseña para poder loguearse\n";
            }

            if (Mensaje == string.Empty) return objcd_usuario.Registrar(usuario, out Mensaje);
            else return 0;
        }




        public int Editar(Usuario usuario, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/
            if ((usuario.name == "") || (usuario.apellido == ""))
            {
                Mensaje += "Es necesario completar su nombre completo\n";
            }
            if (usuario.dni == "")
            {
                Mensaje += "Es necesario ingresar su documento para poder loguearse\n";
            }
            if (usuario.email == "")
            {
                Mensaje += "Es necesario ingresar su correo pa\n";
            }
            if (usuario.pasword == "")
            {
                Mensaje += "Es necesario poner una contraseña para despues loguearse\n";
            }

            if (Mensaje == string.Empty) return objcd_usuario.Editar(usuario, out Mensaje);
            else return 0;
        }

        public int Eliminar(Usuario usuario, out string Mensaje)
        {
            return objcd_usuario.Eliminar(usuario, out Mensaje);
        }



    }
}
