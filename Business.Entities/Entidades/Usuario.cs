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
        private string nombreUsuario, clave;
        private bool habilitado;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
