using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BUNIFU.Utilidades;
using CapaEntidad;
using CapaNegocio;
//using BUNIFU.Modales;

namespace BUNIFU
{
    public partial class frmDetalle_Ventas : Form
    {
        private Usuario _Usuario;

        public frmDetalle_Ventas(Usuario objUss = null)
        {
            _Usuario = objUss;
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Factura obFactu = new CN_Factura().obtenerFactura(Convert.ToInt32(textBoxCOdigg.Text));

            /*al ser != de 0 sognifica que lo encontro*/
            if (obFactu.id_venta != 0)
            {
                txtFecha.Text = obFactu.fechaRegistro;
                txtUsser.Text = obFactu.objUsuario.name + ", " + obFactu.objUsuario.apellido;
                txC.Text = obFactu.objTipoFact.descripcion;
                txDniClient.Text = obFactu.dniCliente;
                txNameClient.Text = obFactu.nameCliente;
                

                dataGridventas2.Rows.Clear();
                foreach (DetalleFactura df in obFactu.oDetalle_Factur)
                {
                    dataGridventas2.Rows.Add(new object[] {"",df.objAuto.id_automovil, df.objAuto.objMarcaa.descripcionMarca.ToString()
                        +" ("+df.objAuto.objModeloo.descripcionModel+")",
                        df.precioVenta,df.subTotal,df.cantidad
                    });
                }
                txTotal.Text = obFactu.montoTotal.ToString("0.00");
                txPago.Text = obFactu.montoPago.ToString("0.00");
                txCambio.Text = obFactu.montoCambio.ToString("0.00");

            }
            else MessageBox.Show("No se encontro la factura, verifique el codigo");
        }

        private void frmDetalle_Ventas_Load(object sender, EventArgs e)
        {
            textBoxCOdigg.Select();
        }

        private void clean()
        {
            textBoxCOdigg.Text = "";
            txC.Text = "";
            txCambio.Text = "";
            txDniClient.Text = "";
            txNameClient.Text = "";
            txPago.Text = "";
            txtFecha.Text = "";
            txTotal.Text = "";
            txtUsser.Text = "";
            dataGridventas2.Rows.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
