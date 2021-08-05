using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.Entidades
{
    public class Alumnos_Inscripciones : BusinessEntity
    {
        private string _Condicion;
        private int _IDAlumno, _IDCurso, _Nota;

        public string Condicion { get => _Condicion; set => _Condicion = value; } // Regular, Libre, Aprobado, Cursando
        public int IDAlumno { get => _IDAlumno; set => _IDAlumno = value; }
        public int IDCurso { get => _IDCurso; set => _IDCurso = value; }
        public int Nota { get => _Nota; set => _Nota = value; }
    }


}
