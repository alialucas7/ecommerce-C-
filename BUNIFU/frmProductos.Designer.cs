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
            this.comboMark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboSucur
            // 
            this.comboSucur.FormattingEnabled = true;
            this.comboSucur.Location = new System.Drawing.Point(31, 35);
            this.comboSucur.Name = "comboSucur";
            this.comboSucur.Size = new System.Drawing.Size(361, 21);
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
            // comboMark
            // 
            this.comboMark.FormattingEnabled = true;
            this.comboMark.Location = new System.Drawing.Point(31, 85);
            this.comboMark.Name = "comboMark";
            this.comboMark.Size = new System.Drawing.Size(121, 21);
            this.comboMark.TabIndex = 2;
            this.comboMark.SelectedIndexChanged += new System.EventHandler(this.comboMark_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione el Modelo";
            // 
            // comboModel
            // 
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(271, 85);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(121, 21);
            this.comboModel.TabIndex = 4;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMark);
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
        private System.Windows.Forms.ComboBox comboMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboModel;
    }
}