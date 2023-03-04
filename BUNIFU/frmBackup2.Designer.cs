namespace BUNIFU
{
    partial class frmBackup2
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
            this.button1 = new System.Windows.Forms.Button();
            this.bckp_Bienvenida = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.porcentajeLabel = new System.Windows.Forms.Label();
            this.Bckp_IngreseDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(242, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bckp_Bienvenida
            // 
            this.bckp_Bienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bckp_Bienvenida.BackColor = System.Drawing.Color.White;
            this.bckp_Bienvenida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bckp_Bienvenida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bckp_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckp_Bienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bckp_Bienvenida.Location = new System.Drawing.Point(17, 29);
            this.bckp_Bienvenida.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bckp_Bienvenida.Name = "bckp_Bienvenida";
            this.bckp_Bienvenida.Size = new System.Drawing.Size(617, 29);
            this.bckp_Bienvenida.TabIndex = 1;
            this.bckp_Bienvenida.Text = "¡Bienvenidos! Al Servicio de Backup de Limited Edition";
            this.bckp_Bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(85, 258);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(458, 23);
            this.progressBar.TabIndex = 2;
            // 
            // porcentajeLabel
            // 
            this.porcentajeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.porcentajeLabel.AutoSize = true;
            this.porcentajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentajeLabel.Location = new System.Drawing.Point(390, 298);
            this.porcentajeLabel.Name = "porcentajeLabel";
            this.porcentajeLabel.Size = new System.Drawing.Size(23, 13);
            this.porcentajeLabel.TabIndex = 3;
            this.porcentajeLabel.Text = "0%";
            // 
            // Bckp_IngreseDatos
            // 
            this.Bckp_IngreseDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bckp_IngreseDatos.BackColor = System.Drawing.Color.White;
            this.Bckp_IngreseDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bckp_IngreseDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bckp_IngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bckp_IngreseDatos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Bckp_IngreseDatos.Location = new System.Drawing.Point(12, 81);
            this.Bckp_IngreseDatos.Name = "Bckp_IngreseDatos";
            this.Bckp_IngreseDatos.Size = new System.Drawing.Size(631, 92);
            this.Bckp_IngreseDatos.TabIndex = 4;
            this.Bckp_IngreseDatos.Text = "Las copias de seguridad deben realizarse con determinada frecuencia para conserva" +
    "rlos y evitar pérdidas de la información";
            this.Bckp_IngreseDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBackup2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.Bckp_IngreseDatos);
            this.Controls.Add(this.porcentajeLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bckp_Bienvenida);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackup2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackup2";
            this.Load += new System.EventHandler(this.frmBackup2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bckp_Bienvenida;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label porcentajeLabel;
        private System.Windows.Forms.Label Bckp_IngreseDatos;
    }
}