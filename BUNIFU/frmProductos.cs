using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using BUNIFU.Utilidades;
using Bunifu.Framework.UI;

namespace BUNIFU
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            /* me trae la consulta en mi BD y muestra en el combobox*/
            List<Sucursal> listaSucursal1 = new CN_Sucursal().Listar();


            

                /*Me muestra en el combobox todas las sucursales que hay*/
                foreach (Sucursal item in listaSucursal1)
                {
                    comboSucur.Items.Add(new OpcionCombobox() { valor = item.id_sucursal, Texto = item.descripcion
                    +","+item.objLocalidad.descripcionLocal+" ("+item.objProvincia.descripcionPro+","+
                    item.objPais.descripcionPais+")"
                    });
                }
                comboSucur.DisplayMember = "Texto";
                comboSucur.ValueMember = "valor";
                
        }
    }
}
