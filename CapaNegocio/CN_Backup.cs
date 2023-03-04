using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;
using System.Data;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Backup
    {
        private CD_Backup backupsito = new CD_Backup();

        public int generarbackup(string consulta, out string mensaje)
        {
            return backupsito.generarBackup(consulta,out mensaje);
        }
    }
}
