namespace BUNIFU
{
    partial class frmReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscarPor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.FechaInicio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FechaFin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Creación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescargaExcel = new FontAwesome.Sharp.IconButton();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCargarData = new CustomControls.Controles_graficos.CD_Button();
            this.BuscarPorFecha = new CustomControls.Controles_graficos.CD_Button();
            this.userBuscar = new BUNIFU.Controles_graficos.UserControl1();
            this.cD_ComboBox3 = new CustomControls.Controles_graficos.CD_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 79);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaInicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(202, 54);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(114, 20);
            this.dateTimeFechaInicio.TabIndex = 2;
            // 
            // dateTimeFechaFin
            // 
            this.dateTimeFechaFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaFin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaFin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dateTimeFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaFin.Location = new System.Drawing.Point(433, 54);
            this.dateTimeFechaFin.Name = "dateTimeFechaFin";
            this.dateTimeFechaFin.Size = new System.Drawing.Size(114, 20);
            this.dateTimeFechaFin.TabIndex = 4;
            // 
            // ComboBoxBuscarPor
            // 
            this.ComboBoxBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.ComboBoxBuscarPor.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBuscarPor.FormattingEnabled = true;
            this.ComboBoxBuscarPor.Location = new System.Drawing.Point(217, 111);
            this.ComboBoxBuscarPor.Name = "ComboBoxBuscarPor";
            this.ComboBoxBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBuscarPor.TabIndex = 104;
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.AutoSize = true;
            this.txtBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarPor.Location = new System.Drawing.Point(161, 114);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(58, 13);
            this.txtBuscarPor.TabIndex = 101;
            this.txtBuscarPor.Text = "Buscar por";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClean.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 27;
            this.btnClean.Location = new System.Drawing.Point(511, 105);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(40, 30);
            this.btnClean.TabIndex = 106;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(468, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 30);
            this.btnBuscar.TabIndex = 105;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSize = true;
            this.FechaInicio.BackColor = System.Drawing.Color.White;
            this.FechaInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.ForeColor = System.Drawing.Color.Black;
            this.FechaInicio.Location = new System.Drawing.Point(128, 54);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(68, 13);
            this.FechaInicio.TabIndex = 107;
            this.FechaInicio.Text = "Fecha Inicio:";
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSize = true;
            this.FechaFin.BackColor = System.Drawing.Color.White;
            this.FechaFin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FechaFin.Location = new System.Drawing.Point(370, 54);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(57, 13);
            this.FechaFin.TabIndex = 108;
            this.FechaFin.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 52);
            this.label2.TabIndex = 113;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.AllowUserToAddRows = false;
            this.dataGridViewReporte.AllowUserToDeleteRows = false;
            this.dataGridViewReporte.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id_Cliente,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Telefono,
            this.Estado,
            this.Fecha_Creación,
            this.precioVenta,
            this.Subtotal,
            this.Cantidad});
            this.dataGridViewReporte.EnableHeadersVisualStyles = false;
            this.dataGridViewReporte.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewReporte.Location = new System.Drawing.Point(113, 155);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.ReadOnly = true;
            this.dataGridViewReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReporte.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewReporte.Size = new System.Drawing.Size(605, 116);
            this.dataGridViewReporte.TabIndex = 114;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle16;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "fecha_creacion";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 125;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Id_Cliente.DefaultCellStyle = dataGridViewCellStyle17;
            this.Id_Cliente.HeaderText = "codigoFactura";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Width = 118;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.DNI.DefaultCellStyle = dataGridViewCellStyle18;
            this.DNI.HeaderText = "monto_Total";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 102;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle19;
            this.Nombre.HeaderText = "Nombre_Usuario";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 128;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle20;
            this.Apellido.HeaderText = "Apellido_Usuario";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 130;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.Email.DefaultCellStyle = dataGridViewCellStyle21;
            this.Email.HeaderText = "dni_cliente";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 95;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle22;
            this.Telefono.HeaderText = "nombre_cliente";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 123;
            // 
            // Estado
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle23;
            this.Estado.HeaderText = "descripcionMarca";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fecha_Creación
            // 
            this.Fecha_Creación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(34)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.Fecha_Creación.DefaultCellStyle = dataGridViewCellStyle24;
            this.Fecha_Creación.HeaderText = "descripcionModelo";
            this.Fecha_Creación.Name = "Fecha_Creación";
            this.Fecha_Creación.ReadOnly = true;
            this.Fecha_Creación.Width = 147;
            // 
            // precioVenta
            // 
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.precioVenta.DefaultCellStyle = dataGridViewCellStyle25;
            this.precioVenta.HeaderText = "precioVenta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle26;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle27;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // DescargaExcel
            // 
            this.DescargaExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.DescargaExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescargaExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescargaExcel.FlatAppearance.BorderSize = 0;
            this.DescargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescargaExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescargaExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescargaExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.DescargaExcel.IconColor = System.Drawing.Color.LimeGreen;
            this.DescargaExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DescargaExcel.IconSize = 25;
            this.DescargaExcel.Location = new System.Drawing.Point(577, 104);
            this.DescargaExcel.Name = "DescargaExcel";
            this.DescargaExcel.Size = new System.Drawing.Size(138, 34);
            this.DescargaExcel.TabIndex = 115;
            this.DescargaExcel.Text = "Descargar  Excel";
            this.DescargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DescargaExcel.UseVisualStyleBackColor = false;
            this.DescargaExcel.Click += new System.EventHandler(this.DescargaExcel_Click);
            // 
            // chartVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVentas.Legends.Add(legend2);
            this.chartVentas.Location = new System.Drawing.Point(229, 277);
            this.chartVentas.Name = "chartVentas";
            this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartVentas.Size = new System.Drawing.Size(372, 178);
            this.chartVentas.TabIndex = 116;
            this.chartVentas.Text = "chart1";
            // 
            // btnCargarData
            // 
            this.btnCargarData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnCargarData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnCargarData.BorderColor = System.Drawing.Color.White;
            this.btnCargarData.BorderRadius = 15;
            this.btnCargarData.BorderSize = 0;
            this.btnCargarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarData.FlatAppearance.BorderSize = 0;
            this.btnCargarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarData.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarData.ForeColor = System.Drawing.Color.White;
            this.btnCargarData.Location = new System.Drawing.Point(607, 353);
            this.btnCargarData.Name = "btnCargarData";
            this.btnCargarData.Size = new System.Drawing.Size(72, 39);
            this.btnCargarData.TabIndex = 117;
            this.btnCargarData.Text = "Generar Reporte";
            this.btnCargarData.TextColor = System.Drawing.Color.White;
            this.btnCargarData.UseVisualStyleBackColor = false;
            this.btnCargarData.Click += new System.EventHandler(this.btnCargarData_Click);
            // 
            // BuscarPorFecha
            // 
            this.BuscarPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.BuscarPorFecha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.BuscarPorFecha.BorderColor = System.Drawing.Color.White;
            this.BuscarPorFecha.BorderRadius = 15;
            this.BuscarPorFecha.BorderSize = 0;
            this.BuscarPorFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarPorFecha.FlatAppearance.BorderSize = 0;
            this.BuscarPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarPorFecha.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPorFecha.ForeColor = System.Drawing.Color.White;
            this.BuscarPorFecha.Location = new System.Drawing.Point(604, 48);
            this.BuscarPorFecha.Name = "BuscarPorFecha";
            this.BuscarPorFecha.Size = new System.Drawing.Size(72, 26);
            this.BuscarPorFecha.TabIndex = 112;
            this.BuscarPorFecha.Text = "Buscar";
            this.BuscarPorFecha.TextColor = System.Drawing.Color.White;
            this.BuscarPorFecha.UseVisualStyleBackColor = false;
            this.BuscarPorFecha.Click += new System.EventHandler(this.BuscarPorFecha_Click);
            // 
            // userBuscar
            // 
            this.userBuscar.BackColor = System.Drawing.Color.White;
            this.userBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.userBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.userBuscar.BorderRadius = 15;
            this.userBuscar.BorderSize = 1;
            this.userBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userBuscar.Location = new System.Drawing.Point(366, 105);
            this.userBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.userBuscar.MultiLine = false;
            this.userBuscar.Name = "userBuscar";
            this.userBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userBuscar.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userBuscar.PalceHolderText = "Buscar...";
            this.userBuscar.PasswordChar = false;
            this.userBuscar.Size = new System.Drawing.Size(97, 31);
            this.userBuscar.TabIndex = 103;
            this.userBuscar.Texts = "";
            this.userBuscar.UnderLinedStyle = false;
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
            this.cD_ComboBox3.Location = new System.Drawing.Point(181, 97);
            this.cD_ComboBox3.MaximumSize = new System.Drawing.Size(0, 100);
            this.cD_ComboBox3.MinimumSize = new System.Drawing.Size(0, 27);
            this.cD_ComboBox3.Name = "cD_ComboBox3";
            this.cD_ComboBox3.Padding = new System.Windows.Forms.Padding(1);
            this.cD_ComboBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cD_ComboBox3.Size = new System.Drawing.Size(0, 27);
            this.cD_ComboBox3.TabIndex = 102;
            this.cD_ComboBox3.Texts = "";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(826, 481);
            this.Controls.Add(this.btnCargarData);
            this.Controls.Add(this.chartVentas);
            this.Controls.Add(this.DescargaExcel);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.BuscarPorFecha);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.FechaInicio);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ComboBoxBuscarPor);
            this.Controls.Add(this.userBuscar);
            this.Controls.Add(this.cD_ComboBox3);
            this.Controls.Add(this.txtBuscarPor);
            this.Controls.Add(this.dateTimeFechaFin);
            this.Controls.Add(this.dateTimeFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFin;
        private System.Windows.Forms.ComboBox ComboBoxBuscarPor;
        private Controles_graficos.UserControl1 userBuscar;
        private CustomControls.Controles_graficos.CD_ComboBox cD_ComboBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel txtBuscarPor;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel FechaInicio;
        private Bunifu.Framework.UI.BunifuCustomLabel FechaFin;
        private CustomControls.Controles_graficos.CD_Button BuscarPorFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Creación;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private FontAwesome.Sharp.IconButton DescargaExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private CustomControls.Controles_graficos.CD_Button btnCargarData;
    }
}