using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity                      //sacar nombre y apellido y mail           
    {
        private string nombreUsuario, clave;
        private bool habilitado;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
