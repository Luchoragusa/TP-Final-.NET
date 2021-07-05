using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class Validaciones
    {
        public static bool EsMailValido(string unMail)
        {
          bool rta = false;
          String expresion = @"\A(\w+.?\w*@\w+.)(com)\Z";
          if (Regex.IsMatch(unMail, expresion))
          {
                if (Regex.Replace(unMail, expresion, String.Empty).Length == 0)
                {
                    rta = true;
                }
            }
          return rta;
        }

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

        public static bool Clave_Conf(string clave, string conf)
        {
            if (clave.Equals(conf))
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
