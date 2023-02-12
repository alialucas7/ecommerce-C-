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

<<<<<<< HEAD
        private void Backup_Click_1(object sender, EventArgs e)
        {
            Bckp_progressBar.Value = 0;
            try
            {
                //Se establecen las conexiones con el servidor, la base de datos y la dirección para guardar la copia de seguridad
                Server dbServer = new Server(new ServerConnection(bckp_Servidor.Texts, Bckp_Usuario.Texts, Bckp_Contraseña.Texts));                             //Tipo de de archivos que se obtiene del forulario del Backup
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = bckp_BasedeDatos.Texts };                                       //Nombre de la base de datos que se obtiene del formulario del Backup
                dbBackup.Devices.AddDevice(@"D:\Mis Documentos\Escritorio\Taller de Programación II\Backup Proyecto\BDdealership.bak", DeviceType.File);        //Ruta donde se alojará la copia de seguridad

                dbBackup.Initialize = true;                                 //Dejamos el valor inicializado en falso, para crear un nuevo elemento de copia de seguridad
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);

                MessageBox.Show("¡La Copia de Seguridad se ha Creado de Manera Exitosa!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

=======
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
        //Se realizan llamadas seguras a los subprocesos para evitar errores forzados del windows form y que se invoquen métodos que interactúen con controles de propiedad de otros subprocesos
        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                Bckp_Estado.Invoke((MethodInvoker)delegate                  //Eso nos permite la ejecución sincrónica de métodos en los controles
                {                                                           //Para ello usuamos un delegado con el nombre del método que lo invocará
                    Bckp_Estado.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
<<<<<<< HEAD
        { 
=======
        {
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
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
        private void bckp_Servidor__Textchanged(object sender, EventArgs e)
<<<<<<< HEAD
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
        private void bckp_BasedeDatos__Textchanged(object sender, EventArgs e)
=======
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
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
        private void bckp_BasedeDatos__Textchanged(object sender, EventArgs e)
        {
           
        }

        ErrorProvider errorUser = new ErrorProvider();
        //Validar como campo obligatorio el usuario
        private void Bckp_Usuario__Textchanged(object sender, EventArgs e)
        {
            
        }

        ErrorProvider errorPass = new ErrorProvider();
        //Validar como campo obligatorio la contraseña
        private void Bckp_Contraseña__Textchanged(object sender, EventArgs e)
<<<<<<< HEAD
=======
        {
            
        }

        ErrorProvider errorRepetPass = new ErrorProvider();
        //Validar como campo obligatorio repetir contraseña
        private void Bckp_ConfirmaContraseña_Leave(object sender, EventArgs e)
        {

        }

        //Comparamos los valores de los texbox de las contraseñas
        private void Bckp_ConfirmaContraseña__Textchanged_1(object sender, EventArgs e)
        {
            
        }

        private void Backup_Click_1(object sender, EventArgs e)
        {
                Bckp_progressBar.Value = 0;
            try
            {
                //Se establecen las conexiones con el servidor, la base de datos y la dirección para guardar la copia de seguridad
                Server dbServer = new Server(new ServerConnection(bckp_Servidor.Texts, Bckp_Usuario.Texts, Bckp_Contraseña.Texts));                             //Tipo de de archivos que se obtiene del forulario del Backup
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = bckp_BasedeDatos.Texts };                                       //Nombre de la base de datos que se obtiene del formulario del Backup
                //dbBackup.Devices.AddDevice(@"D:\Mis Documentos\Escritorio\Taller de Programación II\Backup Proyecto\BDdealership.bak", DeviceType.File);        //Ruta donde se alojará la copia de seguridad
                dbBackup.Devices.AddDevice(@"C:\Users\alialucas7\Desktop\AliaLucas_Proyectot2\backup\BDdealership.bak", DeviceType.File);        //Ruta donde se alojará la copia de seguridad

                dbBackup.Initialize = true;                                 //Dejamos el valor inicializado en falso, para crear un nuevo elemento de copia de seguridad
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);

                MessageBox.Show("¡La Copia de Seguridad se ha Creado de Manera Exitosa!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bckp_BasedeDatos__Textchanged_1(object sender, EventArgs e)
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
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

<<<<<<< HEAD
        ErrorProvider errorRepetPass = new ErrorProvider();
        //Validar como campo obligatorio repetir contraseña
        private void Bckp_ConfirmaContraseña_Leave_1(object sender, EventArgs e)
=======
        private void Bckp_Usuario__Textchanged_1(object sender, EventArgs e)
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
        {
            string validaCampos;
            validaCampos = Bckp_Usuario.Texts;
            if (validaCampos == "")
            {
<<<<<<< HEAD
                errorRepetPass.SetError(Bckp_Contraseña, "¡Campo Obligatorio! Debe volver ingresar la Contraseña");
=======
                errorUser.SetError(Bckp_Usuario, "¡Campo Obligatorio! Debe ingresar el Nombre de Usuario");
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
            }
            else
                errorUser.Clear();
        }

        private void Bckp_Contraseña__Textchanged_1(object sender, EventArgs e)
        {
           
        }

<<<<<<< HEAD
        //Comparamos los valores de los texbox de las contraseñas
        private void Bckp_ConfirmaContraseña__Textchanged_1(object sender, EventArgs e)
=======
        private void Bckp_ConfirmaContraseña__Textchanged(object sender, EventArgs e)
>>>>>>> d10cbdcb7eaa31867051e29eb66bdc620107f693
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