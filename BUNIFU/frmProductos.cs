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
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.White;
            /*esto es para que pueda habiliatr productos mediante mi combobox*/
            comboEstado.Items.Add(new OpcionCombobox() { valor = 1, Texto = "Habilitado" });
            comboEstado.Items.Add(new OpcionCombobox() { valor = 0, Texto = "Inhabilitado" });
            comboEstado.DisplayMember = "Texto";
            comboEstado.ValueMember = "valor";
            //comboEstado.SelectedIndex = 0;


            /* me trae la consulta en mi BD y muestra en el combobox*/
            List<Sucursal> listaSucursal1 = new CN_Sucursal().Listar();

            /*Me muestra en el combobox todas las sucursales que hay*/
            foreach (Sucursal item in listaSucursal1)
            {
                comboSucur.Items.Add(new OpcionCombobox()
                {
                    valor = item.id_sucursal,
                    Texto = item.descripcion
                + "," + item.objLocalidad.descripcionLocal + " (" + item.objProvincia.descripcionPro + "," +
                item.objPais.descripcionPais + ")"
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
                    Texto = item.descripcionMarca

                });
            }
            comboMark.DisplayMember = "Texto";
            comboMark.ValueMember = "valor";


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
                dataGridProduct.Rows.Add(new object[] {"",item.id_automovil,item.id_sucursal.id_sucursal,
                item.objMarcaa.id_marca,item.objMarcaa.descripcionMarca,
                item.objModeloo.id_modelo,item.objModeloo.descripcionModel,
                item.patente,item.precio,
                item.stock,
                item.estado == true ? 1:0,
                item.nPuertas,item.color,item.añoFabricacion,item.descripcionAuto
                });
            }
        }








        /*Muestra los modelos segun la marca que se seleccione en el combobox de marca*/
        private void comboMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Me limpia el combobox
            comboModel.Items.Clear();
            comboModel.Text = "";
            //PARA QUE NO DE ERROR CUADO SE LIMPIAN LOS CAMPOS
            if (comboMark.SelectedIndex != -1)
            {
                int id_marca = Convert.ToInt32(((OpcionCombobox)comboMark.SelectedItem).valor);
                List<Modelo> modelos = new CN_Modelo().Listar(id_marca);

                foreach (Modelo item in modelos)
                {
                    comboModel.Items.Add(new OpcionCombobox()
                    {
                        valor = item.id_modelo,
                        Texto = item.descripcionModel
                    });
                }
                comboModel.DisplayMember = "Texto";
                comboModel.ValueMember = "valor";
            }
            
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnEliminar.Enabled = true;
            //Si se hace click =>
            if (dataGridProduct.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox1.Text = indice.ToString();
                    txID.Text = dataGridProduct.Rows[indice].Cells["ID"].Value.ToString();

                    foreach (OpcionCombobox oc in comboSucur.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridProduct.Rows[indice].Cells["IDsucursal"].Value))
                        {
                            int indiceCombo = comboSucur.Items.IndexOf(oc);
                            comboSucur.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombobox oc in comboMark.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridProduct.Rows[indice].Cells["id_marca"].Value))
                        {
                            int indiceCombo = comboMark.Items.IndexOf(oc);
                            comboMark.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombobox oc in comboModel.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridProduct.Rows[indice].Cells["id_modelo"].Value))
                        {
                            int indiceCombo = comboModel.Items.IndexOf(oc);
                            comboModel.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombobox oc in comboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridProduct.Rows[indice].Cells["state"].Value))
                        {
                            int indiceCombo = comboEstado.Items.IndexOf(oc);
                            comboEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                    txtPatente.ForeColor = Color.Black;
                    txtPatente.Texts = dataGridProduct.Rows[indice].Cells["patente"].Value.ToString();
                    txPatente.Text = dataGridProduct.Rows[indice].Cells["patente"].Value.ToString();

                    txtPrecio.ForeColor = Color.Black;
                    txtPrecio.Texts = dataGridProduct.Rows[indice].Cells["precio"].Value.ToString();
                    txPrice.Text = dataGridProduct.Rows[indice].Cells["precio"].Value.ToString();

                    txtStocke.ForeColor = Color.Black;
                    txtStocke.Texts = dataGridProduct.Rows[indice].Cells["stock"].Value.ToString();
                    txStok.Text = dataGridProduct.Rows[indice].Cells["stock"].Value.ToString();

                    txtAño.ForeColor = Color.Black;
                    txtAño.Texts = dataGridProduct.Rows[indice].Cells["Añof"].Value.ToString();
                    txAñao.Text = dataGridProduct.Rows[indice].Cells["Añof"].Value.ToString();

                    txtColor.ForeColor = Color.Black;
                    txtColor.Texts = dataGridProduct.Rows[indice].Cells["color"].Value.ToString();
                    txColor.Text = dataGridProduct.Rows[indice].Cells["color"].Value.ToString();

                    txtPuerta.ForeColor = Color.Black;
                    txtPuerta.Texts = dataGridProduct.Rows[indice].Cells["nPuerta"].Value.ToString();
                    txDor.Text = dataGridProduct.Rows[indice].Cells["nPuerta"].Value.ToString();

                    txtdescrip.ForeColor = Color.Black;
                    txtdescrip.Texts = dataGridProduct.Rows[indice].Cells["descripcion"].Value.ToString();
                    txDescript.Text = dataGridProduct.Rows[indice].Cells["descripcion"].Value.ToString();
                }
            }
            
        }
        

        private void clean()
        {
            textBox1.Text = "";
            txID.Text = "";
            txtPatente.PalceHolderText = "Patente";
            txtPatente.PalceHolderColor = Color.DarkGray;

            txtPrecio.Texts = "";
            txtPatente.PalceHolderText = "Precio";
            txtPatente.PalceHolderColor = Color.DarkGray;

            txtStocke.Texts = "";
            txtStocke.PalceHolderText = "Stock";
            txtStocke.PalceHolderColor = Color.DarkGray;

            txtAño.Texts = "";
            txtAño.PalceHolderText = "Año Fabricacion";
            txtAño.PalceHolderColor = Color.DarkGray;

            txtColor.Texts = "";
            txtColor.PalceHolderText = "Color";
            txtColor.PalceHolderColor = Color.DarkGray;

            txtPuerta.Texts = "";
            txtPuerta.PalceHolderText = "Puertas";
            txtPuerta.PalceHolderColor = Color.DarkGray;

            txtdescrip.Texts = "";
            txtdescrip.PalceHolderText = "Descripcion .....";
            txtdescrip.PalceHolderColor = Color.DarkGray;
            //limpio tambien los combobox
            comboSucur.SelectedIndex = -1;
            comboMark.SelectedIndex = -1;
            comboModel.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clean();
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

        private void guardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;
            Automovil auto = new Automovil()
            {
                id_automovil = Convert.ToInt32(txID.Text),
                id_sucursal = new Sucursal() { id_sucursal = Convert.ToInt32(((OpcionCombobox)comboSucur.SelectedItem).valor) },
                objMarcaa = new Marca() { id_marca = Convert.ToInt32(((OpcionCombobox)comboMark.SelectedItem).valor), descripcionMarca = ((OpcionCombobox)comboMark.SelectedItem).Texto },
                objModeloo = new Modelo() { objMarca = new Marca() { id_marca = Convert.ToInt32(((OpcionCombobox)comboMark.SelectedItem).valor) }, id_modelo = Convert.ToInt32(((OpcionCombobox)comboModel.SelectedItem).valor), descripcionModel = ((OpcionCombobox)comboModel.SelectedItem).Texto },
                patente = (txtPatente.Texts == "") ? txtPatente.Texts = txPatente.Text : txtPatente.Texts,
                precio = (txtPrecio.Texts == "") ? Convert.ToDecimal(txPrice.Text) : Convert.ToDecimal(txtPrecio.Texts),
                stock = (txtStocke.Texts == "") ? Convert.ToInt32(txStok.Text) : Convert.ToInt32(txtStocke.Texts),
                estado = Convert.ToInt32(((OpcionCombobox)comboEstado.SelectedItem).valor) == 1 ? true : false,
                nPuertas = (txtPuerta.Texts == "") ? Convert.ToInt32(txDor.Text) : Convert.ToInt32(txtPuerta.Texts),


                color = (txtColor.Texts == "") ? txColor.Text : txtColor.Texts,
                añoFabricacion = (txtAño.Texts == "") ? txAñao.Text : txtAño.Texts,
                descripcionAuto = (txtdescrip.Texts == "") ? txDescript.Text : txtdescrip.Texts,


            };
            //---------------------------------------------------------------------------------------------------------


            if (auto.id_automovil == 0)
            {
                //una ves instanciado mi objeto llamo al procedimiento registrar en CN_Producto

                int resultado = new CN_Productos().Registrar(auto, out mensaje);
                if (resultado != 0)
                {
                    //cargo los dattos en el datagrid
                    dataGridProduct.Rows.Add(new object[] {"",resultado,
                       (((OpcionCombobox)comboSucur.SelectedItem).valor).ToString(),
                       (((OpcionCombobox)comboMark.SelectedItem).valor).ToString(),
                      (((OpcionCombobox)comboMark.SelectedItem).Texto).ToString(),
                      //Convert.ToInt32(((OpcionCombobox)comboMark.SelectedItem).Texto),
                      (((OpcionCombobox)comboModel.SelectedItem).valor).ToString(),
                      (((OpcionCombobox)comboModel.SelectedItem).Texto).ToString(),
                      txtPatente.Texts,
                      txtPrecio.Texts,
                      txtStocke.Texts,
                      Convert.ToInt32(((OpcionCombobox)comboEstado.SelectedItem).valor),
                      txtPuerta.Texts,txtColor.Texts,txtAño.Texts,
                      txtdescrip.Texts

                    });
                    clean();
                }
                //en el caso de que no se pueda dar de alta el usser muestra mensaje de error
                else MessageBox.Show(mensaje);
            }
            else
            { 
            /*si ya esta registrado se procedera a editarlo*/
            int resultado = new CN_Productos().Editar(auto, out mensaje);
            if (resultado == 1)
            {
                //procede a modificar los datos del datagrid
                DataGridViewRow row = dataGridProduct.Rows[Convert.ToInt32(textBox1.Text)];
                 //row.Cells["S"].Value = "";
                row.Cells["id"].Value = txID.Text;
                row.Cells["IDsucursal"].Value = ((OpcionCombobox)comboSucur.SelectedItem).valor;
                row.Cells["id_marca"].Value = ((OpcionCombobox)comboMark.SelectedItem).valor;
                row.Cells["marca"].Value = ((OpcionCombobox)comboMark.SelectedItem).Texto.ToString();
                row.Cells["id_modelo"].Value = ((OpcionCombobox)comboModel.SelectedItem).valor;
                row.Cells["modelo"].Value = ((OpcionCombobox)comboMark.SelectedItem).Texto;
                row.Cells["patente"].Value = auto.patente;
                row.Cells["precio"].Value = auto.precio;
                row.Cells["stock"].Value = auto.stock;
                row.Cells["state"].Value = auto.estado;
                row.Cells["nPuerta"].Value = auto.nPuertas;
                row.Cells["color"].Value = auto.color;
                row.Cells["Añof"].Value = auto.añoFabricacion;
                row.Cells["descripcion"].Value = auto.descripcionAuto;
                    
                clean();
            }
            else MessageBox.Show(mensaje);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txID.Text) != 0)
            {
                if (MessageBox.Show("Deseas eliminar el usser pa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Automovil autoDeleted = new Automovil()
                    {
                        id_automovil = Convert.ToInt32(txID.Text)
                    };


                    int respuesta = new CN_Productos().Eliminar(autoDeleted, out mensaje);

                    if (respuesta == 1)
                    {
                        //remuevo la fila del datagrid
                        dataGridProduct.Rows.RemoveAt(Convert.ToInt32(textBox1.Text));
                        clean();
                    }
                    else MessageBox.Show(mensaje, "Tal ves no", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            btnEliminar.Enabled = false;
        }

        private void labelSuxur_Click(object sender, EventArgs e)
        {

        }

        private void comboSucur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
