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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprueba = new System.Windows.Forms.TextBox();
            this.txtDocumenPrueba = new System.Windows.Forms.TextBox();
            this.txtnamePrueba = new System.Windows.Forms.TextBox();
            this.txtapellidoPrueba = new System.Windows.Forms.TextBox();
            this.txtcontraseñaPrueba = new System.Windows.Forms.TextBox();
            this.txtemailPrueba = new System.Windows.Forms.TextBox();
            this.dataGridUsser = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new CustomControls.Controles_graficos.CD_Button();
            this.btnEliminar = new CustomControls.Controles_graficos.CD_Button();
            this.guardar = new CustomControls.Controles_graficos.CD_Button();
            this.txtPasword = new BUNIFU.Controles_graficos.UserControl1();
            this.txtApellido = new BUNIFU.Controles_graficos.UserControl1();
            this.txtPhone = new BUNIFU.Controles_graficos.UserControl1();
            this.txtEmail = new BUNIFU.Controles_graficos.UserControl1();
            this.txtName = new BUNIFU.Controles_graficos.UserControl1();
            this.txtDocument = new BUNIFU.Controles_graficos.UserControl1();
            this.txtBusqueda = new BUNIFU.Controles_graficos.UserControl1();
            this.labelSuxur = new System.Windows.Forms.Label();
            this.comboSucur = new System.Windows.Forms.ComboBox();
<<<<<<< HEAD
            this.cD_ComboBox2 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.cD_ComboBox1 = new CustomControls.Controles_graficos.CD_ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
            this.rolid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pasword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsser)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.comboBoxRol.ForeColor = System.Drawing.Color.White;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(170, 127);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 31;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(59, 130);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 16);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Tipo de Usuario";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(332, 130);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Estado";
            // 
            // comboBoxState
            // 
            this.comboBoxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.comboBoxState.ForeColor = System.Drawing.Color.White;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(389, 129);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 34;
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
            this.btnClean.Location = new System.Drawing.Point(432, 189);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 26);
            this.btnClean.TabIndex = 53;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(378, 189);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 26);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.comboBusqueda.ForeColor = System.Drawing.Color.White;
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Location = new System.Drawing.Point(145, 193);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.comboBusqueda.TabIndex = 50;
            this.comboBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBusqueda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(66, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID";
            // 
            // txtprueba
            // 
            this.txtprueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprueba.Location = new System.Drawing.Point(389, 18);
            this.txtprueba.Name = "txtprueba";
            this.txtprueba.Size = new System.Drawing.Size(100, 13);
            this.txtprueba.TabIndex = 56;
            // 
            // txtDocumenPrueba
            // 
            this.txtDocumenPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumenPrueba.Location = new System.Drawing.Point(124, 18);
            this.txtDocumenPrueba.Name = "txtDocumenPrueba";
            this.txtDocumenPrueba.Size = new System.Drawing.Size(100, 13);
            this.txtDocumenPrueba.TabIndex = 57;
            // 
            // txtnamePrueba
            // 
            this.txtnamePrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnamePrueba.Location = new System.Drawing.Point(133, 61);
            this.txtnamePrueba.Name = "txtnamePrueba";
            this.txtnamePrueba.Size = new System.Drawing.Size(100, 13);
            this.txtnamePrueba.TabIndex = 58;
            // 
            // txtapellidoPrueba
            // 
            this.txtapellidoPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellidoPrueba.Location = new System.Drawing.Point(410, 61);
            this.txtapellidoPrueba.Name = "txtapellidoPrueba";
            this.txtapellidoPrueba.Size = new System.Drawing.Size(100, 13);
            this.txtapellidoPrueba.TabIndex = 59;
            // 
            // txtcontraseñaPrueba
            // 
            this.txtcontraseñaPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseñaPrueba.Location = new System.Drawing.Point(366, 100);
            this.txtcontraseñaPrueba.Name = "txtcontraseñaPrueba";
            this.txtcontraseñaPrueba.Size = new System.Drawing.Size(100, 13);
            this.txtcontraseñaPrueba.TabIndex = 60;
            // 
            // txtemailPrueba
            // 
            this.txtemailPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemailPrueba.Location = new System.Drawing.Point(124, 100);
            this.txtemailPrueba.Name = "txtemailPrueba";
            this.txtemailPrueba.Size = new System.Drawing.Size(100, 13);
            this.txtemailPrueba.TabIndex = 61;
            // 
            // dataGridUsser
            // 
            this.dataGridUsser.AllowUserToAddRows = false;
            this.dataGridUsser.AllowUserToDeleteRows = false;
            this.dataGridUsser.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridUsser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
<<<<<<< HEAD
            this.Id_Sucursal,
=======
            this.id_Sucursal,
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
            this.rolid,
            this.idrol,
            this.dni,
            this.name,
            this.apellido,
            this.email,
            this.telefono,
            this.state,
            this.pasword});
            this.dataGridUsser.EnableHeadersVisualStyles = false;
            this.dataGridUsser.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridUsser.Location = new System.Drawing.Point(62, 222);
            this.dataGridUsser.Name = "dataGridUsser";
            this.dataGridUsser.ReadOnly = true;
            this.dataGridUsser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridUsser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsser.Size = new System.Drawing.Size(466, 165);
            this.dataGridUsser.TabIndex = 62;
            this.dataGridUsser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsser_CellContentClick_1);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(605, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 63;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.BorderRadius = 21;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(547, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 26);
            this.btnLimpiar.TabIndex = 66;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 26;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(547, 324);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 26);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.guardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.guardar.BorderColor = System.Drawing.Color.White;
            this.guardar.BorderRadius = 26;
            this.guardar.BorderSize = 0;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(547, 260);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(80, 26);
            this.guardar.TabIndex = 64;
            this.guardar.Text = "Guardar";
            this.guardar.TextColor = System.Drawing.Color.White;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
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
            this.txtPasword.Leave += new System.EventHandler(this.txtPasword_Leave);
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
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
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
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
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
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
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
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
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
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            this.txtDocument.Leave += new System.EventHandler(this.txtDocument_Leave);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.txtBusqueda.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.txtBusqueda.BorderRadius = 15;
            this.txtBusqueda.BorderSize = 1;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBusqueda.Location = new System.Drawing.Point(273, 189);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.MultiLine = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusqueda.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PalceHolderText = "Buscar...";
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.Size = new System.Drawing.Size(97, 31);
            this.txtBusqueda.TabIndex = 90;
            this.txtBusqueda.Texts = "";
            this.txtBusqueda.UnderLinedStyle = false;
            // 
            // labelSuxur
            // 
            this.labelSuxur.AutoSize = true;
            this.labelSuxur.Location = new System.Drawing.Point(59, 151);
            this.labelSuxur.Name = "labelSuxur";
            this.labelSuxur.Size = new System.Drawing.Size(115, 13);
