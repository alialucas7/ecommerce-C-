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
using CapadeDatos;
using BUNIFU.Utilidades;

namespace BUNIFU.Modales
{
    public partial class mdProductos : Form
    {

       public  Producto_Sucursal _PS { get; set; }
        public Usuario usuario;
        public mdProductos(Usuario p_userr)
        {
            InitializeComponent();
            usuario = p_userr;
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

        private void mdProductos_Load(object sender, EventArgs e)
        {
            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Producto_Sucursal> autos = new CN_Producto__Sucursal().Listar(usuario);

            /*Es necesario llamar a esta clase y no a la clase Automovil
             Debido que al empleado solo le interesan los autos que estan
             en su sucursal, si llama a automovil trae todos los autos de todas las sucursales */
             
            foreach (Producto_Sucursal item in autos)
            {
                dataGridProduct.Rows.Add(new object[] {
                    item.objetoAuto.id_automovil,
                    item.objetoAuto.patente,
                    item.objetoAuto.objMarcaa.descripcionMarca,
                    item.objetoAuto.objModeloo.descripcionModel,
                    item.objetoAuto.precio.ToString(),
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
            comboBusqueda.SelectedIndex = 0;
        }

        private void btnBuscar_Click_2(object sender, EventArgs e)
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

        private void btnClean_Click_2(object sender, EventArgs e)
        {
            txtBusqueda.Texts = "";
            foreach (DataGridViewRow row in dataGridProduct.Rows) row.Visible = true;
        }

        /*cada ves que el usuario seleecione el auto, crea un objeto y lo manda a (frmVentas)*/
        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int iRow = e.RowIndex;
            int iClolumna = e.ColumnIndex;

            if (iRow >= 0 && iClolumna >= 0)
            {

                _PS = new Producto_Sucursal()
                {
                    objetoAuto = new Automovil()
                    {
                        id_automovil = Convert.ToInt32(dataGridProduct.Rows[iRow].Cells["id_au"].Value),
                        patente = dataGridProduct.Rows[iRow].Cells["patente"].Value.ToString(),
                        objMarcaa = new Marca() { descripcionMarca = dataGridProduct.Rows[iRow].Cells["Marca"].Value.ToString() },
                        objModeloo = new Modelo() { descripcionModel = dataGridProduct.Rows[iRow].Cells["Modelo"].Value.ToString() },
                        precio = Convert.ToDecimal(dataGridProduct.Rows[iRow].Cells["precio"].Value.ToString()),
                    },
                    objetoSucursal = new Sucursal() { id_sucursal = usuario.id_sucursal},
                    stock = Convert.ToInt32(dataGridProduct.Rows[iRow].Cells["stock"].Value.ToString())
                    };
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}

