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

namespace BUNIFU
{
    public partial class frmProductos__Empleado : Form
    {
        Usuario usuarioActuality;
        public frmProductos__Empleado(Usuario p_usser)
        {
            InitializeComponent();
            usuarioActuality = p_usser;
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {


        }

        private void frmProductos__Empleado_Load(object sender, EventArgs e)
        {


            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Producto_Sucursal> autos = new CN_Producto__Sucursal().Listar(usuarioActuality);

            foreach (Producto_Sucursal item in autos)
            {
                dataGridProduct.Rows.Add(new object[] {
                    item.objetoAuto.id_automovil,
                    item.objetoSucursal.id_sucursal,
                    item.objetoAuto.objMarcaa.id_marca,
                    item.objetoAuto.objMarcaa.descripcionMarca,
                    item.objetoAuto.objModeloo.id_modelo,
                    item.objetoAuto.objModeloo.descripcionModel,
                    item.objetoAuto.patente,
                    
                    item.objetoAuto.precio,
                    item.objetoAuto.estado == true ? 1:0,
                    item.objetoAuto.nPuertas,
                    item.objetoAuto.color,
                    item.objetoAuto.añoFabricacion,
                    item.objetoAuto.descripcionAuto,
                    item.stock
                });
            }


            //me permite buscar elementos por categoria en mi datagrid
            foreach (DataGridViewColumn columna in dataGridProduct.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBusqueda.Items.Add(new OpcionCombobox() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            comboBusqueda.DisplayMember = "Texto";
            comboBusqueda.ValueMember = "valor";
            comboBusqueda.SelectedIndex = 4;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombobox)comboBusqueda.SelectedItem).valor.ToString();
            if (dataGridProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridProduct.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Texts.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtBusqueda.Texts = "";
            foreach (DataGridViewRow row in dataGridProduct.Rows) row.Visible = true;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombobox)comboBusqueda.SelectedItem).valor.ToString();
            if (dataGridProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridProduct.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Texts.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            txtBusqueda.Texts = "";
            foreach (DataGridViewRow row in dataGridProduct.Rows) row.Visible = true;
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
