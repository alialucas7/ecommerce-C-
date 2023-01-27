using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUNIFU.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace BUNIFU
{
    public partial class frmRegistrarVentaaass : Form
    {
        public frmRegistrarVentaaass()
        {
            InitializeComponent();
        }

        private void frmRegistrarVentaaass_Load(object sender, EventArgs e)
        {
            comboFactura.Items.Add(new OpcionCombobox() { valor = 1, Texto = "A"});
            comboFactura.Items.Add(new OpcionCombobox() { valor = 2, Texto = "B" });
            comboFactura.Items.Add(new OpcionCombobox() { valor = 3, Texto = "C" });
            comboFactura.DisplayMember = "Texto";
            comboFactura.ValueMember = "valor";
            comboFactura.SelectedIndex = 2;

            txtFechita.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox2.Text = "0";
            textBoxpagacon.Text = "";
            textBoxcambio.Text = "";
            textBoxpagar.Text = "0";
        }
    }
}
