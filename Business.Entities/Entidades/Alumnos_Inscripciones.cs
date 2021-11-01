using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.Entidades
{
    public class Alumnos_Inscripciones : BusinessEntity
    {
        private string _Condicion, _Nota;
        private int _IDAlumno, _IDCurso;
        private Personas personas;

        public string NombrePersona
        {
            get => personas.Nombre;
        }

        public string ApellidoPersona
        {
            get => personas.Apellido;
        }
        public int legajoPersona
        {
            get => personas.Legajo;
        }


        public Alumnos_Inscripciones()
        {
            this.personas = new Personas();
        }
        public string Condicion { get => _Condicion; set => _Condicion = value; } // Regular, Libre, Aprobado, Cursando
        public int IDAlumno { get => _IDAlumno; set => _IDAlumno = value; }
        public int IDCurso { get => _IDCurso; set => _IDCurso = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public Personas Personas { get => personas; set => personas = value; }
    }
}
