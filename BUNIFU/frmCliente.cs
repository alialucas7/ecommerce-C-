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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }





        private void frmCliente_Load(object sender, EventArgs e)
        {
            /*esto es para que pueda habiliatr cliente mediante mi combobox*/
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 1, Texto = "Habilitado" });
            comboBoxState.Items.Add(new OpcionCombobox() { valor = 0, Texto = "Inhabilitado" });
            comboBoxState.DisplayMember = "Texto";
            comboBoxState.ValueMember = "valor";
        }

        private void userControl12__Textchanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

    }
}
