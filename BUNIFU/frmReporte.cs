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
using BUNIFU.Controles_graficos;
using Bunifu.Framework.UI;
using System.Data.Sql;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.Windows.Forms.DataVisualization.Charting;

namespace BUNIFU
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {

            
           

            foreach (DataGridViewColumn columna in dataGridViewReporte.Columns)
                
            {
                ComboBoxBuscarPor.Items.Add(new OpcionCombobox() { valor = columna.Name, Texto = columna.HeaderText });
            }
            ComboBoxBuscarPor.DisplayMember = "Texto";
            ComboBoxBuscarPor.ValueMember = "Valor";
            ComboBoxBuscarPor.SelectedIndex = 0;
        }

        //Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombobox)ComboBoxBuscarPor.SelectedItem).valor.ToString();
            if (dataGridViewReporte.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewReporte.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(userBuscar.Texts.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }

        }

        private void BuscarPorFecha_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List <ReporteVenta>();

            //El metodo venta req 2 parametros de fecha
            lista = new CN_Reporte().Venta(dateTimeFechaInicio.Value.ToString(), dateTimeFechaFin.Value.ToString());

            dataGridViewReporte.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                dataGridViewReporte.Rows.Add(new object[] {
                    rv.fecha_creacion,
                    rv.codigoFactura,
                    rv.monto_Total,
                    rv.Nombre_Usuario,
                    rv.Apellido_Usuario,
                    rv.dni_cliente,
                    rv.nombre_cliente,
                    
                });
            }
            /*Luego de traer los datos muestra grafico*/
            generarGraficc();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            userBuscar.Texts = "";
            foreach (DataGridViewRow row in dataGridViewReporte.Rows)
            {
                row.Visible = true;
            }
        }

        private void DescargaExcel_Click(object sender, EventArgs e)
        {
            if(dataGridViewReporte.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dataGridViewReporte.Columns)
                {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dataGridViewReporte.Rows)
                {
                    if(row.Visible)
                        dt.Rows.Add(new object[]{
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                      

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVenta_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al Generar Reporte", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        /*Metodo grafico*/
        private void btnCargarData_Click(object sender, EventArgs e)
        {
            DataTable dt = new CN_Reporte().grafico2();

            grafict.Titles.Add("Marca mas vendida");
            
            foreach (DataRow row in dt.Rows)
            {
                Series series = grafict.Series.Add(row["descripcionMarca"].ToString());
                series.Points.Add(Convert.ToDouble(row["cantidad mas vendida"].ToString()));
                series.Label = row["cantidad mas vendida"].ToString();
            }
        }


        private void generarGraficc()
        {
            DataTable dt = new CN_Reporte().grafico();

            grafict.Titles.Add("Automoviles vendidos por sucursal");

            foreach (DataRow row in dt.Rows)
            {
                Series series = grafict.Series.Add(row["descripcionSucur"].ToString());
                series.Points.Add(Convert.ToDouble(row["cantidad de autos vendidos"].ToString()));
                series.Label = row["cantidad de autos vendidos"].ToString();
            }
        }
    }
}
