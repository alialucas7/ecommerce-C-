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
    public partial class frmVisualizarProductos_Administrador__Sucursal : Form
    {
        Usuario useerrr;
        public frmVisualizarProductos_Administrador__Sucursal(Usuario p_user)
        {
            InitializeComponent();
            useerrr = p_user;
        }

        private void frmVisualizarProductos_Administrador__Sucursal_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            //Oculta la funcion de eliminar a usuarios no autorizados
            if (useerrr.obRol.id_rol != 2)
            {
                label1.Visible = false;
                txtPatente.Visible = false;
                btnEliminar.Visible = false;
            }

            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Producto_Sucursal> autos = new CN_Producto__Sucursal().Listar(useerrr);

            foreach (Producto_Sucursal item in autos)
            {
                //Este if es para que me muestre solo los autos en stock
                if (item.stock > 0)
                {
                    dataGridProduct.Rows.Add(new object[] {"",useerrr.id_sucursal, item.objetoAuto.id_automovil,
                    item.objetoAuto.objMarcaa.id_marca,item.objetoAuto.objMarcaa.descripcionMarca,
                    item.objetoAuto.objModeloo.id_modelo,item.objetoAuto.objModeloo.descripcionModel,
                    item.objetoAuto.patente,item.objetoAuto.precio,

                    item.objetoAuto.estado == true ? 1:0,
                    item.objetoAuto.nPuertas,item.objetoAuto.color,item.objetoAuto.añoFabricacion,item.objetoAuto.descripcionAuto,
                    item.stock
                    });
                }
                
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
            txtPatente.Text = "";
            btnEliminar.Enabled = false;
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


          
            //Si se hace click =>
            if (dataGridProduct.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    btnEliminar.Enabled = true;
                    textBox1.Text = indice.ToString();
                    txID.Text = dataGridProduct.Rows[indice].Cells["ID"].Value.ToString();


                    txtPatente.Text = dataGridProduct.Rows[indice].Cells["patente"].Value.ToString();

                  
                }
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Producto_Sucursal autoDeautoborra= new Producto_Sucursal()
            {
                objetoAuto = new Automovil() { id_automovil = Convert.ToInt32(txID.Text) },
                objetoSucursal = new Sucursal() { id_sucursal = useerrr.id_sucursal}
            };

            CN_Producto__Sucursal autoDeleted = new CN_Producto__Sucursal();
            int bandera = autoDeleted.bajaProductoSucursal(autoDeautoborra, out Mensaje);

            if (bandera == 1)
            {
                MessageBox.Show("El autmovil se elimino de la sucursal");
                dataGridProduct.Rows.RemoveAt(Convert.ToInt32(textBox1.Text));
                btnEliminar.Enabled = false;
                txtPatente.Text = "";
            }
            else MessageBox.Show(Mensaje.ToString());
        }
    }
}
