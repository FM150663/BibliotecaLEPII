using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Libreria
{
    class validation
    {
        public void soloLetrasLog(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))//si es letra, la deja pasar
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))//si quiere borrar, lo permite
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo letras, sin espacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void noEspacios(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsSeparator(e.KeyChar))//lo unico que no permite son espacios
                {
                    e.Handled = true;// por eso es true y no false
                    MessageBox.Show("No se permiten espacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))//si es letra, la deja pasar
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))//si quiere borrar, lo permite
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                    MessageBox.Show("Sólo se permiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar)) //es lo mismo para numeros solo que ya no es letter, ahora es number
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))//permite borrar
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))//permite espacios de por medio
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == '.')//permite puntos
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void letrasNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar)) //es lo mismo para numeros solo que ya no es letter, ahora es number
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten digitos, numeros o Guiones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void numerosGuiones(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar)) 
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == '-')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten digitos o guiones ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public static bool validarEmail(String email) //método para validar el email ingresado 
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion)) //Indica si la expresión regular especificada encuentra una coincidencia en la cadena de entrada especificada
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool validarDUI(String DUI) //método para validar el email ingresado 
        {
            String expresion;
            expresion = "^\\d{8}-\\d$";
            if (Regex.IsMatch(DUI, expresion)) //Indica si la expresión regular especificada encuentra una coincidencia en la cadena de entrada especificada
            {
                if (Regex.Replace(DUI, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool validarPasaporte(String email) //método para validar el email ingresado 
        {
            String expresion;
            expresion = "/^[A-Z]{3}[0-9]{6}[a-z]?$/i";
            if (Regex.IsMatch(email, expresion)) //Indica si la expresión regular especificada encuentra una coincidencia en la cadena de entrada especificada
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool validarISBN(String ISBN) //método para validar el ISBN 
        {
            String expresion;
            expresion = @"\d{1,5}([- ])\d{1,7}\1\d{1,6}\1(\d|X)";
            if (Regex.IsMatch(ISBN, expresion)) //Indica si la expresión regular especificada encuentra una coincidencia en la cadena de entrada especificada
            {
                if (Regex.Replace(ISBN, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool validarAnio(string anio) //método para validar el ISBN 
        {
            int Anio ;
            if(!int.TryParse(anio,out Anio))
            {
                return false;
            }
            if (Anio>-1 && Anio<= DateTime.Now.Year) { 
                    return true;
            }
            else
            {
                return false;
            }
        }
    }
}
