namespace BUNIFU
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomDataGrid11 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_dealershipDataSet = new BUNIFU.BD_dealershipDataSet();
            this.usuarioTableAdapter = new BUNIFU.BD_dealershipDataSetTableAdapters.UsuarioTableAdapter();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasword = new BUNIFU.Controles_graficos.UserControl1();
            this.txtApellido = new BUNIFU.Controles_graficos.UserControl1();
            this.txtPhone = new BUNIFU.Controles_graficos.UserControl1();
            this.txtEmail = new BUNIFU.Controles_graficos.UserControl1();
            this.txtName = new BUNIFU.Controles_graficos.UserControl1();
            this.txtDocument = new BUNIFU.Controles_graficos.UserControl1();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_dealershipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(156, 127);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 31;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(68, 130);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 13);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Tipo de Usuario";
            // 
            // bunifuCustomDataGrid11
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid11.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid11.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid11.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid11.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
            this.dni,
            this.pasword,
            this.name,
            this.apellido,
            this.email,
            this.telefono,
            this.idrol,
            this.estado,
            this.date});
            this.bunifuCustomDataGrid11.DataSource = this.usuarioBindingSource;
            this.bunifuCustomDataGrid11.DoubleBuffered = true;
            this.bunifuCustomDataGrid11.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid11.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomDataGrid11.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.bunifuCustomDataGrid11.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid11.Location = new System.Drawing.Point(47, 222);
            this.bunifuCustomDataGrid11.Name = "bunifuCustomDataGrid11";
            this.bunifuCustomDataGrid11.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid11.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.bunifuCustomDataGrid11.Size = new System.Drawing.Size(481, 165);
            this.bunifuCustomDataGrid11.StandardTab = true;
            this.bunifuCustomDataGrid11.TabIndex = 33;
            this.bunifuCustomDataGrid11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid11_CellContentClick);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bD_dealershipDataSet;
            // 
            // bD_dealershipDataSet
            // 
            this.bD_dealershipDataSet.DataSetName = "BD_dealershipDataSet";
            this.bD_dealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(343, 135);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Estado";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(389, 132);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClean.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 27;
            this.btnClean.Location = new System.Drawing.Point(432, 190);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 25);
            this.btnClean.TabIndex = 53;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 52;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(378, 190);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 25);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Location = new System.Drawing.Point(145, 193);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.comboBusqueda.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Buscar por";
            // 
            // txtIndice
            // 
            this.txtIndice.Enabled = false;
            this.txtIndice.Location = new System.Drawing.Point(605, 22);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(22, 20);
            this.txtIndice.TabIndex = 54;
            this.txtIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "id";
            // 
            // txtPasword
            // 
            this.txtPasword.BackColor = System.Drawing.Color.White;
            this.txtPasword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtPasword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtPasword.BorderRadius = 15;
            this.txtPasword.BorderSize = 1;
            this.txtPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPasword.Location = new System.Drawing.Point(322, 89);
            this.txtPasword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasword.MultiLine = false;
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPasword.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPasword.PalceHolderText = "Contraseña";
            this.txtPasword.PasswordChar = false;
            this.txtPasword.Size = new System.Drawing.Size(225, 31);
            this.txtPasword.TabIndex = 30;
            this.txtPasword.Texts = "";
            this.txtPasword.UnderLinedStyle = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtApellido.BorderRadius = 15;
            this.txtApellido.BorderSize = 1;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellido.Location = new System.Drawing.Point(322, 50);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MultiLine = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PalceHolderText = "Apellido";
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(225, 31);
            this.txtApellido.TabIndex = 29;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderLinedStyle = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtPhone.BorderRadius = 15;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhone.Location = new System.Drawing.Point(322, 11);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MultiLine = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PalceHolderText = "Telefono";
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Size = new System.Drawing.Size(225, 31);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderLinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(62, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PalceHolderText = "Email";
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(225, 31);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderLinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtName.BorderRadius = 15;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(62, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtName.PalceHolderText = "Name";
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(225, 31);
            this.txtName.TabIndex = 26;
            this.txtName.Texts = "";
            this.txtName.UnderLinedStyle = false;
            // 
            // txtDocument
            // 
            this.txtDocument.BackColor = System.Drawing.Color.White;
            this.txtDocument.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtDocument.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtDocument.BorderRadius = 15;
            this.txtDocument.BorderSize = 1;
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocument.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDocument.Location = new System.Drawing.Point(62, 11);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocument.MultiLine = false;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocument.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtDocument.PalceHolderText = "Documento";
            this.txtDocument.PasswordChar = false;
            this.txtDocument.Size = new System.Drawing.Size(225, 31);
            this.txtDocument.TabIndex = 25;
            this.txtDocument.Texts = "";
            this.txtDocument.UnderLinedStyle = false;
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "S";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.Text = "";
            this.btnSeleccionar.UseColumnTextForButtonValue = true;
            this.btnSeleccionar.Width = 20;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_usuario";
            this.id.HeaderText = "id_usuario";
            this.id.MinimumWidth = 3;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "dni";
            this.dni.Name = "dni";
            // 
            // pasword
            // 
            this.pasword.DataPropertyName = "pasword";
            this.pasword.HeaderText = "pasword";
            this.pasword.Name = "pasword";
            this.pasword.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "nombre";
            this.name.Name = "name";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // idrol
            // 
            this.idrol.DataPropertyName = "id_rol";
            this.idrol.HeaderText = "id_rol";
            this.idrol.Name = "idrol";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // date
            // 
            this.date.DataPropertyName = "fecha_creacion";
            this.date.HeaderText = "fecha_creacion";
            this.date.Name = "date";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.bunifuCustomDataGrid11);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDocument);
            this.DoubleBuffered = true;
            this.Name = "frmUsuarios";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_dealershipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles_graficos.UserControl1 txtDocument;
        private Controles_graficos.UserControl1 txtName;
        private Controles_graficos.UserControl1 txtEmail;
        private Controles_graficos.UserControl1 txtPhone;
        private Controles_graficos.UserControl1 txtApellido;
        private Controles_graficos.UserControl1 txtPasword;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid11;
        private BD_dealershipDataSet bD_dealershipDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BD_dealershipDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private FontAwesome.Sharp.IconButton btnClean;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasword;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}