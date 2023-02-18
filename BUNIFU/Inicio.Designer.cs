namespace BUNIFU
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnslide = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloMenu = new System.Windows.Forms.MenuStrip();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.logo = new FontAwesome.Sharp.IconButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoreeo = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 11;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(923, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.menuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuVertical.Controls.Add(this.lblRol);
            this.menuVertical.Controls.Add(this.lblCoreeo);
            this.menuVertical.Controls.Add(this.lblName);
            this.menuVertical.Controls.Add(this.iconButton6);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Controls.Add(this.iconButton5);
            this.menuVertical.Controls.Add(this.iconButton2);
            this.menuVertical.Controls.Add(this.iconButton1);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.tituloMenu);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.ForeColor = System.Drawing.Color.Transparent;
            this.menuVertical.Location = new System.Drawing.Point(0, 62);
            this.menuVertical.MaximumSize = new System.Drawing.Size(203, 455);
            this.menuVertical.MinimumSize = new System.Drawing.Size(72, 455);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(203, 455);
            this.menuVertical.TabIndex = 13;
            this.menuVertical.AutoSizeChanged += new System.EventHandler(this.btnslide_Click);
            this.menuVertical.VisibleChanged += new System.EventHandler(this.btnslide_Click);
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // btnslide
            // 
            this.btnslide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.btnslide.FlatAppearance.BorderSize = 0;
            this.btnslide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnslide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnslide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnslide.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnslide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnslide.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnslide.IconColor = System.Drawing.Color.White;
            this.btnslide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnslide.Location = new System.Drawing.Point(23, -1);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(124, 52);
            this.btnslide.TabIndex = 16;
            this.btnslide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnslide.UseVisualStyleBackColor = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(968, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exit";
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 45;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(4, 220);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(199, 60);
            this.iconButton6.TabIndex = 28;
            this.iconButton6.Text = "Backup";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 45;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(5, 160);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(199, 60);
            this.iconButton5.TabIndex = 27;
            this.iconButton5.Text = "Usuarios";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 45;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(5, 99);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(203, 60);
            this.iconButton2.TabIndex = 24;
            this.iconButton2.Text = "Productos";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(5, 38);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(203, 60);
            this.iconButton1.TabIndex = 23;
            this.iconButton1.Text = "Clientes";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnslide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 50);
            this.panel1.TabIndex = 22;
            // 
            // tituloMenu
            // 
            this.tituloMenu.AutoSize = false;
            this.tituloMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.tituloMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tituloMenu.Location = new System.Drawing.Point(270, 396);
            this.tituloMenu.Name = "tituloMenu";
            this.tituloMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.tituloMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tituloMenu.Size = new System.Drawing.Size(767, 47);
            this.tituloMenu.TabIndex = 11;
            this.tituloMenu.Text = "Sistema de Ventas";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.logo.FlatAppearance.BorderSize = 0;
            this.logo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.logo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Transparent;
            this.logo.IconChar = FontAwesome.Sharp.IconChar.CarBurst;
            this.logo.IconColor = System.Drawing.Color.White;
            this.logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logo.IconSize = 50;
            this.logo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1019, 62);
            this.logo.TabIndex = 16;
            this.logo.Text = "Limited Edition";
            this.logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logo.UseVisualStyleBackColor = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.logo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 456);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 388);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "label2";
            // 
            // lblCoreeo
            // 
            this.lblCoreeo.AutoSize = true;
            this.lblCoreeo.Location = new System.Drawing.Point(80, 407);
            this.lblCoreeo.Name = "lblCoreeo";
            this.lblCoreeo.Size = new System.Drawing.Size(35, 13);
            this.lblCoreeo.TabIndex = 31;
            this.lblCoreeo.Text = "label3";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.ForeColor = System.Drawing.Color.Tan;
            this.lblRol.Location = new System.Drawing.Point(80, 430);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 13);
            this.lblRol.TabIndex = 32;
            this.lblRol.Text = "label4";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1019, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(8, 8);
            this.MainMenuStrip = this.tituloMenu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.MenuStrip tituloMenu;
        private FontAwesome.Sharp.IconButton logo;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private FontAwesome.Sharp.IconButton btnslide;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCoreeo;
        private System.Windows.Forms.Label lblName;
    }
}

