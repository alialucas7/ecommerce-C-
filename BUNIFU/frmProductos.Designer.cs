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
            this.comboSucur = new System.Windows.Forms.ComboBox();
            this.labelSuxur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSucur
            // 
            this.comboSucur.FormattingEnabled = true;
            this.comboSucur.Location = new System.Drawing.Point(31, 35);
            this.comboSucur.Name = "comboSucur";
            this.comboSucur.Size = new System.Drawing.Size(387, 21);
            this.comboSucur.TabIndex = 0;
            // 
            // labelSuxur
            // 
            this.labelSuxur.AutoSize = true;
            this.labelSuxur.Location = new System.Drawing.Point(28, 19);
            this.labelSuxur.Name = "labelSuxur";
            this.labelSuxur.Size = new System.Drawing.Size(115, 13);
            this.labelSuxur.TabIndex = 1;
            this.labelSuxur.Text = "Seleccione la Sucursal";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSuxur);
            this.Controls.Add(this.comboSucur);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSucur;
        private System.Windows.Forms.Label labelSuxur;
    }
}