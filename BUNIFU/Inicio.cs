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
    public partial class Inicio : Form
    {
        //defino mis propios colores , para mis botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            //public static Color color2 = Color.FromArgb(249, 118, 246);
            public static Color color3 = Color.FromArgb(61, 201, 209);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(62, 174, 37);
            //public static Color fondoFormularios = Color.FromArgb(58,52,95);
            public static Color fondoFormularios = Color.FromArgb(240,243, 250);
            
        }


        //para cargar el usuario que se a logueado
        public Usuario usuarioActual;

        //variables para abrir formulario cuando se clickean los 
        private static Form FormularioActivo = null;

        //variables para dar color a los botones del menu
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string textoB1; 

        //para hacer la animacion de la barra 
        bool sidebarExpand;

        public Inicio(Usuario objUsser = null)
        {
           // usuarioActual = objUsser; luego descomentar esto
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            menuVertical.Controls.Add(leftBorderBtn);


            //codigo temporal
            if (usuarioActual == null) usuarioActual = new Usuario() { id_usuario = 1 };
            else usuarioActual = objUsser;
            //codigo temporal

            /* lo oculto temporalmente para trabajar mas comodo
            //oculta botones a usuarios no autorisados
            if (usuarioActual.obRol.getID() == 3)
            {   //usuario empleado
                iconButton4.Hide();
                iconButton5.Hide();
                iconButton6.Hide();
            }

            if (usuarioActual.obRol.getID() == 2)
            {   //usuario de ventas
                iconButton1.Hide();
                iconButton2.Hide();
                iconButton5.Hide();
            }*/


        }

        //cuando se lee el formulario que cargue la lista
        private void Inicio_Load(object sender, EventArgs e)
        {
            //List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.id_usuario);

           
           


            /*muestra los botones dependiendo del usuario que se va a loguear
            foreach (IconMenuItem iconmenu in menuVertical.Container.Components)
            {
                bool encontrado = listaPermisos.Any(m => m.nameMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }*/
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
                if (menuVertical.Width == menuVertical.MinimumSize.Width)
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
                currentBtn.BackColor = Color.FromArgb(6,10,15);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
               currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //boton de cerrar
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnslide_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            //condicional para que vaya intercalando el icono segun click
            if (btnslide.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                btnslide.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            }
            else
            {
                btnslide.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            }
            
            /*va a ir alternando para mostrar u ocular el menu
            
                if (menuVertical.Width == 204)
                {

                btnslide.Text = "Contraer";

                }
                else {
                btnslide.Text = "Expandir"; 
                }*/
         }
           
          //funcion que oculta la barra de menu
            private void SidebarTimer_Tick(object sender, EventArgs e)
           {
            textoB1= iconButton1.Text;
            if (sidebarExpand)
                {
                        menuVertical.Width -= 10;
                        if (menuVertical.Width == menuVertical.MinimumSize.Width)
                        {
                            sidebarExpand = false;
                            sidebarTimer.Stop();
                            btnslide.Text = "Expandir Menu";
                    
                        }
                }
                else
                {
                        menuVertical.Width += 10;
                        if (menuVertical.Width == menuVertical.MaximumSize.Width)
                        {
                            sidebarExpand = true;
                            sidebarTimer.Stop();
                            btnslide.Text = "Contraer Menu";
                        }
                }
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
            panel2.Controls.Add(formulario);
            formulario.Show();
        }



        //aplico los colores a los botones, llamo a los metodos q cree
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //da animacion al boton cuando se hace click
            ActiveButon(sender, RGBColors.color1);
            abrirFormulario(new frmCliente());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color2);
            abrirFormulario(new frmProductos());
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color3);
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color4);
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color5);
            //abre el formulario cuando se hace click
            abrirFormulario(new frmUsuarios());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButon(sender, RGBColors.color6);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            FormularioActivo.Close();
        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
