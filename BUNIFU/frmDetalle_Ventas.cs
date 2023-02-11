using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BUNIFU.Utilidades;
using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
                btnDescarga.Enabled = true;
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
            btnDescarga.Enabled = false;
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
            btnDescarga.Enabled = false;
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            //Lo primero que hay que hacer es convertir el codigo html a texto plano
            string textoHTML = Properties.Resources.PlantillaVenta.ToString();
            
            textoHTML = textoHTML.Replace("@tipodocumento", txC.Text);
            textoHTML = textoHTML.Replace("@numerodocumento", textBoxCOdigg.Text);
            textoHTML = textoHTML.Replace("@doccliente", txDniClient.Text);
            textoHTML = textoHTML.Replace("@nombrecliente", txNameClient.Text);
            textoHTML = textoHTML.Replace("@fecharegistro", txtFecha.Text);
            textoHTML = textoHTML.Replace("@usuarioregistro", txtUsser.Text);
            //textoHTML = textoHTML.Replace("@tipodocumento", txC.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridventas2.Rows)
            {
                filas += "<tr>";
                //filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            textoHTML = textoHTML.Replace("@filas", filas);
            textoHTML = textoHTML.Replace("@montototal", txTotal.Text);
            textoHTML = textoHTML.Replace("@pagocon", txPago.Text);
            textoHTML = textoHTML.Replace("@cambio", txCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Factura_{0}.pdf", textBoxCOdigg.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(textoHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);

                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Se Genero La factura Correctamente", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();
                }
            }
        }
    }
}
