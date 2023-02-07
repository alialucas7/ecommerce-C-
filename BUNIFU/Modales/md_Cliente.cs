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
using BUNIFU.Utilidades;


namespace BUNIFU.Modales
{
    public partial class md_Cliente : Form
    {

        public Cliente _Cliente { get; set; }

        public md_Cliente()
        {
            InitializeComponent();
        }

        private void md_Cliente_Load(object sender, EventArgs e)
        {


            //me permite buscar elementos por categoria en mi datagrid
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBusqueda.Items.Add(new OpcionCombobox() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBusqueda.DisplayMember = "Texto";
            comboBusqueda.ValueMember = "valor";
            comboBusqueda.SelectedIndex = 1;



            /*Cargo los datos que tengo en la BD al datagrid*/
            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                if (item.estado)
                {
                    dataGridView1.Rows.Add(new object[] {item.dni,item.nombre,item.apellido


                    });
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombobox)comboBusqueda.SelectedItem).valor.ToString();
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Texts.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtBusqueda.Texts = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iClolumna = e.ColumnIndex;

            if (iRow >= 0 && iClolumna >= 0)
            {

                _Cliente = new Cliente()
                {
                    dni = dataGridView1.Rows[iRow].Cells["DNI"].Value.ToString(),
                    nombre = dataGridView1.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    apellido = dataGridView1.Rows[iRow].Cells["Apellido"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