<<<<<<< HEAD
            this.labelSuxur.TabIndex = 107;
=======
            this.labelSuxur.TabIndex = 105;
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
            this.labelSuxur.Text = "Seleccione la Sucursal";
            // 
            // comboSucur
            // 
            this.comboSucur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.comboSucur.FormattingEnabled = true;
            this.comboSucur.Location = new System.Drawing.Point(62, 167);
            this.comboSucur.Name = "comboSucur";
<<<<<<< HEAD
            this.comboSucur.Size = new System.Drawing.Size(364, 21);
            this.comboSucur.TabIndex = 106;
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
            this.cD_ComboBox2.Location = new System.Drawing.Point(346, 160);
            this.cD_ComboBox2.MaximumSize = new System.Drawing.Size(0, 100);
            this.cD_ComboBox2.MinimumSize = new System.Drawing.Size(0, 27);
            this.cD_ComboBox2.Name = "cD_ComboBox2";
            this.cD_ComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cD_ComboBox2.Size = new System.Drawing.Size(0, 27);
            this.cD_ComboBox2.TabIndex = 105;
            this.cD_ComboBox2.Texts = "";
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
            this.cD_ComboBox1.Location = new System.Drawing.Point(132, 160);
            this.cD_ComboBox1.MaximumSize = new System.Drawing.Size(0, 100);
            this.cD_ComboBox1.MinimumSize = new System.Drawing.Size(0, 27);
            this.cD_ComboBox1.Name = "cD_ComboBox1";
            this.cD_ComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cD_ComboBox1.Size = new System.Drawing.Size(0, 27);
            this.cD_ComboBox1.TabIndex = 104;
            this.cD_ComboBox1.Texts = "";
=======
            this.comboSucur.Size = new System.Drawing.Size(361, 21);
            this.comboSucur.TabIndex = 104;
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
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
<<<<<<< HEAD
            // Id_Sucursal
            // 
            this.Id_Sucursal.HeaderText = "Id_Sucursal";
            this.Id_Sucursal.Name = "Id_Sucursal";
            this.Id_Sucursal.ReadOnly = true;
=======
            // id_Sucursal
            // 
            this.id_Sucursal.HeaderText = "id_Sucursal";
            this.id_Sucursal.Name = "id_Sucursal";
            this.id_Sucursal.ReadOnly = true;
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
            // 
            // rolid
            // 
            this.rolid.HeaderText = "Rolid";
            this.rolid.Name = "rolid";
            this.rolid.ReadOnly = true;
            this.rolid.Visible = false;
            // 
            // idrol
            // 
            this.idrol.HeaderText = "Rol";
            this.idrol.Name = "idrol";
            this.idrol.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "Documento";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = " Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Phone";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
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
            // pasword
            // 
            this.pasword.HeaderText = "Contraseña";
            this.pasword.Name = "pasword";
            this.pasword.ReadOnly = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.labelSuxur);
            this.Controls.Add(this.comboSucur);
<<<<<<< HEAD
            this.Controls.Add(this.cD_ComboBox2);
            this.Controls.Add(this.cD_ComboBox1);
=======
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridUsser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtprueba);
            this.Controls.Add(this.txtapellidoPrueba);
            this.Controls.Add(this.txtnamePrueba);
            this.Controls.Add(this.txtDocumenPrueba);
            this.Controls.Add(this.txtemailPrueba);
            this.Controls.Add(this.txtcontraseñaPrueba);
            this.DoubleBuffered = true;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsser)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox comboBoxState;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprueba;
        private System.Windows.Forms.TextBox txtDocumenPrueba;
        private System.Windows.Forms.TextBox txtnamePrueba;
        private System.Windows.Forms.TextBox txtapellidoPrueba;
        private System.Windows.Forms.TextBox txtcontraseñaPrueba;
        private System.Windows.Forms.TextBox txtemailPrueba;
        private System.Windows.Forms.DataGridView dataGridUsser;
        private System.Windows.Forms.TextBox textBox2;
        private CustomControls.Controles_graficos.CD_Button guardar;
        private CustomControls.Controles_graficos.CD_Button btnEliminar;
        private CustomControls.Controles_graficos.CD_Button btnLimpiar;
        private Controles_graficos.UserControl1 txtBusqueda;
        private System.Windows.Forms.Label labelSuxur;
        private System.Windows.Forms.ComboBox comboSucur;
<<<<<<< HEAD
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox2;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Sucursal;
=======
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Sucursal;
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
        private System.Windows.Forms.DataGridViewTextBoxColumn rolid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasword;
    }
}