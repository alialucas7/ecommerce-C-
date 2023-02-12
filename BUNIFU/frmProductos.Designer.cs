namespace BUNIFU
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboSucur = new System.Windows.Forms.ComboBox();
            this.labelSuxur = new System.Windows.Forms.Label();
            this.comboMark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.txID = new System.Windows.Forms.TextBox();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txPatente = new System.Windows.Forms.TextBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.txStok = new System.Windows.Forms.TextBox();
            this.txAñao = new System.Windows.Forms.TextBox();
            this.txColor = new System.Windows.Forms.TextBox();
            this.txDor = new System.Windows.Forms.TextBox();
            this.txDescript = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusqueda = new BUNIFU.Controles_graficos.UserControl1();
            this.btnLimpiar = new CustomControls.Controles_graficos.CD_Button();
            this.btnEliminar = new CustomControls.Controles_graficos.CD_Button();
            this.guardar = new CustomControls.Controles_graficos.CD_Button();
            this.txtdescrip = new BUNIFU.Controles_graficos.UserControl1();
            this.txtAño = new BUNIFU.Controles_graficos.UserControl1();
            this.txtColor = new BUNIFU.Controles_graficos.UserControl1();
            this.txtPuerta = new BUNIFU.Controles_graficos.UserControl1();
            this.txtPrecio = new BUNIFU.Controles_graficos.UserControl1();
            this.txtStocke = new BUNIFU.Controles_graficos.UserControl1();
            this.txtPatente = new BUNIFU.Controles_graficos.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSucur
            // 
            this.comboSucur.FormattingEnabled = true;
            this.comboSucur.Location = new System.Drawing.Point(20, 39);
            this.comboSucur.Name = "comboSucur";
            this.comboSucur.Size = new System.Drawing.Size(361, 21);
            this.comboSucur.TabIndex = 0;
            this.comboSucur.SelectedIndexChanged += new System.EventHandler(this.comboSucur_SelectedIndexChanged);
            // 
            // labelSuxur
            // 
            this.labelSuxur.AutoSize = true;
            this.labelSuxur.Location = new System.Drawing.Point(17, 23);
            this.labelSuxur.Name = "labelSuxur";
            this.labelSuxur.Size = new System.Drawing.Size(115, 13);
            this.labelSuxur.TabIndex = 1;
            this.labelSuxur.Text = "Seleccione la Sucursal";
            this.labelSuxur.Click += new System.EventHandler(this.labelSuxur_Click);
            // 
            // comboMark
            // 
            this.comboMark.FormattingEnabled = true;
            this.comboMark.Location = new System.Drawing.Point(20, 89);
            this.comboMark.Name = "comboMark";
            this.comboMark.Size = new System.Drawing.Size(121, 21);
            this.comboMark.TabIndex = 2;
            this.comboMark.SelectedIndexChanged += new System.EventHandler(this.comboMark_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione el Modelo";
            // 
            // comboModel
            // 
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(147, 89);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(121, 21);
            this.comboModel.TabIndex = 4;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(282, 89);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(99, 21);
            this.comboEstado.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "estado";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
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
            this.dataGridProduct.Location = new System.Drawing.Point(411, 73);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridProduct.Size = new System.Drawing.Size(361, 333);
            this.dataGridProduct.TabIndex = 63;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
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
            // txID
            // 
            this.txID.Enabled = false;
            this.txID.Location = new System.Drawing.Point(787, 89);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(21, 20);
            this.txID.TabIndex = 64;
            this.txID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnClean.Location = new System.Drawing.Point(712, 41);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 26);
            this.btnClean.TabIndex = 73;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(658, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 26);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Location = new System.Drawing.Point(441, 45);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(105, 21);
            this.comboBusqueda.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Buscar por";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(787, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 75;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // txPatente
            // 
            this.txPatente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPatente.Location = new System.Drawing.Point(61, 138);
            this.txPatente.Name = "txPatente";
            this.txPatente.Size = new System.Drawing.Size(47, 13);
            this.txPatente.TabIndex = 76;
            // 
            // txPrice
            // 
            this.txPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPrice.Location = new System.Drawing.Point(525, 119);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(65, 13);
            this.txPrice.TabIndex = 77;
            // 
            // txStok
            // 
            this.txStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txStok.Location = new System.Drawing.Point(712, 154);
            this.txStok.Name = "txStok";
            this.txStok.Size = new System.Drawing.Size(19, 13);
            this.txStok.TabIndex = 78;
            // 
            // txAñao
            // 
            this.txAñao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txAñao.Location = new System.Drawing.Point(491, 138);
            this.txAñao.Name = "txAñao";
            this.txAñao.Size = new System.Drawing.Size(55, 13);
            this.txAñao.TabIndex = 79;
            // 
            // txColor
            // 
            this.txColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txColor.Location = new System.Drawing.Point(441, 110);
            this.txColor.Name = "txColor";
            this.txColor.Size = new System.Drawing.Size(43, 13);
            this.txColor.TabIndex = 80;
            // 
            // txDor
            // 
            this.txDor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDor.Location = new System.Drawing.Point(658, 110);
            this.txDor.Name = "txDor";
            this.txDor.Size = new System.Drawing.Size(31, 13);
            this.txDor.TabIndex = 81;
            // 
            // txDescript
            // 
            this.txDescript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDescript.Location = new System.Drawing.Point(166, 295);
            this.txDescript.Name = "txDescript";
            this.txDescript.Size = new System.Drawing.Size(100, 13);
            this.txDescript.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Pantente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Año Fabricacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Cantidad Puertas";
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
            this.txtBusqueda.Location = new System.Drawing.Point(553, 41);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.MultiLine = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusqueda.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PalceHolderText = "Buscar...";
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.Size = new System.Drawing.Size(98, 26);
            this.txtBusqueda.TabIndex = 74;
            this.txtBusqueda.Texts = "";
            this.txtBusqueda.UnderLinedStyle = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.BorderRadius = 21;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(160, 376);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 26);
            this.btnLimpiar.TabIndex = 69;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 26;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(260, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 26);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.guardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.guardar.BorderColor = System.Drawing.Color.White;
            this.guardar.BorderRadius = 26;
            this.guardar.BorderSize = 0;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(61, 376);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(80, 26);
            this.guardar.TabIndex = 67;
            this.guardar.Text = "Guardar";
            this.guardar.TextColor = System.Drawing.Color.White;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // txtdescrip
            // 
            this.txtdescrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdescrip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtdescrip.BorderFocusColor = System.Drawing.Color.Black;
            this.txtdescrip.BorderRadius = 12;
            this.txtdescrip.BorderSize = 1;
            this.txtdescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescrip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdescrip.Location = new System.Drawing.Point(20, 230);
            this.txtdescrip.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescrip.MultiLine = true;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtdescrip.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtdescrip.PalceHolderText = "Descripcion ....";
            this.txtdescrip.PasswordChar = false;
            this.txtdescrip.Size = new System.Drawing.Size(361, 139);
            this.txtdescrip.TabIndex = 32;
            this.txtdescrip.Texts = "";
            this.txtdescrip.UnderLinedStyle = false;
            // 
            // txtAño
            // 
            this.txtAño.BackColor = System.Drawing.Color.White;
            this.txtAño.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtAño.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtAño.BorderRadius = 5;
            this.txtAño.BorderSize = 1;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAño.Location = new System.Drawing.Point(20, 191);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4);
            this.txtAño.MultiLine = false;
            this.txtAño.Name = "txtAño";
            this.txtAño.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAño.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtAño.PalceHolderText = "Año Fabricasao";
            this.txtAño.PasswordChar = false;
            this.txtAño.Size = new System.Drawing.Size(121, 31);
            this.txtAño.TabIndex = 31;
            this.txtAño.Texts = "";
            this.txtAño.UnderLinedStyle = false;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtColor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtColor.BorderRadius = 5;
            this.txtColor.BorderSize = 1;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtColor.Location = new System.Drawing.Point(160, 136);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.MultiLine = false;
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColor.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtColor.PalceHolderText = "Color";
            this.txtColor.PasswordChar = false;
            this.txtColor.Size = new System.Drawing.Size(121, 31);
            this.txtColor.TabIndex = 30;
            this.txtColor.Texts = "";
            this.txtColor.UnderLinedStyle = false;
            // 
            // txtPuerta
            // 
            this.txtPuerta.BackColor = System.Drawing.Color.White;
            this.txtPuerta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtPuerta.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtPuerta.BorderRadius = 5;
            this.txtPuerta.BorderSize = 1;
            this.txtPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPuerta.Location = new System.Drawing.Point(304, 191);
            this.txtPuerta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuerta.MultiLine = false;
            this.txtPuerta.Name = "txtPuerta";
            this.txtPuerta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPuerta.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPuerta.PalceHolderText = "Puertas";
            this.txtPuerta.PasswordChar = false;
            this.txtPuerta.Size = new System.Drawing.Size(77, 31);
            this.txtPuerta.TabIndex = 29;
            this.txtPuerta.Texts = "";
            this.txtPuerta.UnderLinedStyle = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtPrecio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtPrecio.BorderRadius = 5;
            this.txtPrecio.BorderSize = 1;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecio.Location = new System.Drawing.Point(160, 191);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.MultiLine = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecio.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.PalceHolderText = "($) Precio";
            this.txtPrecio.PasswordChar = false;
            this.txtPrecio.Size = new System.Drawing.Size(121, 31);
            this.txtPrecio.TabIndex = 28;
            this.txtPrecio.Texts = "";
            this.txtPrecio.UnderLinedStyle = false;
            // 
            // txtStocke
            // 
            this.txtStocke.BackColor = System.Drawing.Color.White;
            this.txtStocke.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtStocke.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtStocke.BorderRadius = 5;
            this.txtStocke.BorderSize = 1;
            this.txtStocke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStocke.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStocke.Location = new System.Drawing.Point(304, 136);
            this.txtStocke.Margin = new System.Windows.Forms.Padding(4);
            this.txtStocke.MultiLine = false;
            this.txtStocke.Name = "txtStocke";
            this.txtStocke.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStocke.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtStocke.PalceHolderText = "Stock";
            this.txtStocke.PasswordChar = false;
            this.txtStocke.Size = new System.Drawing.Size(77, 31);
            this.txtStocke.TabIndex = 27;
            this.txtStocke.Texts = "";
            this.txtStocke.UnderLinedStyle = false;
            // 
            // txtPatente
            // 
            this.txtPatente.BackColor = System.Drawing.Color.White;
            this.txtPatente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtPatente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtPatente.BorderRadius = 5;
            this.txtPatente.BorderSize = 1;
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPatente.Location = new System.Drawing.Point(20, 136);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatente.MultiLine = false;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPatente.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPatente.PalceHolderText = "Patente";
            this.txtPatente.PasswordChar = false;
            this.txtPatente.Size = new System.Drawing.Size(121, 31);
            this.txtPatente.TabIndex = 26;
            this.txtPatente.Texts = "";
            this.txtPatente.UnderLinedStyle = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPuerta);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStocke);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMark);
            this.Controls.Add(this.labelSuxur);
            this.Controls.Add(this.comboSucur);
            this.Controls.Add(this.txPatente);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.txStok);
            this.Controls.Add(this.txAñao);
            this.Controls.Add(this.txColor);
            this.Controls.Add(this.txDor);
            this.Controls.Add(this.txDescript);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSucur;
        private System.Windows.Forms.Label labelSuxur;
        private System.Windows.Forms.ComboBox comboMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboModel;
        private Controles_graficos.UserControl1 txtPatente;
        private Controles_graficos.UserControl1 txtStocke;
        private Controles_graficos.UserControl1 txtPrecio;
        private Controles_graficos.UserControl1 txtPuerta;
        private Controles_graficos.UserControl1 txtColor;
        private Controles_graficos.UserControl1 txtAño;
        private Controles_graficos.UserControl1 txtdescrip;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.TextBox txID;
        private CustomControls.Controles_graficos.CD_Button btnLimpiar;
        private CustomControls.Controles_graficos.CD_Button btnEliminar;
        private CustomControls.Controles_graficos.CD_Button guardar;
        private Controles_graficos.UserControl1 txtBusqueda;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txPatente;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.TextBox txStok;
        private System.Windows.Forms.TextBox txAñao;
        private System.Windows.Forms.TextBox txColor;
        private System.Windows.Forms.TextBox txDor;
        private System.Windows.Forms.TextBox txDescript;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}