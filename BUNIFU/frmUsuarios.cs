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

namespace BUNIFU
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void userControl12__Textchanged(object sender, EventArgs e)
        {
            
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_dealershipDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bD_dealershipDataSet.Usuario);

            /*esto es para que pueda habiliatr ussser mediante mi combobox*/
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 1, Texto = "Habilitado"});
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 0, Texto = "Inhabilitado" });
            comboBoxState.DisplayMember = "Texto";
            comboBoxState.ValueMember = "valor";
        }
    }
}
