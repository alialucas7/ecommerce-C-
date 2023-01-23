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
        //public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
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




            /* me trae la consulta en mi BD y muestra en el combobox*/
            List<Marca> mark = new CN_Marca().Listar();

            /*Me muestra en el combobox todas las marcas que hay*/
            foreach (Marca item in mark)
            {
                comboMark.Items.Add(new OpcionCombobox()
                {
                    valor = item.id_marca,
                    Texto = item.descripcion
                
                });
            }
            comboMark.DisplayMember = "Texto";
            comboMark.ValueMember = "valor";

        }





       


        /*Muestra los modelos segun la marca que se seleccione en el combobox de marca*/
        private void comboMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Me limpia el combobox
            comboModel.Items.Clear();
            
            int id_marca = Convert.ToInt32(((OpcionCombobox)comboMark.SelectedItem).valor);
            List<Modelo> modelos = new CN_Modelo().Listar(id_marca);  

                foreach (Modelo item in modelos)
                {
                    comboModel.Items.Add(new OpcionCombobox()
                    {
                        valor = item.id_modelo,
                        Texto = item.descripcion
                    });
                }
                comboModel.DisplayMember = "Texto";
                comboModel.ValueMember = "valor";
                
        }
    }
}
