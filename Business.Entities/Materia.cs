using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _Descripcion;
        private int _HSSemanales, _HSTotales, _IDMateria, _IDEspecialidad;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int HSSSemanales { get => _HSSemanales; set => _HSSemanales = value; }
        public int HSTotales { get => _HSTotales; set => _HSTotales = value; }
        public int IDPlan { get => _IDMateria; set => _IDMateria = value; }
        public int IDEspecialidad { get => _IDEspecialidad; set => _IDEspecialidad = value; }
    }
}
