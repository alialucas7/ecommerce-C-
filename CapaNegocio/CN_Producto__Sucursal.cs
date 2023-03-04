using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapadeDatos;

namespace CapaNegocio
{
    
    public class CN_Producto__Sucursal
    {
        private CD_ProductoSucursal producSucur = new CD_ProductoSucursal();

        /*Levanat los producto en cada sucursal*/
        public List<Producto_Sucursal> Listar(Usuario usuarioID)
        {
            return producSucur.Listar(usuarioID);
        }


        public int AltaProductoSucursal(Producto_Sucursal objeto, out string Mensaje)
        {
            Mensaje = string.Empty;

            /*Validaiones correspondientes a los campos*/


            if (Mensaje == string.Empty) return producSucur.AltaProduct(objeto, out Mensaje);
            else return 0;
        }
    }
}
