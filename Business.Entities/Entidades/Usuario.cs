using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Entities.Entidades;

namespace Business.Entities
{
    public class Usuario : BusinessEntity                             
    {
        private string nombreUsuario, clave, _nombre, _apellido, _email;
        private bool habilitado;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
