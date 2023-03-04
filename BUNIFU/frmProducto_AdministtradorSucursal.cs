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
    public partial class frmProducto_AdministtradorSucursal : Form
    {
        Usuario usserSucursal;
        public frmProducto_AdministtradorSucursal(Usuario p_usser)
        {
            InitializeComponent();
            usserSucursal = p_usser;
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridProduct.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                
                int indice = e.RowIndex;
                if (indice >= 0)
                {

                    cD_Button1.Enabled = true;
                    userControl11.ForeColor = Color.Black;
                    textBox1.Text = dataGridProduct.Rows[indice].Cells["ID"].Value.ToString();
                    userControl11.Texts = dataGridProduct.Rows[indice].Cells["marca"].Value.ToString();
                    userControl12.Texts = dataGridProduct.Rows[indice].Cells["modelo"].Value.ToString();
                    userControl13.Texts = dataGridProduct.Rows[indice].Cells["color"].Value.ToString();
                    userControl14.Texts = dataGridProduct.Rows[indice].Cells["descripcion"].Value.ToString();

                    switch (dataGridProduct.Rows[indice].Cells["color"].Value.ToString())
                    {
                        case "Blanco":
                            label1.ImageIndex = 1;
                            break;

                        case "Blanco Perla":
                            label1.ImageIndex = 4;
                            break;

                        case "Negro Mate":
                            label1.ImageIndex = 0;
                            break;

                        case "Negro":
                            label1.ImageIndex = 3;
                            break;

                        case "Azul Electrico":
                            label1.ImageIndex = 2;
                            break;
                    }
                }
            }
            
        }

        private void frmProducto_AdministtradorSucursal_Load(object sender, EventArgs e)
        {
            

            label1.ImageIndex = -1;
            cD_Button1.Enabled = false;

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

            txID.Text = "0";

            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Automovil> autos = new CN_Productos().Listar();

            foreach (Automovil item in autos)
            {
                dataGridProduct.Rows.Add(new object[] {"",item.id_automovil,
                item.objMarcaa.id_marca,item.objMarcaa.descripcionMarca,
                item.objModeloo.id_modelo,item.objModeloo.descripcionModel,
                item.patente,item.precio,

                item.estado == true ? 1:0,
                item.nPuertas,item.color,item.añoFabricacion,item.descripcionAuto
                });
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            userControl11.Texts = "";
            userControl12.Texts = "";
            userControl13.Texts = "";
            userControl14.Texts = "";
            label1.ImageIndex = -1;
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

        private void cD_Button1_Click(object sender, EventArgs e)
        {
            string mensajeE = "Debe seleccionar un stock valido";
            if (numStock.Value < 1)
            {
                MessageBox.Show(mensajeE, "PONE CUIDADOO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                //usserSucursal.id_sucursal;
            }
            else
            {

                
                string mensaje = string.Empty;
                Producto_Sucursal producSucur = new Producto_Sucursal()
                {
                    objetoSucursal = new Sucursal() { id_sucursal = usserSucursal.id_sucursal},
                   objetoAuto = new Automovil() { id_automovil = Convert.ToInt32(textBox1.Text) },
                    
                    stock = Convert.ToInt32(numStock.Value)

                };
                //---------------------------------------------------------------------------------------------------------


                
                    //una ves instanciado mi objeto llamo al procedimiento registrar en CN_Producto

                    int resultado = new CN_Producto__Sucursal().AltaProductoSucursal(producSucur, out mensaje);
                if (resultado != 0)
                {
                    MessageBox.Show("Su Automovil se registro de manera exitosa ;)");
                    cD_Button1.Enabled = false;
                    userControl11.Texts = "";
                    userControl12.Texts = "";
                    userControl13.Texts = "";
                    userControl14.Texts = "";
                    label1.ImageIndex = -1;
                    cD_Button1.Enabled = false;

                }
                //en el caso de que no se pueda dar de alta el usser muestra mensaje de error
                else
                {
                    MessageBox.Show(mensaje);
                    cD_Button1.Enabled = false;
                    userControl11.Texts = "";
                    userControl12.Texts = "";
                    userControl13.Texts = "";
                    userControl14.Texts = "";
                    label1.ImageIndex = -1;
                }










            }
        }
    }
}
