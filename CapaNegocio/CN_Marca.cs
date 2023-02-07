using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapadeDatos;

namespace CapaNegocio
{
    public class CN_Marca
    {


        private CD_Marca objcd_Marca= new CD_Marca();

        public List<Marca> Listar()
        {
            return objcd_Marca.Listar();
        }
    }
}
