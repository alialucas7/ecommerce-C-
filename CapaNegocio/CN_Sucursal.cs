using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Sucursal
    {
        private CD_Sucursal objcd_sucur = new CD_Sucursal();

        public List<Sucursal> Listar()
        {
            return objcd_sucur.Listar();
        }

    }
}
