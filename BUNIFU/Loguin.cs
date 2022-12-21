using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUNIFU
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantallaBienvenidita bienvenida = new pantallaBienvenidita();
            bienvenida.ShowDialog();
            Inicio form = new Inicio();
            form.Show();
          

            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textDocument.Text = "";
            textPasword.Text = "";
            this.Show();
        }

        
    }
}
