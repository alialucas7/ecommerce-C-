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
            

            /*instancia de de mi datagrid*/
            BunifuCustomDataGrid bunifuDataGridView = new BunifuCustomDataGrid();
            bunifuDataGridView.Size = new Size(481, 165);
            bunifuDataGridView.Location = new Point(53, 255);
            this.Controls.Add(bunifuDataGridView);

            // bunifuDataGridView.PopulateWithSampleData();






            // TODO: esta línea de código carga datos en la tabla 'bD_dealershipDataSet.Usuario' Puede moverla o quitarla según sea necesario.

            /*Seba si te da error comenta la linea de abajo y descomenta esta
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.J.SebastianOrtiz);*/
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.Usuario);

            /*esto es para que pueda habiliatr ussser mediante mi combobox*/
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 1, Texto = "Habilitado"});
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 0, Texto = "Inhabilitado" });
            comboBoxState.DisplayMember = "Texto";
            comboBoxState.ValueMember = "valor";
            comboBoxState.SelectedIndex = 0;


            /* me trae los datos de la BD en la columna rol y muestra en el combobox*/
            List<Rol> listaRol1 = new CN_Rol().Listar();

            foreach (Rol item in listaRol1)
            {
                comboBoxRol.Items.Add(new OpcionCombobox() { valor = item.id_rol , Texto = item.descripcion});
            }
            comboBoxRol.DisplayMember = "Texto";
            comboBoxRol.ValueMember = "valor";
            
            //me permite uscar elementos por categoria en mi datagrid
            foreach (DataGridViewColumn columna in bunifuCustomDataGrid11.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBusqueda.Items.Add(new OpcionCombobox() { valor = columna.Name ,Texto = columna.HeaderText});
                }
            }
            comboBusqueda.DisplayMember = "Texto";
            comboBusqueda.ValueMember = "valor";
            comboBusqueda.SelectedIndex = 1;
        }

        /*metodolimpiador de campos*/
        private void clean()
        {
            txtIndice.Text = "";
            txtDocument.Texts = "Documento";
            txtDocument.ForeColor = Color.DarkGray;
            txtName.Texts = "Nombre";
            txtName.ForeColor = Color.DarkGray;
            txtApellido.Texts = "Apellido";
            txtApellido.ForeColor = Color.DarkGray;
            txtEmail.Texts = "Email";
            txtEmail.ForeColor = Color.DarkGray;
            txtPasword.Texts = "Contraseña";
            txtPasword.ForeColor = Color.DarkGray;
            txtPhone.Texts = "Telefono";
            txtPhone.ForeColor = Color.DarkGray;
        }


        /*en este metodo lleva los datos del datagrid a los texbox*/
        private void bunifuCustomDataGrid11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Si se hace click =>
            if (bunifuCustomDataGrid11.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                
                int indice = e.RowIndex;
                if(indice >= 0)
                {
                    txtIndice.Text = bunifuCustomDataGrid11.Rows[indice].Cells["id"].Value.ToString();
                    txtDocument.ForeColor = Color.Black;
                    txtDocument.Texts = bunifuCustomDataGrid11.Rows[indice].Cells["dni"].Value.ToString();

                    txtPhone.ForeColor = Color.Black;
                    txtPhone.Texts = bunifuCustomDataGrid11.Rows[indice].Cells["telefono"].Value.ToString();

                    txtName.ForeColor = Color.Black;
                    txtName.Texts = bunifuCustomDataGrid11.Rows[indice].Cells["name"].Value.ToString();

                    txtApellido.ForeColor = Color.Black;
                    txtApellido.Texts = bunifuCustomDataGrid11.Rows[indice].Cells["apellido"].Value.ToString();

                    txtEmail.ForeColor = Color.Black;
                    txtEmail.Texts = bunifuCustomDataGrid11.Rows[indice].Cells["email"].Value.ToString();

                    txtPasword.ForeColor = Color.Black;
                    txtPasword.Texts = bunifuCustomDataGrid11.Rows[indice].Cells["pasword"].Value.ToString();
                    
                    /*Metodos para cargar los combobox segun informacion almacenada*/

                    //combobox de rol
                    foreach (OpcionCombobox oc in comboBoxRol.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(bunifuCustomDataGrid11.Rows[indice].Cells["idrol"].Value))
                        {
                            int indiceCombo = comboBoxRol.Items.IndexOf(oc);
                            comboBoxRol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    //combobox de estado
                    foreach (OpcionCombobox oc in comboBoxState.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(bunifuCustomDataGrid11.Rows[indice].Cells["estado"].Value))
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
            clean();
        }
    }
}
