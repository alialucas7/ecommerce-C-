using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUNIFU.Controles_graficos
{
    [DefaultEvent("_Textchanged")]
    public partial class UserControl1 : UserControl
    {

        //inicializo valores predeterminados 
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        //para indicar al usser en q tebox esta escribiendo
        private Color borderFocusColor = Color.Black;
        private bool isFocused = false;




        //defino una variable para que mi texbox tenga bordes redondeado
        private int borderRadius = 0;
        private Color palceHolderColor = Color.DarkGray;
        private string palceHolderText = "";
        private bool ispalceHolder = false;


        public UserControl1()
        {
            InitializeComponent();
        }


        /*Conmutadores y setteadores*/
        public Color BorderColor
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return this.borderSize; }
            set
            {
                this.borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderLinedStyle
        {
            get { return this.underlinedStyle; }
            set
            {
                this.underlinedStyle = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get
            {
                return this.borderRadius;
            }
            set
            {
                if (value >= 0)
                {
                    this.borderRadius = value;
                    this.Invalidate(); //vuelve a dibujar el control con la new apariencia
                }
            }
        }
        /* fin de los conmutadores y setteadores*/


        /*Anulacion de algunos eventos*/ //metodo de pintura
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1) //es un cuadro redondeado
            {
                //variables para dibujar el texbox redondeado
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                //se procede a dibujar el redondeado
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorder);


                    }
                }
            }
            else //es un cuadro normal
            {
                //aca se dibuja la linea del texbox

                //Se crea un objeto boligrafo propio del lenguaje y armo el constructor con las var que declare arriba
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset; //establece la alineacion inicial

                    if (!isFocused) // si NO esta enfocado
                    {

                        if (underlinedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else { graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F); }
                    }

                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlinedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else { graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F); }
                    }

                }
            }



        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (MultiLine)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }


        //ruta de graficos para crear el control de esquinas redondeadas
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        //Anulacion del evento de redimensionado
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) UpdateControlHeight();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight() //metodo que restringe el cambio de altura
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                //establecemos el alto adecuado del control de usser
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;

            }
        }



        //metodo que permite poner contraseña al texbox
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("lucas-configuration 2.0")]
        //metodo que permitira cambiar el alto y ancho del texbox
        public bool MultiLine
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("lucas-configuration 2.0")]
        //metodo para poner el color de fondo
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("lucas-configuration 2.0")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }



        [Category("lucas-configuration 2.0")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode) UpdateControlHeight(); //establece alto adecuado segun tipo y tamaño de fuente
            }
        }

        [Category("lucas-configuration 2.0")]
        public string Texts
        {
            get {
                if (ispalceHolder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                setPalceHolder();
            }
        }


        public Color BorderFocusColor
        {
            set {
                borderFocusColor = value;

            }
            get { return this.borderFocusColor; }
        }

        public Color PalceHolderColor
        {
            get { return palceHolderColor; }
            set {
                palceHolderColor = value;
                
            }
        }
        public string PalceHolderText
        {
            get { return palceHolderText; }
            set { palceHolderText = value;
                textBox1.Text = "";
                setPalceHolder();
            }
        }

        private void setPalceHolder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)&& palceHolderText != "")
            {
                ispalceHolder = true;
                textBox1.Text = palceHolderText;
                textBox1.ForeColor = palceHolderColor;
            }
        }

        private void RemovePalceHoler()
        {
            if (ispalceHolder && palceHolderText != "")
            {
                ispalceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
            }
        }

        /** Eventos que tendran los texbox */
        public event EventHandler _Textchanged;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_Textchanged != null) _Textchanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePalceHoler();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            setPalceHolder();
        }
    }
}
