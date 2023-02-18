using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

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

            //instancia las clases
            List<Usuario> TEST = new CN_Usuario().Listar();
            Usuario ousuario = new  CN_Usuario().Listar().Where(u => u.dni == textDocument1.Texts && u.pasword == userControl11.Texts).FirstOrDefault();


            if ((ousuario != null) && (ousuario.obRol.getID() == 1))
            {
                this.Hide();
                pantallaBienvenidita bienvenida = new pantallaBienvenidita(ousuario);
                bienvenida.ShowDialog();
                //int valor = 0;
                //valor = ousuario.obRol.getID();

                //MessageBox.Show(valor.ToString());
                Inicio form = new Inicio(ousuario);
                form.Show();
                form.FormClosing += frm_closing;
                return;
            }
            if ((ousuario != null) && (ousuario.obRol.getID() == 2))
            {
                this.Hide();
                pantallaBienvenidita bienvenida = new pantallaBienvenidita(ousuario);
                bienvenida.ShowDialog();
                //int valor = 0;
                //valor = ousuario.obRol.getID();

                //MessageBox.Show(valor.ToString());
                Inicio_Marketing form = new Inicio_Marketing(ousuario);
                form.Show();
                form.FormClosing += frm_closing;
                return;
            }
            if ((ousuario != null) && (ousuario.obRol.getID() == 3))
            {
                this.Hide();
                pantallaBienvenidita bienvenida = new pantallaBienvenidita(ousuario);
                bienvenida.ShowDialog();
                //int valor = 0;
                //valor = ousuario.obRol.getID();

                //MessageBox.Show(valor.ToString());
                Inicio_Empleado form = new Inicio_Empleado(ousuario);
                form.Show();
                form.FormClosing += frm_closing;
                return;
            }
            else { MessageBox.Show("no existe el usuario facha"); }
          
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textDocument1.Texts = "";
            userControl11.Texts = "";
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textDocument_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDocument1__Textchanged(object sender, EventArgs e)
        {

        }
    }
}
