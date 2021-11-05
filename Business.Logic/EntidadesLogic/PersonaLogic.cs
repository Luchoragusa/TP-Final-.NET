using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities.Entidades;
using Data.Database.EntidadesDB;

namespace Business.Logic.EntidadesLogic
{
    public class PersonaLogic : BusinessLogic
    {
        private PersonaAdapter personaData;

        public PersonaLogic()
        {
            personaData = new PersonaAdapter();
        }
        public PersonaAdapter PersonaData
        {
            get { return personaData; }
            set { personaData = value; }
        }

        public Personas GetOne(Personas p)
        {
            try
            {
                return PersonaData.GetOne(p);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la Persona.", ex);
                throw ExcepcionManejada;
            }
        }

        public List<Personas> GetAll()
        {
            try
            {
                return PersonaData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de personas.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Personas persona)
        {
            try
            {
                PersonaData.Save(persona);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la persona.", ex);
                throw ExcepcionManejada;
            }
        }
        public void Delete(int id)
        {
            try
            {
                PersonaData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la Persona.", ex);
                throw ExcepcionManejada;
            }
        }
        public void Insert(Personas persona)
        {
            try
            {
                PersonaData.Insert(persona);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar una persona.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Personas persona)
        {
            try
            {
                PersonaData.Insert(persona);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar una persona.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
