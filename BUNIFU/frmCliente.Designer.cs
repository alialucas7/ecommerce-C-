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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ComboBoxEstado = new System.Windows.Forms.ComboBox();
            this.ComboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cD_Button3 = new CustomControls.Controles_graficos.CD_Button();
            this.cD_Button2 = new CustomControls.Controles_graficos.CD_Button();
            this.cD_Button1 = new CustomControls.Controles_graficos.CD_Button();
            this.userControl12 = new BUNIFU.Controles_graficos.UserControl1();
            this.cD_ComboBox3 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.txtTelefono = new BUNIFU.Controles_graficos.UserControl1();
            this.txtEmail = new BUNIFU.Controles_graficos.UserControl1();
            this.txtApellido = new BUNIFU.Controles_graficos.UserControl1();
            this.txtNombre = new BUNIFU.Controles_graficos.UserControl1();
            this.txtDocument = new BUNIFU.Controles_graficos.UserControl1();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha_Creación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id_Cliente,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Telefono,
            this.Estado,
            this.Fecha_Creación});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(62, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Size = new System.Drawing.Size(466, 165);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // textId
            // 
            this.textId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textId.BackColor = System.Drawing.Color.White;
            this.textId.Enabled = false;
            this.textId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textId.Location = new System.Drawing.Point(604, 18);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(17, 20);
            this.textId.TabIndex = 42;
            this.textId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(322, 109);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel1.TabIndex = 80;
            this.bunifuCustomLabel1.Text = "Estado";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(71, 185);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(73, 16);
            this.bunifuCustomLabel3.TabIndex = 82;
            this.bunifuCustomLabel3.Text = "Buscar por";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(394, 177);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 29);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClean.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 27;
            this.btnClean.Location = new System.Drawing.Point(448, 177);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 30);
            this.btnClean.TabIndex = 89;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(132, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 94;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(120, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 95;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(132, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 96;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(381, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 97;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(381, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 98;
            this.textBox5.Visible = false;
            // 
            // ComboBoxEstado
            // 
            this.ComboBoxEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.ComboBoxEstado.ForeColor = System.Drawing.Color.White;
            this.ComboBoxEstado.FormattingEnabled = true;
            this.ComboBoxEstado.Location = new System.Drawing.Point(369, 107);
            this.ComboBoxEstado.Name = "ComboBoxEstado";
            this.ComboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxEstado.TabIndex = 99;
            // 
            // ComboBoxBuscar
            // 
            this.ComboBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.ComboBoxBuscar.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBuscar.FormattingEnabled = true;
            this.ComboBoxBuscar.Location = new System.Drawing.Point(150, 185);
            this.ComboBoxBuscar.Name = "ComboBoxBuscar";
            this.ComboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBuscar.TabIndex = 100;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(604, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(17, 20);
            this.textBox6.TabIndex = 101;
            this.textBox6.Visible = false;
            // 
            // cD_Button3
            // 
            this.cD_Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cD_Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.cD_Button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.cD_Button3.BorderColor = System.Drawing.Color.White;
            this.cD_Button3.BorderRadius = 21;
            this.cD_Button3.BorderSize = 0;
            this.cD_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cD_Button3.FlatAppearance.BorderSize = 0;
            this.cD_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cD_Button3.ForeColor = System.Drawing.Color.White;
            this.cD_Button3.Location = new System.Drawing.Point(541, 273);
            this.cD_Button3.Name = "cD_Button3";
            this.cD_Button3.Size = new System.Drawing.Size(80, 26);
            this.cD_Button3.TabIndex = 93;
            this.cD_Button3.Text = "Limpiar";
            this.cD_Button3.TextColor = System.Drawing.Color.White;
            this.cD_Button3.UseVisualStyleBackColor = false;
            this.cD_Button3.Click += new System.EventHandler(this.cD_Button3_Click);
            // 
            // cD_Button2
            // 
            this.cD_Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cD_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.cD_Button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.cD_Button2.BorderColor = System.Drawing.Color.White;
            this.cD_Button2.BorderRadius = 26;
            this.cD_Button2.BorderSize = 0;
            this.cD_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cD_Button2.FlatAppearance.BorderSize = 0;
            this.cD_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cD_Button2.ForeColor = System.Drawing.Color.White;
            this.cD_Button2.Location = new System.Drawing.Point(541, 305);
            this.cD_Button2.Name = "cD_Button2";
            this.cD_Button2.Size = new System.Drawing.Size(80, 26);
            this.cD_Button2.TabIndex = 92;
            this.cD_Button2.Text = "Eliminar";
            this.cD_Button2.TextColor = System.Drawing.Color.White;
            this.cD_Button2.UseVisualStyleBackColor = false;
            this.cD_Button2.Click += new System.EventHandler(this.cD_Button2_Click_1);
            // 
            // cD_Button1
            // 
            this.cD_Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cD_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.cD_Button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.cD_Button1.BorderColor = System.Drawing.Color.White;
            this.cD_Button1.BorderRadius = 26;
            this.cD_Button1.BorderSize = 0;
            this.cD_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cD_Button1.FlatAppearance.BorderSize = 0;
            this.cD_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cD_Button1.ForeColor = System.Drawing.Color.White;
            this.cD_Button1.Location = new System.Drawing.Point(541, 241);
            this.cD_Button1.Name = "cD_Button1";
            this.cD_Button1.Size = new System.Drawing.Size(80, 26);
            this.cD_Button1.TabIndex = 91;
            this.cD_Button1.Text = "Guardar";
            this.cD_Button1.TextColor = System.Drawing.Color.White;
            this.cD_Button1.UseVisualStyleBackColor = false;
            this.cD_Button1.Click += new System.EventHandler(this.cD_Button1_Click_1);
            // 
            // userControl12
            // 
            this.userControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userControl12.BackColor = System.Drawing.Color.White;
            this.userControl12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.userControl12.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.userControl12.BorderRadius = 15;
            this.userControl12.BorderSize = 1;
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl12.Location = new System.Drawing.Point(278, 177);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4);
            this.userControl12.MultiLine = false;
            this.userControl12.Name = "userControl12";
            this.userControl12.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl12.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl12.PalceHolderText = "Buscar...";
            this.userControl12.PasswordChar = false;
            this.userControl12.Size = new System.Drawing.Size(109, 31);
            this.userControl12.TabIndex = 90;
            this.userControl12.Texts = "";
            this.userControl12.UnderLinedStyle = false;
            this.userControl12._Textchanged += new System.EventHandler(this.userControl12__Textchanged_1);
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
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.BorderSize = 1;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefono.Location = new System.Drawing.Point(292, 58);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MultiLine = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PalceHolderText = "Telefono";
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.Size = new System.Drawing.Size(225, 31);
            this.txtTelefono.TabIndex = 76;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderLinedStyle = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(292, 18);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PalceHolderText = "Email";
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(225, 31);
            this.txtEmail.TabIndex = 75;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderLinedStyle = false;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtApellido.BorderRadius = 15;
            this.txtApellido.BorderSize = 1;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellido.Location = new System.Drawing.Point(46, 58);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MultiLine = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PalceHolderText = "Apellido";
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(225, 31);
            this.txtApellido.TabIndex = 74;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderLinedStyle = false;
            this.txtApellido._Textchanged += new System.EventHandler(this.txtEmail__Textchanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(46, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MultiLine = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PalceHolderText = "Nombre";
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(225, 31);
            this.txtNombre.TabIndex = 73;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderLinedStyle = false;
            this.txtNombre._Textchanged += new System.EventHandler(this.txtName__Textchanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtDocument
            // 
            this.txtDocument.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDocument.BackColor = System.Drawing.Color.White;
            this.txtDocument.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.txtDocument.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
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
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            this.txtDocument.Leave += new System.EventHandler(this.txtDocument_Leave_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "S";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 37;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.Id_Cliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id_Cliente.HeaderText = "Id_Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Width = 15;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DNI.DefaultCellStyle = dataGridViewCellStyle4;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle6;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 81;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Email.DefaultCellStyle = dataGridViewCellStyle7;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 62;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle8;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 82;
            // 
            // Estado
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle9.NullValue = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle9;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Fecha_Creación
            // 
            this.Fecha_Creación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Fecha_Creación.DefaultCellStyle = dataGridViewCellStyle10;
            this.Fecha_Creación.HeaderText = "Fecha_Creación";
            this.Fecha_Creación.Name = "Fecha_Creación";
            this.Fecha_Creación.ReadOnly = true;
            this.Fecha_Creación.Visible = false;
            this.Fecha_Creación.Width = 129;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ComboBoxBuscar);
            this.Controls.Add(this.ComboBoxEstado);
            this.Controls.Add(this.cD_Button3);
            this.Controls.Add(this.cD_Button2);
            this.Controls.Add(this.cD_Button1);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cD_ComboBox3);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.Click += new System.EventHandler(this.label2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private Controles_graficos.UserControl1 txtDocument;
        private Controles_graficos.UserControl1 txtNombre;
        private Controles_graficos.UserControl1 txtApellido;
        private Controles_graficos.UserControl1 txtEmail;
        private Controles_graficos.UserControl1 txtTelefono;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnClean;
        private Controles_graficos.UserControl1 userControl12;
        private CustomControls.Controles_graficos.CD_Button cD_Button1;
        private CustomControls.Controles_graficos.CD_Button cD_Button2;
        private CustomControls.Controles_graficos.CD_Button cD_Button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox ComboBoxEstado;
        private System.Windows.Forms.ComboBox ComboBoxBuscar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Creación;
    }
}