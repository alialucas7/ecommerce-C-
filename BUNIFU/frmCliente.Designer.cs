namespace BUNIFU
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.S = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha_Creación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cD_Button2 = new CustomControls.Controles_graficos.CD_Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDocument = new BUNIFU.Controles_graficos.UserControl1();
            this.txtName = new BUNIFU.Controles_graficos.UserControl1();
            this.txtEmail = new BUNIFU.Controles_graficos.UserControl1();
            this.userControl11 = new BUNIFU.Controles_graficos.UserControl1();
            this.txtPhone = new BUNIFU.Controles_graficos.UserControl1();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cD_ComboBox1 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cD_ComboBox2 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cD_ComboBox3 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.cD_ComboBox4 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.cD_ComboBox5 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.cD_ComboBox6 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.userControl12 = new BUNIFU.Controles_graficos.UserControl1();
            this.cD_Button1 = new CustomControls.Controles_graficos.CD_Button();
            this.cD_Button3 = new CustomControls.Controles_graficos.CD_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S,
            this.Id_Cliente,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Teléfono,
            this.Estado,
            this.Fecha_Creación});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(24, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(524, 131);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // S
            // 
            this.S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.S.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.S.Width = 37;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id_Cliente.HeaderText = "Id_Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Width = 90;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.Width = 52;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 79;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 81;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 62;
            // 
            // Teléfono
            // 
            this.Teléfono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.Width = 82;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Fecha_Creación
            // 
            this.Fecha_Creación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Fecha_Creación.HeaderText = "Fecha_Creación";
            this.Fecha_Creación.Name = "Fecha_Creación";
            this.Fecha_Creación.Width = 129;
            // 
            // cD_Button2
            // 
            this.cD_Button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.cD_Button2.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.cD_Button2.BorderColor = System.Drawing.Color.SkyBlue;
            this.cD_Button2.BorderRadius = 22;
            this.cD_Button2.BorderSize = 0;
            this.cD_Button2.FlatAppearance.BorderSize = 0;
            this.cD_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cD_Button2.ForeColor = System.Drawing.Color.White;
            this.cD_Button2.Location = new System.Drawing.Point(554, 229);
            this.cD_Button2.Name = "cD_Button2";
            this.cD_Button2.Size = new System.Drawing.Size(89, 29);
            this.cD_Button2.TabIndex = 41;
            this.cD_Button2.Text = "Guardar";
            this.cD_Button2.TextColor = System.Drawing.Color.White;
            this.cD_Button2.UseVisualStyleBackColor = false;
            this.cD_Button2.Click += new System.EventHandler(this.cD_Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(579, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(604, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(17, 20);
            this.textBox1.TabIndex = 42;
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
            this.txtDocument.Location = new System.Drawing.Point(46, 18);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocument.MultiLine = false;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocument.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtDocument.PalceHolderText = "Documento";
            this.txtDocument.PasswordChar = false;
            this.txtDocument.Size = new System.Drawing.Size(225, 31);
            this.txtDocument.TabIndex = 72;
            this.txtDocument.Texts = "";
            this.txtDocument.UnderLinedStyle = false;
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
            this.txtName.Location = new System.Drawing.Point(46, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtName.PalceHolderText = "Nombre";
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(225, 31);
            this.txtName.TabIndex = 73;
            this.txtName.Texts = "";
            this.txtName.UnderLinedStyle = false;
            this.txtName._Textchanged += new System.EventHandler(this.txtName__Textchanged);
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
            this.txtEmail.Location = new System.Drawing.Point(46, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PalceHolderText = "Apellido";
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(225, 31);
            this.txtEmail.TabIndex = 74;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderLinedStyle = false;
            this.txtEmail._Textchanged += new System.EventHandler(this.txtEmail__Textchanged);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.userControl11.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.userControl11.BorderRadius = 15;
            this.userControl11.BorderSize = 1;
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl11.Location = new System.Drawing.Point(292, 18);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.MultiLine = false;
            this.userControl11.Name = "userControl11";
            this.userControl11.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl11.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl11.PalceHolderText = "Email";
            this.userControl11.PasswordChar = false;
            this.userControl11.Size = new System.Drawing.Size(225, 31);
            this.userControl11.TabIndex = 75;
            this.userControl11.Texts = "";
            this.userControl11.UnderLinedStyle = false;
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
            this.txtPhone.Location = new System.Drawing.Point(292, 58);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MultiLine = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PalceHolderText = "Telefono";
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Size = new System.Drawing.Size(225, 31);
            this.txtPhone.TabIndex = 76;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderLinedStyle = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 141);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 16);
            this.bunifuCustomLabel2.TabIndex = 78;
            this.bunifuCustomLabel2.Text = "Tipo de Usuario";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click_1);
            // 
            // cD_ComboBox1
            // 
            this.cD_ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cD_ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cD_ComboBox1.BackColor = System.Drawing.Color.White;
            this.cD_ComboBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cD_ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox1.BorderSize = 1;
            this.cD_ComboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cD_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cD_ComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox1.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd",
            "eee"});
            this.cD_ComboBox1.ListBackColor = System.Drawing.Color.White;
            this.cD_ComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.cD_ComboBox1.Location = new System.Drawing.Point(132, 141);
            this.cD_ComboBox1.MaximumSize = new System.Drawing.Size(0, 100);
            this.cD_ComboBox1.MinimumSize = new System.Drawing.Size(0, 27);
            this.cD_ComboBox1.Name = "cD_ComboBox1";
            this.cD_ComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cD_ComboBox1.Size = new System.Drawing.Size(0, 27);
            this.cD_ComboBox1.TabIndex = 79;
            this.cD_ComboBox1.Texts = "";
            this.cD_ComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.cD_ComboBox1_OnSelectedIndexChanged_3);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(289, 141);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel1.TabIndex = 80;
            this.bunifuCustomLabel1.Text = "Estado";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // cD_ComboBox2
            // 
            this.cD_ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cD_ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cD_ComboBox2.BackColor = System.Drawing.Color.White;
            this.cD_ComboBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cD_ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox2.BorderSize = 1;
            this.cD_ComboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cD_ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cD_ComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox2.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd",
            "eee"});
            this.cD_ComboBox2.ListBackColor = System.Drawing.Color.White;
            this.cD_ComboBox2.ListTextColor = System.Drawing.Color.Black;
            this.cD_ComboBox2.Location = new System.Drawing.Point(346, 141);
            this.cD_ComboBox2.MaximumSize = new System.Drawing.Size(0, 100);
            this.cD_ComboBox2.MinimumSize = new System.Drawing.Size(0, 27);
            this.cD_ComboBox2.Name = "cD_ComboBox2";
            this.cD_ComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cD_ComboBox2.Size = new System.Drawing.Size(0, 27);
            this.cD_ComboBox2.TabIndex = 81;
            this.cD_ComboBox2.Texts = "";
            this.cD_ComboBox2.OnSelectedIndexChanged += new System.EventHandler(this.cD_ComboBox2_OnSelectedIndexChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(43, 181);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(73, 16);
            this.bunifuCustomLabel3.TabIndex = 82;
            this.bunifuCustomLabel3.Text = "Buscar por";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // cD_ComboBox3
            // 
            this.cD_ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cD_ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cD_ComboBox3.BackColor = System.Drawing.Color.White;
            this.cD_ComboBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cD_ComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox3.BorderSize = 1;
            this.cD_ComboBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cD_ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cD_ComboBox3.ForeColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox3.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd",
            "eee"});
            this.cD_ComboBox3.ListBackColor = System.Drawing.Color.White;
            this.cD_ComboBox3.ListTextColor = System.Drawing.Color.Black;
            this.cD_ComboBox3.Location = new System.Drawing.Point(132, 181);
            this.cD_ComboBox3.MaximumSize = new System.Drawing.Size(0, 100);
            this.cD_ComboBox3.MinimumSize = new System.Drawing.Size(0, 27);
            this.cD_ComboBox3.Name = "cD_ComboBox3";
            this.cD_ComboBox3.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cD_ComboBox3.Size = new System.Drawing.Size(0, 27);
            this.cD_ComboBox3.TabIndex = 83;
            this.cD_ComboBox3.Texts = "";
            // 
            // cD_ComboBox4
            // 
            this.cD_ComboBox4.BackColor = System.Drawing.Color.White;
            this.cD_ComboBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox4.BorderSize = 1;
            this.cD_ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cD_ComboBox4.ForeColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox4.ListBackColor = System.Drawing.Color.White;
            this.cD_ComboBox4.ListTextColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox4.Location = new System.Drawing.Point(125, 138);
            this.cD_ComboBox4.MinimumSize = new System.Drawing.Size(100, 30);
            this.cD_ComboBox4.Name = "cD_ComboBox4";
            this.cD_ComboBox4.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox4.Size = new System.Drawing.Size(146, 30);
            this.cD_ComboBox4.TabIndex = 84;
            this.cD_ComboBox4.Texts = "";
            this.cD_ComboBox4.OnSelectedIndexChanged += new System.EventHandler(this.cD_ComboBox4_OnSelectedIndexChanged);
            // 
            // cD_ComboBox5
            // 
            this.cD_ComboBox5.BackColor = System.Drawing.Color.White;
            this.cD_ComboBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox5.BorderSize = 1;
            this.cD_ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cD_ComboBox5.ForeColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox5.ListBackColor = System.Drawing.Color.White;
            this.cD_ComboBox5.ListTextColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox5.Location = new System.Drawing.Point(346, 138);
            this.cD_ComboBox5.MinimumSize = new System.Drawing.Size(100, 30);
            this.cD_ComboBox5.Name = "cD_ComboBox5";
            this.cD_ComboBox5.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox5.Size = new System.Drawing.Size(146, 30);
            this.cD_ComboBox5.TabIndex = 85;
            this.cD_ComboBox5.Texts = "";
            // 
            // cD_ComboBox6
            // 
            this.cD_ComboBox6.BackColor = System.Drawing.Color.White;
            this.cD_ComboBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox6.BorderSize = 1;
            this.cD_ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cD_ComboBox6.ForeColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cD_ComboBox6.ListBackColor = System.Drawing.Color.White;
            this.cD_ComboBox6.ListTextColor = System.Drawing.Color.DimGray;
            this.cD_ComboBox6.Location = new System.Drawing.Point(125, 174);
            this.cD_ComboBox6.MaximumSize = new System.Drawing.Size(100, 30);
            this.cD_ComboBox6.MinimumSize = new System.Drawing.Size(100, 30);
            this.cD_ComboBox6.Name = "cD_ComboBox6";
            this.cD_ComboBox6.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox6.Size = new System.Drawing.Size(100, 30);
            this.cD_ComboBox6.TabIndex = 86;
            this.cD_ComboBox6.Texts = "";
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
            this.btnBuscar.Location = new System.Drawing.Point(346, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 25);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            this.btnClean.Location = new System.Drawing.Point(400, 179);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 25);
            this.btnClean.TabIndex = 89;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.White;
            this.userControl12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.userControl12.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.userControl12.BorderRadius = 15;
            this.userControl12.BorderSize = 1;
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl12.Location = new System.Drawing.Point(242, 175);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4);
            this.userControl12.MultiLine = false;
            this.userControl12.Name = "userControl12";
            this.userControl12.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl12.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl12.PalceHolderText = "Buscar...";
            this.userControl12.PasswordChar = false;
            this.userControl12.Size = new System.Drawing.Size(97, 31);
            this.userControl12.TabIndex = 90;
            this.userControl12.Texts = "";
            this.userControl12.UnderLinedStyle = false;
            this.userControl12._Textchanged += new System.EventHandler(this.userControl12__Textchanged_1);
            // 
            // cD_Button1
            // 
            this.cD_Button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.cD_Button1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.cD_Button1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cD_Button1.BorderRadius = 22;
            this.cD_Button1.BorderSize = 0;
            this.cD_Button1.FlatAppearance.BorderSize = 0;
            this.cD_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cD_Button1.ForeColor = System.Drawing.Color.White;
            this.cD_Button1.Location = new System.Drawing.Point(554, 264);
            this.cD_Button1.Name = "cD_Button1";
            this.cD_Button1.Size = new System.Drawing.Size(89, 29);
            this.cD_Button1.TabIndex = 91;
            this.cD_Button1.Text = "Editar";
            this.cD_Button1.TextColor = System.Drawing.Color.White;
            this.cD_Button1.UseVisualStyleBackColor = false;
            this.cD_Button1.Click += new System.EventHandler(this.cD_Button1_Click);
            // 
            // cD_Button3
            // 
            this.cD_Button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.cD_Button3.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.cD_Button3.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cD_Button3.BorderRadius = 22;
            this.cD_Button3.BorderSize = 0;
            this.cD_Button3.FlatAppearance.BorderSize = 0;
            this.cD_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cD_Button3.ForeColor = System.Drawing.Color.White;
            this.cD_Button3.Location = new System.Drawing.Point(554, 299);
            this.cD_Button3.Name = "cD_Button3";
            this.cD_Button3.Size = new System.Drawing.Size(89, 29);
            this.cD_Button3.TabIndex = 92;
            this.cD_Button3.Text = "Borrar";
            this.cD_Button3.TextColor = System.Drawing.Color.White;
            this.cD_Button3.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.cD_Button3);
            this.Controls.Add(this.cD_Button1);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cD_ComboBox6);
            this.Controls.Add(this.cD_ComboBox5);
            this.Controls.Add(this.cD_ComboBox4);
            this.Controls.Add(this.cD_ComboBox3);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.cD_ComboBox2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cD_ComboBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cD_Button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Click += new System.EventHandler(this.label2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Creación;
        private CustomControls.Controles_graficos.CD_Button cD_Button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private Controles_graficos.UserControl1 txtDocument;
        private Controles_graficos.UserControl1 txtName;
        private Controles_graficos.UserControl1 txtEmail;
        private Controles_graficos.UserControl1 userControl11;
        private Controles_graficos.UserControl1 txtPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox3;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox4;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox5;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox6;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnClean;
        private Controles_graficos.UserControl1 userControl12;
        private CustomControls.Controles_graficos.CD_Button cD_Button1;
        private CustomControls.Controles_graficos.CD_Button cD_Button3;
    }
}