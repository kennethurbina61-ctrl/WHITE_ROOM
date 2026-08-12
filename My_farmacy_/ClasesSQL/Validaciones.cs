using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_farmacy_
{
    internal class Validaciones
    {
        public static bool solonumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
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

        public static bool sololetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || char.IsControl(e.KeyChar))
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
        public static bool txtvacios(TextBox txt)
        {
            if (txt.Text == string.Empty)
            {
                MessageBox.Show("No puede dejar campos vacios.");
                txt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidarEmail(string correo)
        {
            // Evita crash si es null o vacío
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            // Regex que permite letras, números y símbolos comunes
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(correo, patron, RegexOptions.IgnoreCase);
        }
    }
}
