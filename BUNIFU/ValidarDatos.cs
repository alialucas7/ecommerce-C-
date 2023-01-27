using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUNIFU.Controles_graficos;

namespace BUNIFU
{
    class ValidarDatos
    {
        //Método para ingresar sólo números

       public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsSeparator(e.KeyChar)) //Permite espacios
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        //Método para ingresar sólo letras
        public static bool soloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        //Método para campos vacíos
       public static bool textosVacios(UserControl1 pTxt)
        {

            if (pTxt.Text == string.Empty)
            {
                pTxt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

         //Método para validar email
         public static bool validarEmail(string pCorreo)
         {
             return pCorreo != null && Regex.IsMatch(pCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
         }
    }
}
