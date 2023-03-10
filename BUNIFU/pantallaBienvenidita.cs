using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

using System.Data.SqlClient;

namespace BUNIFU
{
    public partial class pantallaBienvenidita : Form
    {
        private Usuario usser = new Usuario();

        public pantallaBienvenidita(Usuario usuario)
        {
            InitializeComponent();
            usser = usuario;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            bunifuCircleProgressbar1.Value += 1;
            if (bunifuCircleProgressbar1.Value  == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void pantallaBienvenidita_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            bunifuCircleProgressbar1.Value = 0;
            label2.Text = usser.name + ", " + usser.apellido;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
