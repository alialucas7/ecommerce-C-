﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapadeDatos;

namespace CapaNegocio
{
    public class CN_Rol
    {
        
            private CN_Rol objcd_rol= new CN_Rol();

            public List<Rol> Listar()
            {
                return objcd_rol.Listar();
            }
        }
    
}
