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
        public frmProductos__Empleado()
        {
            InitializeComponent();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {


        }

        private void frmProductos__Empleado_Load(object sender, EventArgs e)
        {


            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Automovil> autos = new CN_Productos().Listar();

            foreach (Automovil item in autos)
            {
                dataGridProduct.Rows.Add(new object[] {item.id_automovil,
                item.objMarcaa.id_marca,item.objMarcaa.descripcionMarca,
                item.objModeloo.id_modelo,item.objModeloo.descripcionModel,
                item.patente,item.precio,
                
                item.estado == true ? 1:0,
                item.nPuertas,item.color,item.añoFabricacion,item.descripcionAuto
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
    }
}
