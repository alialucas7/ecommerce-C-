using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;



namespace CustomControls.Controles_graficos
{
    
    [DefaultEvent("OnSelectedIndexChanged")]              //Elemento Predeterminado del combo box

    class CD_ComboBox : UserControl
    {
        //Se asignan campos para la apariencia y valores
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Elementos que tendrá el combo box
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Propiedades y apariencias de los campos

        [Category("CD_ComboBox Apariencias")]
        public new Color BackColor                  //Ocultamos la propiedad anterior para crear una nueva, si que afecte la clase base
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;      //Cambiamos el color de fondo de la etiqueta y del boton
                btnIcon.BackColor = backColor;

            }
        }

        [Category("CD_ComboBox Apariencias")]
        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();                  //Volvemos a dibujar el icono con el color especificado
            }
        }

        [Category("CD_ComboBox Apariencias")]
        public Color ListBackColor {
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;      //Cambiamos el color de fondo del Combo Box
            }
        }

        [Category("CD_ComboBox Apariencias")]
        public Color ListTextColor
        {
            get
            {
                return listTextColor;
            }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;      //Cambiamos el color de fondo del Combo Box
            }
        }

        [Category("CD_ComboBox Apariencias")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;  //La propiedad color de fondo del ctrl de usuario actua como el borde, ya que el boton y la etiqueta llenan el ctrl
            }
        }

        [Category("CD_ComboBox Apariencias")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);     //Se encarga de establecer el tamaño del borde
                AdjustComboBoxDimensions();
            }
        }

        //Anulamos las propiedades de color y fuente
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;   //Cambiar lista desplegable
            }
        }

        //Creamos una nueva propiedad para el texto
        public string Texts
        {
            get
            {
                return lblText.Text;
            }
            set
            {
                lblText.Text = value;
            }
        }

        //Creamos una propiedad para cambiar el estilo desplegable de la etiqueta y lo ordenamos por categoria
        [Category("CD_ComboBox Apariencias")]
        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return cmbList.DropDownStyle;
            }

            set
            {
               if(cmbList.DropDownStyle != ComboBoxStyle.Simple) //Condicion para que el valor sea diferente al estilo simple
                cmbList.DropDownStyle = value;
            }
        }

        //Propiedades relacionados con el combo box
        //Items permite agregar los objetos a la lista
        [Category("ComboBox Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        //Fuente de datos
        [Category("ComboBox Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource
        {
            get
            {
                return cmbList.DataSource;
            }
            set
            {
                cmbList.DataSource = value;
            }
        }

        //Auto Completar.
        [Category("ComboBox Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return cmbList.AutoCompleteCustomSource;
            }
            set
            {
                cmbList.AutoCompleteCustomSource = value;
            }
        }

        //Origen de autocompletar Obtiene o establece un valor que especifica el origen de cadenas completas utilizadas para la finalización automática.
        [Category("ComboBox Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return cmbList.AutoCompleteSource;
            }
            set
            {
                cmbList.AutoCompleteSource = value; ;
            }
        }

        //Auto Completar Obtiene o establece una opción que controla cómo funciona la finalización automática
        [Category("ComboBox Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return cmbList.AutoCompleteMode;
            }
            set
            {
                cmbList.AutoCompleteMode = value;
            }
        }

        //Auto Selección que nos permite obtener los índices
        [Category("ComboBox Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get
            {
                return cmbList.SelectedItem;
            }
            set
            {
                cmbList.SelectedItem = value;
            }
        }

        //Select Index Obtiene o establece el índice que especifica el elemento seleccionado actualmente.
        [Category("ComboBox Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return cmbList.SelectedIndex;
            }
            set
            {
                cmbList.SelectedIndex = value;
            }
        }

        //Eventos predeterminados
        public event EventHandler OnSelectedIndexChanged;       //Debe contener el minsmo nombnre que el atributo

        //Constructor inicializamos los componentes del control de usuario
        public CD_ComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //Componente ComboBox Lista desplegable
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name,10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);    //Suscribir el elemento predeterminado del Combo Box, para poder vincular con elemento predeterminado que creamos
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);                      //Suscribimos el evento cambiado para actualizar el texto del control, cada vez que cambie el texto

            //Inicializamos las apariencias del botón de Ícono
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30,30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);                    //Añadimos el elemento click para desplegar la lista
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);               //Para dibujar la lista

            //Componentes texto, establecemos la propiedad
            lblText.Dock = DockStyle.Fill;                          //El boton se acopla al lado derecho del ctrl de usuario y la etiqueta se llena o se acopla en el espacio restante
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8,0,0,0);
            lblText.Font = new Font(this.Font.Name,10F);

            //Vincular los eventos de las etiquetas con las acciones de los usuarios
            lblText.Click += new EventHandler(Surface_Click);       //Metodo se encarga de seleccionar el combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //Control de usuarios, agregamos los componentes anteriores. Importante seguir el siguiente orden, ya que los controles se agregan de abajo hacia arriba
            this.Controls.Add(lblText); //2. Se agrega la etiqueta para llenar el espacio
            this.Controls.Add(btnIcon); //1. Se agrega el botón hacia el lado derecho
            this.Controls.Add(cmbList); //0. Se agrega al fondo detrás de todo
            this.MinimumSize = new Size(200,30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize); //Se encarga de establecer el tamaño del borde
            base.BackColor = borderColor;           //Color de Borde
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width; //El ancho del combro box será igual al de la etiqueta y se ubicará en la parte inferior dercecha del ctrl usuario
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refrescamos el texto, el texto de la etiqueta debe ser igual al del Combo Box
            lblText.Text = cmbList.Text;
        }

        //Vincular los eventos de las etiquetas con las acciones de los usuarios
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        //Anulamos evento redimensionado, para ajustar las condiciones adecuadas del combo box, cuando cambia de tamaño
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        //Cuando el indice seleccionado cambie, invocamos al siguiente método
        //Elemento predetermindado de nuestro control
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Declaramos los campos para realizar el dibujo
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //Dibujamos el icono de flecas hacia abajo
            using (GraphicsPath path = new GraphicsPath())            //Creamos la ruta de gráfico para crear el ícono y el trazo del ícono
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom,rectIcon.Right,rectIcon.Y);
                graph.DrawPath(pen,path);
            }

        }

        private void Icon_Click(object sender, EventArgs e)
        {
            //Abre la lista desplegable
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CD_ComboBox
            // 
            this.Name = "CD_ComboBox";
            this.Load += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CD_ComboBox_MouseClick);
            this.ResumeLayout(false);

        }


        private void CD_ComboBox_MouseClick(object sender, MouseEventArgs e)
        {

        }


    }
}
