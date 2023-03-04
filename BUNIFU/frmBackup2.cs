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

namespace BUNIFU
{
    public partial class frmBackup2 : Form
    {
        int porcentaje = 0;

        public frmBackup2()
        {
            InitializeComponent();
        }

        private void frmBackup2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*variable que trae la fecha actual*/
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "_" + System.DateTime.Now.Hour.ToString() + "__" + System.DateTime.Now.Minute.ToString() + "__" + System.DateTime.Now.Second.ToString() + "LimitedEdition.bak");

            if (MessageBox.Show("¿Está seguro que desea realizar la copia de seguridad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("La copia de Seguridad se procedera a crear y tendra el sig name " + nombre_copia + "¿Desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    porcentaje = porcentaje + 100;
                    porcentajeLabel.Text = porcentaje.ToString() + " %";          //Progress Bar
                    progressBar.Value = porcentaje;


                    string mensaje = string.Empty;


                    string queryBkup = "BACKUP DATABASE [BD_dealership] TO  DISK = N'C:\\temp\\BDdealership" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'BD_dealership-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                    CN_Backup backup = new CN_Backup();

                    int resultado = backup.generarbackup(queryBkup, out mensaje);


                    if (resultado == 1)
                    {
                        if (MessageBox.Show("El backup se realizo correctamente") == DialogResult.OK)
                        {
                            progressBar.Value = 0;
                            porcentajeLabel.Text = "0%";
                        }
                           
                    }
                    else
                    {
                        MessageBox.Show(mensaje.ToString());
                    }
                }
            }



        }

        private void Estado_Click(object sender, EventArgs e)
        {

        }
    }
}
