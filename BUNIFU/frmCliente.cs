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

namespace BUNIFU
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si se hace click =>
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {

                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox6.Text = indice.ToString();
                    textId.Text = dataGridView1.Rows[indice].Cells["id_cliente"].Value.ToString();

                    txtDocument.ForeColor = Color.Black;
                    txtDocument.Texts = dataGridView1.Rows[indice].Cells["DNI"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[indice].Cells["DNI"].Value.ToString();

                    txtNombre.ForeColor = Color.Black;
                    txtNombre.Texts = dataGridView1.Rows[indice].Cells["Nombre"].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[indice].Cells["Nombre"].Value.ToString();

                    txtApellido.ForeColor = Color.Black;
                    txtApellido.Texts = dataGridView1.Rows[indice].Cells["Apellido"].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[indice].Cells["Apellido"].Value.ToString();

                    txtEmail.ForeColor = Color.Black;
                    txtEmail.Texts = dataGridView1.Rows[indice].Cells["Email"].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[indice].Cells["Email"].Value.ToString();

                    txtTelefono.ForeColor = Color.Black;
                    txtTelefono.Texts = dataGridView1.Rows[indice].Cells["Telefono"].Value.ToString();
                    textBox5.Text = dataGridView1.Rows[indice].Cells["Telefono"].Value.ToString();

                    /*Metodos para cargar los combobox segun informacion almacenada*/

                    //combobox de estado
                    foreach (OpcionCombobox oc in comboBox1.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["Estado"].Value))
                        {
                            int indiceCombo = comboBox1.Items.IndexOf(oc);
                            comboBox1.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'bD_dealershipDataSet.Usuario' Puede moverla o quitarla según sea necesario.

            /*Seba si te da error comenta la linea de abajo y descomenta esta
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.J.SebastianOrtiz);
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.Usuario);*/

            /*esto es para que pueda habiliatr ussser mediante mi combobox*/
            //comboBox2
            comboBox1.Items.Add(new OpcionCombobox() { valor = 1, Texto = "Habilitado" });
            comboBox1.Items.Add(new OpcionCombobox() { valor = 0, Texto = "Inhabilitado" });
            comboBox1.DisplayMember = "Texto";
            comboBox1.ValueMember = "valor";
            comboBox1.SelectedIndex = 0;

            /* me trae los datos de la BD en la columna rol y muestra en el combobox*/
            List<Rol> listaRol1 = new CN_Rol().Listar();

            //me permite uscar elementos por categoria en mi datagrid
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBox2.Items.Add(new OpcionCombobox() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBox2.DisplayMember = "Texto";
            comboBox2.ValueMember = "valor";
            comboBox2.SelectedIndex = 1;

            textId.Text = "0";

            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                dataGridView1.Rows.Add(new object[] {"",item.id_cliente,item.dni,item.nombre,item.apellido,item.email,item.telefono,
            item.estado == true ? 1 : 0,
            item.estado == true ? "Activo" : "No Activo"
            });

            }
        }

        /*Metodolimpiador de campos*/
        private void clean()
        {
            textId.Text = "";
            txtDocument.Texts = "";
            txtDocument.PalceHolderText = "Documento";
            txtDocument.PalceHolderColor = Color.DarkGray;

            txtNombre.Texts = "";
            txtNombre.PalceHolderText = "Nombre";
            txtNombre.PalceHolderColor = Color.DarkGray;

            txtApellido.Texts = "";
            txtApellido.PalceHolderText = "Apellido";
            txtApellido.PalceHolderColor = Color.DarkGray;

            txtEmail.Texts = "";
            txtEmail.PalceHolderText = "Email";
            txtEmail.PalceHolderColor = Color.DarkGray;

            txtTelefono.Texts = "";
            txtTelefono.PalceHolderText = "Telefono";
            txtTelefono.PalceHolderColor = Color.DarkGray;

        }

        //Botón Guardar
        private void cD_Button1_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Cliente cliente = new Cliente()
            {
                id_cliente = Convert.ToInt32(textId.Text),
                dni = (txtDocument.Texts == "") ? txtDocument.Texts = textBox1.Text : txtDocument.Texts,
                nombre = (txtNombre.Texts == "") ? txtNombre.Texts = textBox2.Text : txtNombre.Texts,
                apellido = (txtApellido.Texts == "") ? txtApellido.Texts = textBox3.Text : txtApellido.Texts,
                email = (txtApellido.Texts == "") ? txtEmail.Texts = textBox4.Text : txtEmail.Texts,
                telefono = (txtTelefono.Texts == "") ? txtTelefono.Texts = textBox5.Text : txtTelefono.Texts,
                estado = Convert.ToInt32(((OpcionCombobox)comboBox1.SelectedItem).valor) == 1 ? true : false,
            };
            //---------------------------------------------------------------------------------------------------------

            /*si el usuario a dar de alta es new => lo registra*/
            if (cliente.id_cliente == 0)
            {
                //una ves instanciado mi objeto llamo al procedimiento registrar en CN_Cliente

                int idGenerado = new CN_Cliente().Registrar(cliente, out mensaje);
                if (idGenerado != 0)
                {
                    //cargo los dattos en el datagrid
                    dataGridView1.Rows.Add(new object[] { "",idGenerado,
                    txtDocument.Texts,txtNombre.Texts,txtApellido.Texts,txtEmail.Texts,
                    txtTelefono.Texts,((OpcionCombobox)comboBox1.SelectedItem).valor

                    });
                    clean();
                }
                //en el caso de que no se pueda dar de alta el usser muestra mensaje de error
                else MessageBox.Show(mensaje);
            }
            else /*si ya esta registrado se procedera a editarlo*/
            {
                int resultado = new CN_Cliente().Editar(cliente, out mensaje);
                if (resultado == 1)
                {
                    //procede a modificar los datos del datagrid
                    DataGridViewRow row = dataGridView1.Rows[Convert.ToInt32(textBox6.Text)];
                    // row.Cells["S"].Value = "";
                    row.Cells["Id_Cliente"].Value = textId.Text;
                    row.Cells["DNI"].Value = cliente.dni;
                    row.Cells["Nombre"].Value = cliente.nombre;
                    row.Cells["Apellido"].Value = cliente.apellido;
                    row.Cells["Email"].Value = cliente.email;
                    row.Cells["Telefono"].Value = cliente.telefono;
                    row.Cells["Estado"].Value = ((OpcionCombobox)comboBox1.SelectedItem).valor;
                    clean();
                }
                else MessageBox.Show(mensaje);
            }
        }

        //Botón Limpiar
        private void cD_Button3_Click(object sender, EventArgs e)
        {
            clean();
        }

        //Botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombobox)comboBox2.SelectedItem).valor.ToString();
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(userControl12.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }

        }

        //Botón Eliminar
        private void cD_Button2_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente clienteELiminar = new Cliente()
                    {
                        id_cliente = Convert.ToInt32(textId.Text)
                    };


                    bool respuesta = new CN_Cliente().Eliminar(clienteELiminar, out mensaje);

                    if (respuesta)
                    {
                        //remuevo la fila del datagrid
                        dataGridView1.Rows.RemoveAt(Convert.ToInt32(textBox6.Text));
                        clean();
                    }
                    else MessageBox.Show(mensaje, "Tal ves no", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //Limpiar Buscador
        private void btnClean_Click(object sender, EventArgs e)
        {
            userControl12.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
        }

        private void userControl12__Textchanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cD_ComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cD_ComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDocument__Textchanged(object sender, EventArgs e)
        {

        }

        private void txtName__Textchanged(object sender, EventArgs e)
        {

        }

        private void txtEmail__Textchanged(object sender, EventArgs e)
        {

        }

        private void cD_ComboBox1_OnSelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void cD_ComboBox1_OnSelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void txtIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cD_ComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cD_ComboBox4_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl12__Textchanged_1(object sender, EventArgs e)
        {

        }

        private void cD_Button1_Click(object sender, EventArgs e)
        {

        }

        private void cD_Button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDocument__Textchanged_1(object sender, EventArgs e)
        {

        }
    }
}
