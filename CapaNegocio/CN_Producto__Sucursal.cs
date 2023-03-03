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

        public List<Producto_Sucursal> Listar(Usuario usuarioID)
        {
            return producSucur.Listar(usuarioID);
        } 
    }
}
