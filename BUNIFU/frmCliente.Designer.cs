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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl12 = new BUNIFU.Controles_graficos.UserControl1();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.cD_Button1 = new CustomControls.Controles_graficos.CD_Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Este es el formulario de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metele manooo sebaa!!!!!";
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.userControl12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.userControl12.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.userControl12.BorderRadius = 15;
            this.userControl12.BorderSize = 1;
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControl12.Location = new System.Drawing.Point(31, 90);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4);
            this.userControl12.MultiLine = false;
            this.userControl12.Name = "userControl12";
            this.userControl12.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl12.PalceHolderColor = System.Drawing.Color.DarkGray;
            this.userControl12.PalceHolderText = "Name";
            this.userControl12.PasswordChar = false;
            this.userControl12.Size = new System.Drawing.Size(225, 31);
            this.userControl12.TabIndex = 27;
            this.userControl12.Texts = "";
            this.userControl12.UnderLinedStyle = false;
            this.userControl12._Textchanged += new System.EventHandler(this.userControl12__Textchanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(53, 141);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel2.TabIndex = 37;
            this.bunifuCustomLabel2.Text = "Estado";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(99, 138);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 36;
            // 
            // cD_Button1
            // 
            this.cD_Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cD_Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cD_Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cD_Button1.BorderRadius = 10;
            this.cD_Button1.BorderSize = 0;
            this.cD_Button1.FlatAppearance.BorderSize = 0;
            this.cD_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cD_Button1.ForeColor = System.Drawing.Color.White;
            this.cD_Button1.Location = new System.Drawing.Point(363, 118);
            this.cD_Button1.Name = "cD_Button1";
            this.cD_Button1.Size = new System.Drawing.Size(187, 65);
            this.cD_Button1.TabIndex = 38;
            this.cD_Button1.Text = "cD_Button1";
            this.cD_Button1.TextColor = System.Drawing.Color.White;
            this.cD_Button1.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.cD_Button1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controles_graficos.UserControl1 userControl12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox comboBoxState;
        private CustomControls.Controles_graficos.CD_Button cD_Button1;
    }
}