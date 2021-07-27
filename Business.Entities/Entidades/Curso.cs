using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario, _Cupo, _IDComision, _IDMateria;
        private string _Descripcion;

        public int AnioCalendario { get => _AnioCalendario; set => _AnioCalendario = value; }
        public int Cupo { get => _Cupo; set => _Cupo = value; }
        public int IDComision { get => _IDComision; set => _IDComision = value; }
        public int IDMateria { get => _IDMateria; set => _IDMateria = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
