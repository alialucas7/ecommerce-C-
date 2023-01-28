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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBox2.Text = modal._Automovil.id_automovil.ToString();
                    txtPatent.Text = modal._Automovil.patente;
                    string descrip = modal._Automovil.objModeloo.descripcionModel;
                    txtAuto.Text = modal._Automovil.objMarcaa.descripcionMarca + " " +descrip;
                    txprice.Text = modal._Automovil.precio.ToString("0.00");
                    txStok.Text = modal._Automovil.stock.ToString();
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
                Automovil auto = new CN_Productos().Listar().Where(p => p.patente == txtPatent.Text && p.estado == true).FirstOrDefault();

                if (auto != null)
                {
                    txtPatent.BackColor = Color.Honeydew;
                    textBox2.Text = auto.id_automovil.ToString();
                    txtAuto.Text = auto.objMarcaa.descripcionMarca+ ", " + auto.objModeloo.descripcionModel;
                    txprice.Text = auto.precio.ToString();
                    txStok.Text = auto.stock.ToString();
                    numericUpDown1.Value = 1;
                }
                else
                {
                    //txtPatent.BackColor = Color.Honeydew;
                    textBox2.Text = "0";
                    txtAuto.Text = "";
                    txprice.Text = "";
                    txStok.Text = auto.stock.ToString();
                }
            }
        }

        //Boton de agregar
        private void iconButton2_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existente = false;

            if (int.Parse(textBox2.Text) == 0)
            {
                MessageBox.Show("Desea seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                dataGridventas.Rows.Add(new object[]
                {   "",
                    textBox2.Text,
                    txtAuto.Text,
                    precio.ToString("0.00"),
                    numericUpDown1.Value.ToString(),
                    (numericUpDown1.Value * precio).ToString("0.00")
                });
                calcualrTotal();
                Limpiar();


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
                    dataGridventas.Rows.RemoveAt(index);
                    calcualrTotal();
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
    }
}
