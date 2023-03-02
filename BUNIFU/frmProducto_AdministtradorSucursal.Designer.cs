namespace BUNIFU
{
    partial class frmProducto_AdministtradorSucursal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto_AdministtradorSucursal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.carrusel = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDsucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nPuerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Añof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new BUNIFU.Controles_graficos.UserControl1();
            this.userControl14 = new BUNIFU.Controles_graficos.UserControl1();
            this.userControl13 = new BUNIFU.Controles_graficos.UserControl1();
            this.userControl12 = new BUNIFU.Controles_graficos.UserControl1();
            this.userControl11 = new BUNIFU.Controles_graficos.UserControl1();
            this.cD_Button1 = new CustomControls.Controles_graficos.CD_Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // carrusel
            // 
            this.carrusel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("carrusel.ImageStream")));
            this.carrusel.TransparentColor = System.Drawing.Color.Transparent;
            this.carrusel.Images.SetKeyName(0, "popular1.png");
            this.carrusel.Images.SetKeyName(1, "popular2.png");
            this.carrusel.Images.SetKeyName(2, "popular3.png");
            this.carrusel.Images.SetKeyName(3, "popular4.png");
            this.carrusel.Images.SetKeyName(4, "popular5.png");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.carrusel;
            this.label1.Location = new System.Drawing.Point(532, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 220);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Limited Edition - ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numStock
            // 
            this.numStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numStock.Location = new System.Drawing.Point(554, 25);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(120, 20);
            this.numStock.TabIndex = 1;
            this.numStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Stock";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(439, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 83;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClean.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 27;
            this.btnClean.Location = new System.Drawing.Point(323, 31);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 26);
            this.btnClean.TabIndex = 81;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(269, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 26);
            this.btnBuscar.TabIndex = 80;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Location = new System.Drawing.Point(52, 35);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(105, 21);
            this.comboBusqueda.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Buscar por";
            // 
            // txID
            // 
            this.txID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txID.Enabled = false;
            this.txID.Location = new System.Drawing.Point(439, 77);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(21, 20);
            this.txID.TabIndex = 77;
            this.txID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txID.Visible = false;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(170)))));
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
            this.IDsucursal,
            this.id_marca,
            this.marca,
            this.id_modelo,
            this.modelo,
            this.patente,
            this.precio,
            this.stock,
            this.state,
            this.nPuerta,
            this.color,
            this.Añof,
            this.descripcion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridProduct.EnableHeadersVisualStyles = false;
            this.dataGridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dataGridProduct.Location = new System.Drawing.Point(22, 63);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridProduct.Size = new System.Drawing.Size(411, 375);
            this.dataGridProduct.TabIndex = 76;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "S";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 38;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 20;
            // 
            // IDsucursal
            // 
            this.IDsucursal.HeaderText = "ID_sucur";
            this.IDsucursal.Name = "IDsucursal";
            this.IDsucursal.ReadOnly = true;
            this.IDsucursal.Visible = false;
            // 
            // id_marca
            // 
            this.id_marca.HeaderText = "id_marca";
            this.id_marca.Name = "id_marca";
            this.id_marca.ReadOnly = true;
            this.id_marca.Visible = false;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // id_modelo
            // 
            this.id_modelo.HeaderText = "id_modelo";
            this.id_modelo.Name = "id_modelo";
            this.id_modelo.ReadOnly = true;
            this.id_modelo.Visible = false;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // patente
            // 
            this.patente.HeaderText = "Patente";
            this.patente.Name = "patente";
            this.patente.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.state.Width = 20;
            // 
            // nPuerta
            // 
            this.nPuerta.HeaderText = "Nº puertas";
            this.nPuerta.Name = "nPuerta";
            this.nPuerta.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // Añof
            // 
            this.Añof.HeaderText = "Año Fabricado";
            this.Añof.Name = "Añof";
            this.Añof.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtBusqueda.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtBusqueda.BorderRadius = 9;
            this.txtBusqueda.BorderSize = 1;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBusqueda.Location = new System.Drawing.Point(164, 25);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.MultiLine = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusqueda.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PalceHolderText = "Buscar...";
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.Size = new System.Drawing.Size(98, 32);
            this.txtBusqueda.TabIndex = 82;
            this.txtBusqueda.Texts = "";
            this.txtBusqueda.UnderLinedStyle = false;
            // 
            // userControl14
            // 
            this.userControl14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userControl14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.userControl14.BorderFocusColor = System.Drawing.Color.Black;
            this.userControl14.BorderRadius = 15;
            this.userControl14.BorderSize = 1;
            this.userControl14.Enabled = false;
            this.userControl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl14.Location = new System.Drawing.Point(517, 288);
            this.userControl14.Margin = new System.Windows.Forms.Padding(4);
            this.userControl14.MultiLine = true;
            this.userControl14.Name = "userControl14";
            this.userControl14.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl14.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl14.PalceHolderText = "Descripcion ...";
            this.userControl14.PasswordChar = false;
            this.userControl14.Size = new System.Drawing.Size(270, 129);
            this.userControl14.TabIndex = 7;
            this.userControl14.Texts = "";
            this.userControl14.UnderLinedStyle = false;
            // 
            // userControl13
            // 
            this.userControl13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userControl13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.userControl13.BorderFocusColor = System.Drawing.Color.Black;
            this.userControl13.BorderRadius = 15;
            this.userControl13.BorderSize = 1;
            this.userControl13.Enabled = false;
            this.userControl13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl13.Location = new System.Drawing.Point(702, 249);
            this.userControl13.Margin = new System.Windows.Forms.Padding(4);
            this.userControl13.MultiLine = false;
            this.userControl13.Name = "userControl13";
            this.userControl13.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl13.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl13.PalceHolderText = "Color";
            this.userControl13.PasswordChar = false;
            this.userControl13.Size = new System.Drawing.Size(85, 31);
            this.userControl13.TabIndex = 6;
            this.userControl13.Texts = "";
            this.userControl13.UnderLinedStyle = false;
            // 
            // userControl12
            // 
            this.userControl12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userControl12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.userControl12.BorderFocusColor = System.Drawing.Color.Black;
            this.userControl12.BorderRadius = 15;
            this.userControl12.BorderSize = 1;
            this.userControl12.Enabled = false;
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl12.Location = new System.Drawing.Point(610, 249);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4);
            this.userControl12.MultiLine = false;
            this.userControl12.Name = "userControl12";
            this.userControl12.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl12.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl12.PalceHolderText = "Modelo";
            this.userControl12.PasswordChar = false;
            this.userControl12.Size = new System.Drawing.Size(85, 31);
            this.userControl12.TabIndex = 5;
            this.userControl12.Texts = "";
            this.userControl12.UnderLinedStyle = false;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userControl11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.userControl11.BorderFocusColor = System.Drawing.Color.Black;
            this.userControl11.BorderRadius = 15;
            this.userControl11.BorderSize = 1;
            this.userControl11.Enabled = false;
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl11.Location = new System.Drawing.Point(517, 249);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.MultiLine = false;
            this.userControl11.Name = "userControl11";
            this.userControl11.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl11.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl11.PalceHolderText = "Marca";
            this.userControl11.PasswordChar = false;
            this.userControl11.Size = new System.Drawing.Size(85, 31);
            this.userControl11.TabIndex = 4;
            this.userControl11.Texts = "";
            this.userControl11.UnderLinedStyle = false;
            // 
            // cD_Button1
            // 
            this.cD_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cD_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.cD_Button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.cD_Button1.BorderColor = System.Drawing.Color.Orange;
            this.cD_Button1.BorderRadius = 16;
            this.cD_Button1.BorderSize = 0;
            this.cD_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cD_Button1.FlatAppearance.BorderSize = 0;
            this.cD_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button1.ForeColor = System.Drawing.Color.White;
            this.cD_Button1.Location = new System.Drawing.Point(680, 20);
            this.cD_Button1.Name = "cD_Button1";
            this.cD_Button1.Size = new System.Drawing.Size(86, 25);
            this.cD_Button1.TabIndex = 3;
            this.cD_Button1.Text = "Agregar";
            this.cD_Button1.TextColor = System.Drawing.Color.White;
            this.cD_Button1.UseVisualStyleBackColor = false;
            // 
            // frmProducto_AdministtradorSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.cD_Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto_AdministtradorSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto_AdministtradorSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList carrusel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label label2;
        private CustomControls.Controles_graficos.CD_Button cD_Button1;
        private Controles_graficos.UserControl1 userControl11;
        private Controles_graficos.UserControl1 userControl12;
        private Controles_graficos.UserControl1 userControl13;
        private Controles_graficos.UserControl1 userControl14;
        private System.Windows.Forms.TextBox textBox1;
        private Controles_graficos.UserControl1 txtBusqueda;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDsucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPuerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Añof;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}