using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario
    {
        private int idUsuario, idModulo;
        private bool permiteAlta, permiteBaja, permiteModificacion, permiteConsulta; 

        public int IdUsuario { get => idUsuario; set => idUsuario = value; } 
        public int IdModulo { get => idModulo; set => idModulo = value; }
        public bool PermiteAlta { get => permiteAlta; set => permiteAlta = value; }
        public bool PermiteBaja { get => permiteBaja; set => permiteBaja = value; }
        public bool PermiteModificacion { get => permiteModificacion; set => permiteModificacion = value; }
        public bool PermiteConsulta { get => permiteConsulta; set => permiteConsulta = value; }
    }
}
