namespace BUNIFU
{
    partial class frmDetalle_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUsser = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTituloo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txNameClient = new System.Windows.Forms.TextBox();
            this.txDniClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCOdigg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridventas2 = new System.Windows.Forms.DataGridView();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txCambio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDescarga = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_au = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridventas2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Informacion de la Venta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txC);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtUsser);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(89, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 79);
            this.panel2.TabIndex = 5;
            // 
            // txC
            // 
            this.txC.Location = new System.Drawing.Point(267, 44);
            this.txC.Name = "txC";
            this.txC.Size = new System.Drawing.Size(40, 20);
            this.txC.TabIndex = 72;
            this.txC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "Factura";
            // 
            // txtUsser
            // 
            this.txtUsser.Location = new System.Drawing.Point(145, 43);
            this.txtUsser.Name = "txtUsser";
            this.txtUsser.Size = new System.Drawing.Size(116, 20);
            this.txtUsser.TabIndex = 5;
            this.txtUsser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(14, 44);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(116, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Venta";
            // 
            // lblTituloo
            // 
            this.lblTituloo.AutoSize = true;
            this.lblTituloo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.lblTituloo.Location = new System.Drawing.Point(83, 31);
            this.lblTituloo.Name = "lblTituloo";
            this.lblTituloo.Size = new System.Drawing.Size(214, 31);
            this.lblTituloo.TabIndex = 7;
            this.lblTituloo.Text = "Detalle de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Informacion del Cliente";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txNameClient);
            this.panel1.Controls.Add(this.txDniClient);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(440, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 79);
            this.panel1.TabIndex = 8;
            // 
            // txNameClient
            // 
            this.txNameClient.Location = new System.Drawing.Point(161, 43);
            this.txNameClient.Name = "txNameClient";
            this.txNameClient.Size = new System.Drawing.Size(116, 20);
            this.txNameClient.TabIndex = 5;
            this.txNameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txDniClient
            // 
            this.txDniClient.Location = new System.Drawing.Point(30, 44);
            this.txDniClient.Name = "txDniClient";
            this.txDniClient.Size = new System.Drawing.Size(116, 20);
            this.txDniClient.TabIndex = 3;
            this.txDniClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Documento Cliente";
            // 
            // textBoxCOdigg
            // 
            this.textBoxCOdigg.Location = new System.Drawing.Point(478, 75);
            this.textBoxCOdigg.Name = "textBoxCOdigg";
            this.textBoxCOdigg.Size = new System.Drawing.Size(116, 20);
            this.textBoxCOdigg.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo Factura";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusqueda.IconColor = System.Drawing.Color.Black;
            this.btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqueda.IconSize = 18;
            this.btnBusqueda.Location = new System.Drawing.Point(600, 73);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 22);
            this.btnBusqueda.TabIndex = 12;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(681, 73);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 22);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Limpiar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridventas2
            // 
            this.dataGridventas2.AllowUserToAddRows = false;
            this.dataGridventas2.AllowUserToDeleteRows = false;
            this.dataGridventas2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridventas2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridventas2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridventas2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridventas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridventas2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id_au,
            this.producto,
            this.precio,
            this.cantidad,
            this.subTotal});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridventas2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridventas2.EnableHeadersVisualStyles = false;
            this.dataGridventas2.GridColor = System.Drawing.Color.White;
            this.dataGridventas2.Location = new System.Drawing.Point(89, 232);
            this.dataGridventas2.Name = "dataGridventas2";
            this.dataGridventas2.ReadOnly = true;
            this.dataGridventas2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridventas2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridventas2.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridventas2.Size = new System.Drawing.Size(667, 170);
            this.dataGridventas2.TabIndex = 65;
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(186, 426);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(72, 20);
            this.txTotal.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Monto Total";
            // 
            // txPago
            // 
            this.txPago.Location = new System.Drawing.Point(329, 426);
            this.txPago.Name = "txPago";
            this.txPago.Size = new System.Drawing.Size(90, 20);
            this.txPago.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Monto Pago";
            // 
            // txCambio
            // 
            this.txCambio.Location = new System.Drawing.Point(496, 426);
            this.txCambio.Name = "txCambio";
            this.txCambio.Size = new System.Drawing.Size(90, 20);
            this.txCambio.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Monto Cambio";
            // 
            // btnDescarga
            // 
            this.btnDescarga.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDescarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescarga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDescarga.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescarga.IconColor = System.Drawing.Color.Coral;
            this.btnDescarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescarga.IconSize = 25;
            this.btnDescarga.Location = new System.Drawing.Point(602, 419);
            this.btnDescarga.Name = "btnDescarga";
            this.btnDescarga.Size = new System.Drawing.Size(154, 32);
            this.btnDescarga.TabIndex = 72;
            this.btnDescarga.Text = "Descargar  PDF";
            this.btnDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescarga.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 10;
            // 
            // id_au
            // 
            this.id_au.HeaderText = "id_au";
            this.id_au.Name = "id_au";
            this.id_au.ReadOnly = true;
            this.id_au.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 200;
            // 
            // frmDetalle_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.btnDescarga);
            this.Controls.Add(this.txCambio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txPago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridventas2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.textBoxCOdigg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalle_Ventas";
            this.Text = "frmDetalle_Ventas";
            this.Load += new System.EventHandler(this.frmDetalle_Ventas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridventas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUsser;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTituloo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txNameClient;
        private System.Windows.Forms.TextBox txDniClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCOdigg;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridventas2;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txCambio;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_au;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
    }
}