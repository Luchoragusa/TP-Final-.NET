using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.Entidades
{
    public class Personas : BusinessEntity
    {
        private string _Apellido, _Direccion, _Email, _Nombre, _Telefono;
        private int _IDPlan, _Legajo;
        private DateTime _FechaNacimiento;

        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public int IDPlan { get => _IDPlan; set => _IDPlan = value; }
        public int Legajo { get => _Legajo; set => _Legajo = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        
        public TipoPersonas TipoPersona { get => _TipoPersona; set => _TipoPersona = value; }

        private TipoPersonas _TipoPersona;

        public enum TipoPersonas 
        {
            Alumno = 1,     
            Docente = 3,
            Administrador = 4,
            //Persona = 6,
        }
    }
}
