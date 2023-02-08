using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUNIFU.Utilidades;
using CapaEntidad;
using CapaNegocio;
using BUNIFU.Modales;

namespace BUNIFU
{
    public partial class frmDetalle_Ventas : Form
    {
        private Usuario _Usuario;

        public frmDetalle_Ventas(Usuario objUss = null)
        {
            _Usuario = objUss;
            InitializeComponent();
        }
    }
}
