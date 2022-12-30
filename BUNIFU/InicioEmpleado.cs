using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CapaNegocio;
using CapaEntidad;
namespace BUNIFU
{
    public partial class InicioEmpleado : Form
    {
        //para cargar el usuario que se a logueado
        public Usuario usuarioActual;
        public InicioEmpleado(Usuario objUsser)
        {
            InitializeComponent();
            usuarioActual = objUsser;
            
            
        }
    }
}
