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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }


        private void userControl12__Textchanged(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {




            // TODO: esta línea de código carga datos en la tabla 'bD_dealershipDataSet.Usuario' Puede moverla o quitarla según sea necesario.

            /*Seba si te da error comenta la linea de abajo y descomenta esta
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.J.SebastianOrtiz);
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.Usuario);*/

            /*esto es para que pueda habiliatr ussser mediante mi combobox*/
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 1, Texto = "Habilitado" });
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 0, Texto = "Inhabilitado" });
            comboBoxState.DisplayMember = "Texto";
            comboBoxState.ValueMember = "valor";
            comboBoxState.SelectedIndex = 0;


            /* me trae los datos de la BD en la columna rol y muestra en el combobox*/
            List<Rol> listaRol1 = new CN_Rol().Listar();

            foreach (Rol item in listaRol1)
            {
                comboBoxRol.Items.Add(new OpcionCombobox() { valor = item.id_rol, Texto = item.descripcion });
            }
            comboBoxRol.DisplayMember = "Texto";
            comboBoxRol.ValueMember = "valor";
            comboBoxRol.SelectedIndex = 2;

            //me permite buscar elementos por categoria en mi datagrid
            foreach (DataGridViewColumn columna in dataGridUsser.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBusqueda.Items.Add(new OpcionCombobox() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            comboBusqueda.DisplayMember = "Texto";
            comboBusqueda.ValueMember = "valor";
            comboBusqueda.SelectedIndex = 1;

            txtIndice.Text = "0";









            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Usuario> listaUsser = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsser)
            {
                dataGridUsser.Rows.Add(new object[] {"",item.id_usuario,item.obRol.id_rol,item.obRol.descripcion,item.dni,item.name,item.apellido,item.email,
                item.telefono,
                item.state == true ? 1:0,
                item.pasword
                });
            }
        }

        /*metodolimpiador de campos*/
        private void clean()
        {
            textBox2.Text = "";
            txtIndice.Text = "";
            txtDocument.PalceHolderText = "Documento";
            txtDocument.PalceHolderColor = Color.DarkGray;

            txtName.Texts = "";
            txtName.PalceHolderText = "Nombre";
            txtName.PalceHolderColor = Color.DarkGray;

            txtApellido.Texts = "";
            txtApellido.PalceHolderText = "Apellido";
            txtApellido.PalceHolderColor = Color.DarkGray;

            txtEmail.Texts = "";
            txtEmail.PalceHolderText = "Email";
            txtEmail.PalceHolderColor = Color.DarkGray;

            txtPasword.Texts = "";
            txtPasword.PalceHolderText = "Contraseña";
            txtPasword.PalceHolderColor = Color.DarkGray;

            txtPhone.Texts = "";
            txtPhone.PalceHolderText = "Telefono";
            txtPhone.PalceHolderColor = Color.DarkGray;
        }


        /*en este metodo lleva los datos del datagrid a los texbox*/
        public void dataGridUsser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //Si se hace click =>
            if (dataGridUsser.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {

                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox2.Text = indice.ToString();
                    txtIndice.Text = dataGridUsser.Rows[indice].Cells["id"].Value.ToString();

                    txtDocument.ForeColor = Color.Black;
                    txtDocument.Texts = dataGridUsser.Rows[indice].Cells["dni"].Value.ToString();
                    txtDocumenPrueba.Text = dataGridUsser.Rows[indice].Cells["dni"].Value.ToString();

                    txtPhone.ForeColor = Color.Black;
                    txtPhone.Texts = dataGridUsser.Rows[indice].Cells["telefono"].Value.ToString();
                    txtprueba.Text = dataGridUsser.Rows[indice].Cells["telefono"].Value.ToString();

                    txtName.ForeColor = Color.Black;
                    txtName.Texts = dataGridUsser.Rows[indice].Cells["name"].Value.ToString();
                    txtnamePrueba.Text = dataGridUsser.Rows[indice].Cells["name"].Value.ToString();

                    txtApellido.ForeColor = Color.Black;
                    txtApellido.Texts = dataGridUsser.Rows[indice].Cells["apellido"].Value.ToString();
                    txtapellidoPrueba.Text = dataGridUsser.Rows[indice].Cells["apellido"].Value.ToString();

                    txtEmail.ForeColor = Color.Black;
                    txtEmail.Texts = dataGridUsser.Rows[indice].Cells["email"].Value.ToString();
                    txtemailPrueba.Text = dataGridUsser.Rows[indice].Cells["email"].Value.ToString();

                    txtPasword.ForeColor = Color.Black;
                    txtPasword.Texts = dataGridUsser.Rows[indice].Cells["pasword"].Value.ToString();
                    txtcontraseñaPrueba.Text = dataGridUsser.Rows[indice].Cells["pasword"].Value.ToString();
                    /*Metodos para cargar los combobox segun informacion almacenada*/

                    //combobox de rol
                    foreach (OpcionCombobox oc in comboBoxRol.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridUsser.Rows[indice].Cells["rolid"].Value))
                        {
                            switch (oc.Texto)
                            {
                                case "Administrador":
                                    comboBoxRol.SelectedIndex = 0;
                                    break;

                                case "Clasico":
                                    comboBoxRol.SelectedIndex = 1;
                                    break;

                                case "Empleado":
                                    comboBoxRol.SelectedIndex = 2;
                                    break;
                            }
                        }
                    }


                    //combobox de estado
                    foreach (OpcionCombobox oc in comboBoxState.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridUsser.Rows[indice].Cells["state"].Value))
                        {
                            int indiceCombo = comboBoxState.Items.IndexOf(oc);
                            comboBoxState.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtBusqueda.Texts = "";
            foreach (DataGridViewRow row in dataGridUsser.Rows) row.Visible = true;
        }




        /*boton de guardar y editar*/
        //------------------------------------------------------------------------------------------------------------
        private void guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Usuario usuario1 = new Usuario()
            {
                id_usuario = Convert.ToInt32(txtIndice.Text),
                obRol = new Rol() { id_rol = Convert.ToInt32(((OpcionCombobox)comboBoxRol.SelectedItem).valor) },
                dni = (txtDocument.Texts == "") ? txtDocument.Texts = txtDocumenPrueba.Text : txtDocument.Texts,
                name = (txtName.Texts == "") ? txtName.Texts = txtnamePrueba.Text : txtName.Texts,
                apellido = (txtApellido.Texts == "") ? txtApellido.Texts = txtapellidoPrueba.Text : txtApellido.Texts,
                email = (txtEmail.Texts == "") ? txtEmail.Texts = txtemailPrueba.Text : txtEmail.Texts,
                telefono = (txtPhone.Texts == "") ? txtPhone.Texts = txtprueba.Text : txtPhone.Texts,
                state = Convert.ToInt32(((OpcionCombobox)comboBoxState.SelectedItem).valor) == 1 ? true : false,
                pasword = (txtPasword.Texts == "") ? txtPasword.Texts = txtcontraseñaPrueba.Text : txtPasword.Texts,
            };
            //---------------------------------------------------------------------------------------------------------




            /*si el usuario a dar de alta es new => lo registra*/
            if (usuario1.id_usuario == 0)
            {
                //una ves instanciado mi objeto llamo al procedimiento registrar en CN_usuario

                int idUsuarioGeneradoo = new CN_Usuario().Registrar(usuario1, out mensaje);
                if (idUsuarioGeneradoo != 0)
                {
                    //cargo los dattos en el datagrid
                    dataGridUsser.Rows.Add(new object[] { "",idUsuarioGeneradoo,
                    ((OpcionCombobox)comboBoxRol.SelectedItem).valor.ToString(),
                    ((OpcionCombobox)comboBoxRol.SelectedItem).Texto.ToString(),
                    txtDocument.Texts,txtName.Texts,txtApellido.Texts,txtEmail.Texts,
                    txtPhone.Texts,((OpcionCombobox)comboBoxState.SelectedItem).valor,
                    txtPasword.Texts

                    });
                    clean();
                }
                //en el caso de que no se pueda dar de alta el usser muestra mensaje de error
                else MessageBox.Show(mensaje);
            }
            else /*si ya esta registrado se procedera a editarlo*/
            {
                int resultado = new CN_Usuario().Editar(usuario1, out mensaje);
                if (resultado == 1)
                {
                    //procede a modificar los datos del datagrid
                    DataGridViewRow row = dataGridUsser.Rows[Convert.ToInt32(textBox2.Text)];
                    // row.Cells["S"].Value = "";
                    row.Cells["ID"].Value = txtIndice.Text;
                    row.Cells["Rolid"].Value = ((OpcionCombobox)comboBoxRol.SelectedItem).valor;
                    row.Cells["idrol"].Value = ((OpcionCombobox)comboBoxRol.SelectedItem).Texto;
                    row.Cells["dni"].Value = usuario1.dni;
                    row.Cells["name"].Value = usuario1.name;
                    row.Cells["Apellido"].Value = usuario1.apellido;
                    row.Cells["Email"].Value = usuario1.email;
                    row.Cells["Telefono"].Value = usuario1.telefono;
                    row.Cells["state"].Value = ((OpcionCombobox)comboBoxState.SelectedItem).valor;
                    row.Cells["pasword"].Value = usuario1.pasword;
                    clean();
                }
                else MessageBox.Show(mensaje);
            }


        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIndice.Text) != 0)
            {
                if (MessageBox.Show("Deseas eliminar el usser pa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario usuerioELiminar = new Usuario()
                    {
                        id_usuario = Convert.ToInt32(txtIndice.Text)
                    };


                    int respuesta = new CN_Usuario().Eliminar(usuerioELiminar, out mensaje);

                    if (respuesta == 1)
                    {
                        //remuevo la fila del datagrid
                        dataGridUsser.Rows.RemoveAt(Convert.ToInt32(textBox2.Text));
                        clean();
                    }
                    else MessageBox.Show(mensaje, "Tal ves no", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombobox)comboBusqueda.SelectedItem).valor.ToString();
            if (dataGridUsser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridUsser.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Texts.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }
        }

        private void comboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

<<<<<<< HEAD
        private void txtBusqueda__Textchanged(object sender, EventArgs e)
        {

=======
        //Error en caso de ingresar un campo incorrecto
        ErrorProvider errorN = new ErrorProvider();
        //Campo DNI Sólo Números
        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = ValidarDatos.soloNumeros(e);
            if (!validar)
                errorN.SetError(txtDocument, "Este campo sólo acepta valores numéricos");
            else
                errorN.Clear();
        }

        //Validar como campo obligatorio DNI
        ErrorProvider errorD = new ErrorProvider();
        private void txtDocument_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = txtDocument.Texts;
            if (validaCampos == "")
            {
                errorD.SetError(txtDocument, "¡Campo Obligatorio! Debe ingresar un DNI");
            }
            else
                errorD.Clear();
        }

        //Campo Nombre Sólo letras
        ErrorProvider errorC = new ErrorProvider();
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validarLetras = ValidarDatos.soloLetras(e);
            if (!validarLetras)
                errorC.SetError(txtName, "Este campo sólo acepta valores en letras");
            else
                errorC.Clear();
        }

        //Validar como campo obligatorio Nombre
        ErrorProvider errorF = new ErrorProvider();
        private void txtName_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = txtName.Texts;
            if (validaCampos == "")
            {
                errorF.SetError(txtName, "¡Campo Obligatorio! Debe ingresar un Nombre");
            }
            else
                errorF.Clear();
        }

        //Validar Email
        ErrorProvider errorM = new ErrorProvider();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidarDatos.validarEmail(txtEmail.Texts))
                errorM.SetError(txtEmail, "Correo no válido");
            else
                errorM.Clear();
        }

        //Campo Telefono Sólo Números
        ErrorProvider errorP = new ErrorProvider();
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = ValidarDatos.soloNumeros(e);
            if (!validar)
                errorP.SetError(txtPhone, "Este campo sólo acepta valores numéricos");
            else
                errorP.Clear();
        }

        //Validar como campo obligatorio Telefono
        ErrorProvider errorT = new ErrorProvider();

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = txtPhone.Texts;
            if (validaCampos == "")
            {
                errorT.SetError(txtPhone, "¡Campo Obligatorio! Debe ingresar un Teléfono");
            }
            else
                errorT.Clear();
        }

        //Error en caso de ingresar un campo incorrecto
        ErrorProvider errorL = new ErrorProvider();
        //Campo Apellido Sólo letras
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validarLetras = ValidarDatos.soloLetras(e);
            if (!validarLetras)
                errorL.SetError(txtApellido, "Este campo sólo acepta valores en letras");
            else
                errorL.Clear();
        }

        //Validar como campo obligatorio Apellido
        ErrorProvider errorA = new ErrorProvider();
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = txtApellido.Texts;
            if (validaCampos == "")
            {
                errorA.SetError(txtApellido, "¡Campo Obligatorio! Debe ingresar un Apellido");
            }
            else
                errorA.Clear();
        }

        //Validar como campo obligatorio Contraseña
        ErrorProvider errorW = new ErrorProvider();
        private void txtPasword_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = txtPasword.Texts;
            if (validaCampos == "")
            {
                errorW.SetError(txtPasword, "¡Campo Obligatorio! Debe ingresar una Contraseña");
            }
            else
                errorW.Clear();
>>>>>>> f430ca1bbcac76325e397842f2de6dbb6a035f13
        }
    }


}
