using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CapaNegocio;
using CapaEntidad;

namespace BUNIFU
{
    public partial class Inicio_Marketing : Form
    {

        public static Usuario usuarioActual;

        //variables para abrir formulario cuando se clickean los 
        private static Form FormularioActivo = null;

        //variables para dar color a los botones del menu
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string textoB1;


        //defino mis propios colores , para mis botones
        private struct RGBColors
        {
            
            public static Color color3 = Color.FromArgb(61, 201, 209);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color1 = Color.FromArgb(176, 34, 98);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(62, 174, 37);
            public static Color fondoFormularios = Color.FromArgb(240, 243, 250);
        }

        public Inicio_Marketing(Usuario obusser)
        {
            InitializeComponent();
            /* Instancio objetos para los btn*/
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelBotones.Controls.Add(leftBorderBtn);
            usuarioActual = obusser;
            ocultarBoton();
        }






        //Metodos para poner boton a los colore
        private void ActiveButon(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //metodo creado mas abajo
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(59, 57, 113);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                if (panelBotones.Width == panelBotones.MinimumSize.Width)
                {
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                else
                {
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                }
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                //franja el el borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(6, 10, 15);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //FormularioActivo.Close();
        }





        private void abrirFormulario(Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            //configura el formulario
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            // formulario.BackColor = RGBColors.fondoFormularios;
            //agrega el formulario configurado al contenedor
            containerfrm.Controls.Add(formulario);
            formulario.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color1);
            abrirFormulario(new frmCliente());
        }

        private void Inicio_Marketing_Load(object sender, EventArgs e)
        {
            //Carga los datos del usser
            lblName.Text = usuarioActual.name + ", " + usuarioActual.apellido;
            lblCoreeo.Text = usuarioActual.email;
            lblRol.Text = usuarioActual.obRol.descripcion.ToUpper();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color6);
            abrirFormulario(new frmBackup2());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color5);
            //abre el formulario cuando se hace click
            abrirFormulario(new frmUsuariosAdministrador(usuarioActual));
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color2);
            //abrirFormulario(new frmBackup2());
            mostrarBtn(panel1);
        }



        /*Metodos para expandir el boton de ventas*/
        public void ocultarBoton()
        {
            panel1.Visible = false;
        }
        public void ocultarSubBotones()
        {
            if (panel1.Visible == true) panel1.Visible = false;

        }
        public void mostrarBtn(Panel btn)
        {
            if (btn.Visible == false)
            {
                ocultarSubBotones();
                btn.Visible = true;

            }
            else btn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultarSubBotones();
            abrirFormulario(new frmProducto_AdministtradorSucursal(usuarioActual));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultarSubBotones();
        }
    }
}
