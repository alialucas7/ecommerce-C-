using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapadeDatos;


namespace CapaNegocio
{
    public class CN_Modelo
    {


        private CD_Modelo objcd_model = new CD_Modelo();

        public List<Modelo> Listar(int id_marca)
        {
            return objcd_model.Listar(id_marca);
        }

    }
}
