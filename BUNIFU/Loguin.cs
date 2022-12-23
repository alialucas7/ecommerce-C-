﻿using System;
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
            Usuario ousuario = new  CN_Usuario().Listar().Where(u => u.dni == textDocument.Text && u.pasword == textPasword.Text).FirstOrDefault();

            //con un if hace la validacion correspondiente
            if (ousuario != null) {
                this.Hide();
                pantallaBienvenidita bienvenida = new pantallaBienvenidita();
                bienvenida.ShowDialog();
                Inicio form = new Inicio();
                form.Show();


                form.FormClosing += frm_closing;
            }
            else { MessageBox.Show("no existe facha"); }
          
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textDocument.Text = "";
            textPasword.Text = "";
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
