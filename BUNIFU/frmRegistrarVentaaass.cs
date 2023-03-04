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
    public partial class frmRegistrarVentaaass : Form
    {

        private Usuario _Usuario;

        public frmRegistrarVentaaass(Usuario objUss = null)
        {
            _Usuario = objUss;
            InitializeComponent();
        }


        private void frmRegistrarVentaaass_Load(object sender, EventArgs e)
        {
            btnCar.Enabled = false;
            comboFactura.Items.Add(new OpcionCombobox() { valor = 1, Texto = "A"});
            comboFactura.Items.Add(new OpcionCombobox() { valor = 2, Texto = "B" });
            comboFactura.Items.Add(new OpcionCombobox() { valor = 3, Texto = "C" });
            comboFactura.DisplayMember = "Texto";
            comboFactura.ValueMember = "valor";
            comboFactura.SelectedIndex = 2;

            txtFechita.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox2.Text = "0";
            textBoxpagacon.Text = "";
            textBoxcambio.Text = "";
            textBoxpagar.Text = "0";
            numericUpDown1.Value = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new md_Cliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtDNI.Text = modal._Cliente.dni;
                    txtNamei.Text = modal._Cliente.nombre;
                    textape.Text = modal._Cliente.apellido;


                }
                else txtDNI.Select();
            }
        }

        /*Metodo que me carga los texbox correspondiente, segn auto elegido, (RECIBE OBJETO DEL MODAL)*/
        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos(_Usuario))
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBox2.Text = modal._PS.objetoAuto.id_automovil.ToString();
                    txtPatent.Text = modal._PS.objetoAuto.patente;
                    string descrip = modal._PS.objetoAuto.objModeloo.descripcionModel;
                    txtAuto.Text = modal._PS.objetoAuto.objMarcaa.descripcionMarca + " " +descrip;
                    txprice.Text = modal._PS.objetoAuto.precio.ToString("0.00");
                    txStok.Text = modal._PS.stock.ToString();
                    numericUpDown1.Select();
                }
                else txtPatent.Select();
            }
        }

        //Metodo para cargar los datos solo ingresando el patente
        private void txtPatent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto_Sucursal auto = new CN_Producto__Sucursal().Listar(_Usuario).Where(p => p.objetoAuto.patente == txtPatent.Text && p.objetoAuto.estado == true).FirstOrDefault();

                if (auto != null)
                {
                    txtPatent.BackColor = Color.Honeydew;
                    textBox2.Text = auto.objetoAuto.id_automovil.ToString();
                    txtAuto.Text = auto.objetoAuto.objMarcaa.descripcionMarca+ ", " + auto.objetoAuto.objModeloo.descripcionModel;
                    txprice.Text = auto.objetoAuto.precio.ToString();
                    txStok.Text = auto.stock.ToString();
                    numericUpDown1.Value = 1;
                }
                else
                {
                    //txtPatent.BackColor = Color.Honeydew;
                    textBox2.Text = "0";
                    txtAuto.Text = "";
                    txprice.Text = "";
                  //  txStok.Text = auto.stock.ToString();
                }
            }
        }

        //Boton de agregar
        private void iconButton2_Click(object sender, EventArgs e)
        {
            btnCar.Enabled = true;
            decimal precio = 0;
            bool producto_existente = false;

            if (int.Parse(textBox2.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnCar.Enabled = false;
                return;
            }
            if (!decimal.TryParse(txprice.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecta", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txprice.Select();
                return;
            }

            /*Metodo que verifica el control del stocck*/
            if (Convert.ToInt32(txStok.Text) < Convert.ToInt32(numericUpDown1.Value.ToString()))
            {
                MessageBox.Show("La cantidad ingresada no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            /*Metedo que verifica si el producto existe*/
            foreach (DataGridViewRow fila in dataGridventas.Rows)
            {
                if (fila.Cells["id_au"].Value.ToString() == textBox2.Text)
                {
                    producto_existente = true;
                    break;
                }
            }

            
            if (!producto_existente)
            {

                //string mensaje = string.Empty;
                /**Procedo a llamar el metodo que lo cree en la cpa negocio*/
                bool respuesta = new CN_Producto__Sucursal().restarStock( //Los parametros de la funcion obtengo de los valores ingresado por el usser
                    Convert.ToInt32(numericUpDown1.Value.ToString()),
                    Convert.ToInt32(textBox2.Text),
                    _Usuario.id_sucursal
                );

               if(respuesta)
               {
                    dataGridventas.Rows.Add(new object[]
                    {       "",
                            textBox2.Text,
                            txtAuto.Text,
                            precio.ToString("0.00"),
                            (numericUpDown1.Value * precio).ToString("0.00"),
                            numericUpDown1.Value.ToString()
                            
                    });
                    calcualrTotal();
                    Limpiar();
               }
            }



            

        }
        private void calcualrTotal()
        {
            decimal total = 0;
            if (dataGridventas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridventas.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["subTotal"].Value.ToString());
                }

            }
            textBoxpagar.Text = total.ToString("0.00");
        }


        private void Limpiar()
        {
                    textBox2.Text = "";
                    txtPatent.Text = "";
                    txtAuto.Text = "";
                    txprice.Text = "";
                    txStok.Text = "";
                    numericUpDown1.Value = 1;
        }

        private void dataGridventas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridventas.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    /*Hace lo mismo procedimiento cuando agrega un producto, solo alrreves*/
                    bool respuesta = new CN_Producto__Sucursal().sumrStock( //Los parametros de la funcion obtengo de los valores ingresado por el usser
                        Convert.ToInt32(dataGridventas.Rows[index].Cells["cantidad"].Value.ToString()),
                        Convert.ToInt32(dataGridventas.Rows[index].Cells["id_au"].Value.ToString()),
                        _Usuario.id_sucursal

                    );
                    if (respuesta)
                    {
                        dataGridventas.Rows.RemoveAt(index);
                        calcualrTotal();
                    }
                    
                }
            }
        }

        //Se valida el texbox precio
        private void txprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else
            { 
                if(txprice.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") e.Handled = true;
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") e.Handled = false;
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        //Se valida tambien el texbox paaga con
        private void textBoxpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else
            {
                if (textBoxpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") e.Handled = true;
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") e.Handled = false;
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }




        private void calcularCambio()
        {
            if(textBoxpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal(textBoxpagar.Text);
            if(textBoxpagacon.Text.Trim() == ".")
            {
                textBoxpagacon.Text = "0";
            }
            if (decimal.TryParse(textBoxpagacon.Text.Trim(), out pagaCon))
            {
                if (pagaCon < total)
                {
                    textBoxcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagaCon - total;
                    textBoxcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void textBoxpagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) calcularCambio();
        }









        public bool validaciones()
        {
            bool bandera = false;
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            
            if (!(string.IsNullOrEmpty(txtDNI.Text))) valor1 = 1; 
            if (!(string.IsNullOrEmpty(txtNamei.Text))) valor2 = 1;
            if (!(string.IsNullOrEmpty(textape.Text))) valor3 = 1;
            if ((valor1 == 1) && (valor2 == 1) && (valor3 == 1))
            { 
                bandera = true;
            }
            return bandera;
        }

        /*Boton de agregar la compra*/
        private void btnCar_Click(object sender, EventArgs e)
        {
            if (validaciones() == true)
            {
                DataTable detalle_Factura = new DataTable();
                detalle_Factura.Columns.Add("id_automovil", typeof(int));
                detalle_Factura.Columns.Add("precioVenta", typeof(decimal));
                
                detalle_Factura.Columns.Add("subTotal", typeof(decimal));
                detalle_Factura.Columns.Add("cantidad", typeof(int));

                foreach (DataGridViewRow row in dataGridventas.Rows)
                {
                    detalle_Factura.Rows.Add(new object[] {
                        row.Cells["id_au"].Value.ToString(),
                        row.Cells["precio"].Value.ToString(),
                        row.Cells["subTotal"].Value.ToString(),
                        row.Cells["cantidad"].Value.ToString()
                    });
                }



                int id_correlativo = new CN_Factura().obtenerCorrelativo();
                string numeroDoc = string.Format("3264000"+id_correlativo);
                calcularCambio();

                Factura obFactu = new Factura()
                {
                    objUsuario = new Usuario() { id_usuario = _Usuario.id_usuario},
                    objTipoFact = new TipoFactura() {id_tipoFact = Convert.ToInt32( ((OpcionCombobox)comboFactura.SelectedItem).valor) },
                    dniCliente = txtDNI.Text,
                    nameCliente = txtNamei.Text,
                    montoPago = Convert.ToDecimal(textBoxpagacon.Text),
                    montoCambio = Convert.ToDecimal(textBoxcambio.Text),
                    montoTotal = Convert.ToDecimal(textBoxpagar.Text),
                    codigoFactu = Convert.ToInt32(numeroDoc)
                };
                string mensaje = string.Empty;
                bool respuesta = new CN_Factura().registrar(obFactu, detalle_Factura,out mensaje);
                if (respuesta)
                {
                    Limpiar();
                    txtDNI.Text = "";
                    txtNamei.Text = "";
                    textape.Text = "";
                    textBoxpagar.Text = "";
                    textBoxpagacon.Text = "";
                    textBoxcambio.Text = "";

                    //Borra la coleccion del datagrid
                    dataGridventas.Rows.Clear();
                    MessageBox.Show("La venta Se realizo correctamente,\n Su numero de Factura es: "+numeroDoc);
                }
                
            }
            else { MessageBox.Show("Falta agregar el cliente"); }
        }

    }
}
  
 
