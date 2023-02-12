namespace BUNIFU
{
    partial class frm_Backup
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
            this.bckp_Bienvenida = new System.Windows.Forms.Label();
            this.Bckp_IngreseDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bckp_DatosServidor = new System.Windows.Forms.Label();
            this.Bckp_DatosPersonales = new System.Windows.Forms.Label();
            this.clavesIguales = new System.Windows.Forms.Label();
            this.Bckp_progressBar = new System.Windows.Forms.ProgressBar();
            this.Bckp_Porcentaje = new System.Windows.Forms.Label();
            this.Bckp_Estado = new System.Windows.Forms.Label();
            this.Backup = new CustomControls.Controles_graficos.CD_Button();
            this.Bckp_ConfirmaContraseña = new BUNIFU.Controles_graficos.UserControl1();
            this.Bckp_Contraseña = new BUNIFU.Controles_graficos.UserControl1();
            this.Bckp_Usuario = new BUNIFU.Controles_graficos.UserControl1();
            this.bckp_BasedeDatos = new BUNIFU.Controles_graficos.UserControl1();
            this.bckp_Servidor = new BUNIFU.Controles_graficos.UserControl1();
            this.SuspendLayout();
            // 
            // bckp_Bienvenida
            // 
            this.bckp_Bienvenida.BackColor = System.Drawing.Color.White;
            this.bckp_Bienvenida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bckp_Bienvenida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bckp_Bienvenida.Font = new System.Drawing.Font("Harlow Solid Std", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckp_Bienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bckp_Bienvenida.Location = new System.Drawing.Point(21, 9);
            this.bckp_Bienvenida.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bckp_Bienvenida.Name = "bckp_Bienvenida";
            this.bckp_Bienvenida.Size = new System.Drawing.Size(617, 29);
            this.bckp_Bienvenida.TabIndex = 0;
            this.bckp_Bienvenida.Text = "¡Bienvenidos! Al Servicio de Backup de Limited Edition";
            this.bckp_Bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bckp_IngreseDatos
            // 
            this.Bckp_IngreseDatos.BackColor = System.Drawing.Color.White;
            this.Bckp_IngreseDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bckp_IngreseDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bckp_IngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_IngreseDatos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Bckp_IngreseDatos.Location = new System.Drawing.Point(12, 48);
            this.Bckp_IngreseDatos.Name = "Bckp_IngreseDatos";
            this.Bckp_IngreseDatos.Size = new System.Drawing.Size(631, 25);
            this.Bckp_IngreseDatos.TabIndex = 1;
            this.Bckp_IngreseDatos.Text = "¡Por favor ingresá los datos del servidor y del usuario para realizar la copia de" +
    " seguridad!";
            this.Bckp_IngreseDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 332);
            this.label2.TabIndex = 118;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bckp_DatosServidor
            // 
            this.Bckp_DatosServidor.BackColor = System.Drawing.Color.White;
            this.Bckp_DatosServidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bckp_DatosServidor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bckp_DatosServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_DatosServidor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Bckp_DatosServidor.Location = new System.Drawing.Point(21, 91);
            this.Bckp_DatosServidor.Name = "Bckp_DatosServidor";
            this.Bckp_DatosServidor.Size = new System.Drawing.Size(191, 26);
            this.Bckp_DatosServidor.TabIndex = 122;
            this.Bckp_DatosServidor.Text = "Información del Servidor";
            this.Bckp_DatosServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bckp_DatosPersonales
            // 
            this.Bckp_DatosPersonales.BackColor = System.Drawing.Color.White;
            this.Bckp_DatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bckp_DatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bckp_DatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_DatosPersonales.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Bckp_DatosPersonales.Location = new System.Drawing.Point(21, 195);
            this.Bckp_DatosPersonales.Name = "Bckp_DatosPersonales";
            this.Bckp_DatosPersonales.Size = new System.Drawing.Size(171, 26);
            this.Bckp_DatosPersonales.TabIndex = 125;
            this.Bckp_DatosPersonales.Text = "Información del Usuario";
            this.Bckp_DatosPersonales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clavesIguales
            // 
            this.clavesIguales.AutoSize = true;
            this.clavesIguales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.clavesIguales.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clavesIguales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clavesIguales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clavesIguales.Location = new System.Drawing.Point(342, 318);
            this.clavesIguales.Name = "clavesIguales";
            this.clavesIguales.Size = new System.Drawing.Size(20, 16);
            this.clavesIguales.TabIndex = 130;
            this.clavesIguales.Text = "...";
            this.clavesIguales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Bckp_progressBar
            // 
            this.Bckp_progressBar.BackColor = System.Drawing.Color.ForestGreen;
            this.Bckp_progressBar.Location = new System.Drawing.Point(21, 341);
            this.Bckp_progressBar.Name = "Bckp_progressBar";
            this.Bckp_progressBar.Size = new System.Drawing.Size(520, 23);
            this.Bckp_progressBar.TabIndex = 131;
            // 
            // Bckp_Porcentaje
            // 
            this.Bckp_Porcentaje.AutoSize = true;
            this.Bckp_Porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.Bckp_Porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_Porcentaje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bckp_Porcentaje.Location = new System.Drawing.Point(295, 367);
            this.Bckp_Porcentaje.Name = "Bckp_Porcentaje";
            this.Bckp_Porcentaje.Size = new System.Drawing.Size(31, 15);
            this.Bckp_Porcentaje.TabIndex = 133;
            this.Bckp_Porcentaje.Text = "0 %";
            this.Bckp_Porcentaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Bckp_Estado
            // 
            this.Bckp_Estado.AutoSize = true;
            this.Bckp_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.Bckp_Estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bckp_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_Estado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bckp_Estado.Location = new System.Drawing.Point(18, 389);
            this.Bckp_Estado.Name = "Bckp_Estado";
            this.Bckp_Estado.Size = new System.Drawing.Size(54, 16);
            this.Bckp_Estado.TabIndex = 134;
            this.Bckp_Estado.Text = "Estado:";
            this.Bckp_Estado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Backup
            // 
            this.Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Backup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Backup.BorderColor = System.Drawing.Color.White;
            this.Backup.BorderRadius = 26;
            this.Backup.BorderSize = 0;
            this.Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backup.FlatAppearance.BorderSize = 0;
            this.Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backup.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backup.ForeColor = System.Drawing.Color.White;
            this.Backup.Location = new System.Drawing.Point(547, 331);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(80, 33);
            this.Backup.TabIndex = 132;
            this.Backup.Text = "Backup";
            this.Backup.TextColor = System.Drawing.Color.White;
            this.Backup.UseVisualStyleBackColor = false;
            this.Backup.Click += new System.EventHandler(this.Backup_Click_1);
            // 
            // Bckp_ConfirmaContraseña
            // 
            this.Bckp_ConfirmaContraseña.BackColor = System.Drawing.Color.White;
            this.Bckp_ConfirmaContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Bckp_ConfirmaContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Bckp_ConfirmaContraseña.BorderRadius = 15;
            this.Bckp_ConfirmaContraseña.BorderSize = 1;
            this.Bckp_ConfirmaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_ConfirmaContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Bckp_ConfirmaContraseña.Location = new System.Drawing.Point(21, 303);
            this.Bckp_ConfirmaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.Bckp_ConfirmaContraseña.MultiLine = false;
            this.Bckp_ConfirmaContraseña.Name = "Bckp_ConfirmaContraseña";
            this.Bckp_ConfirmaContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Bckp_ConfirmaContraseña.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.Bckp_ConfirmaContraseña.PalceHolderText = "Confirma Contraseña";
            this.Bckp_ConfirmaContraseña.PasswordChar = false;
            this.Bckp_ConfirmaContraseña.Size = new System.Drawing.Size(305, 31);
            this.Bckp_ConfirmaContraseña.TabIndex = 128;
            this.Bckp_ConfirmaContraseña.Texts = "";
            this.Bckp_ConfirmaContraseña.UnderLinedStyle = false;
            this.Bckp_ConfirmaContraseña._Textchanged += new System.EventHandler(this.Bckp_ConfirmaContraseña__Textchanged_1);
            this.Bckp_ConfirmaContraseña.Leave += new System.EventHandler(this.Bckp_ConfirmaContraseña_Leave_1);
            // 
            // Bckp_Contraseña
            // 
            this.Bckp_Contraseña.BackColor = System.Drawing.Color.White;
            this.Bckp_Contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Bckp_Contraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Bckp_Contraseña.BorderRadius = 15;
            this.Bckp_Contraseña.BorderSize = 1;
            this.Bckp_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_Contraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Bckp_Contraseña.Location = new System.Drawing.Point(21, 264);
            this.Bckp_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.Bckp_Contraseña.MultiLine = false;
            this.Bckp_Contraseña.Name = "Bckp_Contraseña";
            this.Bckp_Contraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Bckp_Contraseña.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.Bckp_Contraseña.PalceHolderText = "Contraseña";
            this.Bckp_Contraseña.PasswordChar = false;
            this.Bckp_Contraseña.Size = new System.Drawing.Size(305, 31);
            this.Bckp_Contraseña.TabIndex = 127;
            this.Bckp_Contraseña.Texts = "";
            this.Bckp_Contraseña.UnderLinedStyle = false;
            this.Bckp_Contraseña._Textchanged += new System.EventHandler(this.Bckp_Contraseña__Textchanged);
            // 
            // Bckp_Usuario
            // 
            this.Bckp_Usuario.BackColor = System.Drawing.Color.White;
            this.Bckp_Usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Bckp_Usuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.Bckp_Usuario.BorderRadius = 15;
            this.Bckp_Usuario.BorderSize = 1;
            this.Bckp_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_Usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Bckp_Usuario.Location = new System.Drawing.Point(21, 225);
            this.Bckp_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Bckp_Usuario.MultiLine = false;
            this.Bckp_Usuario.Name = "Bckp_Usuario";
            this.Bckp_Usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Bckp_Usuario.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.Bckp_Usuario.PalceHolderText = "Usuario";
            this.Bckp_Usuario.PasswordChar = false;
            this.Bckp_Usuario.Size = new System.Drawing.Size(305, 31);
            this.Bckp_Usuario.TabIndex = 126;
            this.Bckp_Usuario.Texts = "";
            this.Bckp_Usuario.UnderLinedStyle = false;
            this.Bckp_Usuario._Textchanged += new System.EventHandler(this.Bckp_Usuario__Textchanged);
            // 
            // bckp_BasedeDatos
            // 
            this.bckp_BasedeDatos.BackColor = System.Drawing.Color.White;
            this.bckp_BasedeDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.bckp_BasedeDatos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.bckp_BasedeDatos.BorderRadius = 15;
            this.bckp_BasedeDatos.BorderSize = 1;
            this.bckp_BasedeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckp_BasedeDatos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bckp_BasedeDatos.Location = new System.Drawing.Point(21, 160);
            this.bckp_BasedeDatos.Margin = new System.Windows.Forms.Padding(4);
            this.bckp_BasedeDatos.MultiLine = false;
            this.bckp_BasedeDatos.Name = "bckp_BasedeDatos";
            this.bckp_BasedeDatos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.bckp_BasedeDatos.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.bckp_BasedeDatos.PalceHolderText = "Nombre Base de Datos";
            this.bckp_BasedeDatos.PasswordChar = false;
            this.bckp_BasedeDatos.Size = new System.Drawing.Size(520, 31);
            this.bckp_BasedeDatos.TabIndex = 124;
            this.bckp_BasedeDatos.Texts = "";
            this.bckp_BasedeDatos.UnderLinedStyle = false;
            this.bckp_BasedeDatos._Textchanged += new System.EventHandler(this.bckp_BasedeDatos__Textchanged);
            // 
            // bckp_Servidor
            // 
            this.bckp_Servidor.BackColor = System.Drawing.Color.White;
            this.bckp_Servidor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.bckp_Servidor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.bckp_Servidor.BorderRadius = 15;
            this.bckp_Servidor.BorderSize = 1;
            this.bckp_Servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckp_Servidor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bckp_Servidor.Location = new System.Drawing.Point(21, 121);
            this.bckp_Servidor.Margin = new System.Windows.Forms.Padding(4);
            this.bckp_Servidor.MultiLine = false;
            this.bckp_Servidor.Name = "bckp_Servidor";
            this.bckp_Servidor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.bckp_Servidor.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.bckp_Servidor.PalceHolderText = "Nombre Servidor";
            this.bckp_Servidor.PasswordChar = false;
            this.bckp_Servidor.Size = new System.Drawing.Size(520, 31);
            this.bckp_Servidor.TabIndex = 123;
            this.bckp_Servidor.Texts = "";
            this.bckp_Servidor.UnderLinedStyle = false;
            this.bckp_Servidor._Textchanged += new System.EventHandler(this.bckp_Servidor__Textchanged);
            // 
            // frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.Bckp_Estado);
            this.Controls.Add(this.Bckp_Porcentaje);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.Bckp_progressBar);
            this.Controls.Add(this.clavesIguales);
            this.Controls.Add(this.Bckp_ConfirmaContraseña);
            this.Controls.Add(this.Bckp_Contraseña);
            this.Controls.Add(this.Bckp_Usuario);
            this.Controls.Add(this.Bckp_DatosPersonales);
            this.Controls.Add(this.bckp_BasedeDatos);
            this.Controls.Add(this.bckp_Servidor);
            this.Controls.Add(this.Bckp_DatosServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bckp_IngreseDatos);
            this.Controls.Add(this.bckp_Bienvenida);
            this.Font = new System.Drawing.Font("Harlow Solid Std", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frm_Backup";
            this.Text = "frm_Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bckp_Bienvenida;
        private System.Windows.Forms.Label Bckp_IngreseDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Bckp_DatosServidor;
        private Controles_graficos.UserControl1 bckp_Servidor;
        private Controles_graficos.UserControl1 bckp_BasedeDatos;
        private System.Windows.Forms.Label Bckp_DatosPersonales;
        private Controles_graficos.UserControl1 Bckp_Usuario;
        private Controles_graficos.UserControl1 Bckp_Contraseña;
        private Controles_graficos.UserControl1 Bckp_ConfirmaContraseña;
        private System.Windows.Forms.Label clavesIguales;
        private System.Windows.Forms.ProgressBar Bckp_progressBar;
        private CustomControls.Controles_graficos.CD_Button Backup;
        private System.Windows.Forms.Label Bckp_Porcentaje;
        private System.Windows.Forms.Label Bckp_Estado;
    }
}