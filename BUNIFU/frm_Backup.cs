using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUNIFU.Controles_graficos;
using System.Data.SqlClient;

namespace BUNIFU
{
    public partial class frm_Backup : Form
    {
        public frm_Backup()
        {
            InitializeComponent();
        }

        //SqlConnection conexion = new SqlConnection("SERVER=.;DATABASE=BD_dealership;Uid=14278294;Pwd =3264"); 
 
        private void Backup_Click(object sender, EventArgs e)
        {
            Bckp_progressBar.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(bckp_Servidor.Text, Bckp_Usuario.Text, Bckp_Contraseña.Text));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = bckp_BasedeDatos.Text};
                dbBackup.Devices.AddDevice(@"D:\Mis Documentos\Escritorio\Taller de Programación II\Backup Proyecto\BD_dealership.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                Bckp_Estado.Invoke((MethodInvoker)delegate
                {
                    Bckp_Estado.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Bckp_progressBar.Invoke((MethodInvoker)delegate 
            {
                Bckp_progressBar.Value = e.Percent;
                Bckp_progressBar.Update();
            });

            Bckp_Porcentaje.Invoke((MethodInvoker)delegate
            {
                Bckp_Porcentaje.Text = $"{e.Percent}%";
            });
        }

        ErrorProvider errorSer = new ErrorProvider();
        //Validar como campo obligatorio Servidor
        private void bckp_Servidor_Leave(object sender, EventArgs e)
        {
                string validaCampos;
                validaCampos = bckp_Servidor.Texts;
                if (validaCampos == "")
                {
                    errorSer.SetError(bckp_Servidor, "¡Campo Obligatorio! Debe ingresar El Servidor");
                }
                else
                    errorSer.Clear();
            
        }

        ErrorProvider errorDB = new ErrorProvider();
        //Validar como campo obligatorio la base de datos
        private void bckp_BasedeDatos_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = bckp_BasedeDatos.Texts;
            if (validaCampos == "")
            {
                errorDB.SetError(bckp_BasedeDatos, "¡Campo Obligatorio! Debe ingresar una Base de Datos");
            }
            else
                errorDB.Clear();
        }

        ErrorProvider errorUser = new ErrorProvider();
        //Validar como campo obligatorio el usuario
        private void Bckp_Usuario_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = Bckp_Usuario.Texts;
            if (validaCampos == "")
            {
                errorUser.SetError(Bckp_Usuario, "¡Campo Obligatorio! Debe ingresar el Nombre de Usuario");
            }
            else
                errorUser.Clear();
        }

        ErrorProvider errorPass = new ErrorProvider();
        //Validar como campo obligatorio la contraseña
        private void Bckp_Contraseña_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = Bckp_Contraseña.Texts;
            if (validaCampos == "")
            {
                errorPass.SetError(Bckp_Contraseña, "¡Campo Obligatorio! Debe ingresar la Contraseña");
            }
            else
                errorPass.Clear();
        }

        ErrorProvider errorRepetPass = new ErrorProvider();
        //Validar como campo obligatorio repetir contraseña
        private void Bckp_ConfirmaContraseña_Leave(object sender, EventArgs e)
        {
            string validaCampos;
            validaCampos = Bckp_ConfirmaContraseña.Texts;
            if (validaCampos == "")
            {
                errorRepetPass.SetError(Bckp_ConfirmaContraseña, "¡Campo Obligatorio! Vuelva a escribir su Contraseña");
            }
            else
                errorRepetPass.Clear();
        }

        //Comparamos los valores de los texbox de las contraseñas
        private void Bckp_ConfirmaContraseña__Textchanged(object sender, EventArgs e)
        {
            if (Bckp_ConfirmaContraseña.Texts == Bckp_Contraseña.Texts)
            {
                clavesIguales.ForeColor = Color.Green;
                clavesIguales.Text = "¡Contraseña Correcta!";
            }
            else
            {
                clavesIguales.ForeColor = Color.Red;
                clavesIguales.Text = "¡Contraseña Incorrecta!";
            }
        }
    }
}
