using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Logic
{
    public static class Validaciones
    {
        public static bool validarClave(string clave)
        {
            string formato = "^([a-zA-Z0-9]{4,16})$";
            Regex r = new Regex(formato);
            if (r.IsMatch(clave)) 
            { 
                return true; 
            }
            else 
            {
                return false; 
            }
        }

        public static bool validarTexto(string texto)
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");

            if (Val.IsMatch(texto))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       
        public static bool validarAlphaNumerico(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i]))))
                    return false;
            }

            return true;
        }
        
        public static bool validarMail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
