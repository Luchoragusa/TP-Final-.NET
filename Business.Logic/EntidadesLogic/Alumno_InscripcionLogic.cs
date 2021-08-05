using Business.Entities;
using Business.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Data.Database.EntidadesDB;

namespace Business.Logic.EntidadesLogic
{
    public class Alumno_InscripcionLogic : BusinessLogic
    {
        private Data.Database.EntidadesDB.AlumnosIncriptosAdapter aiData;

        public Alumno_InscripcionLogic()
        {
            aiData = new Data.Database.EntidadesDB.AlumnosIncriptosAdapter();
        }
        public Data.Database.EntidadesDB.AlumnosIncriptosAdapter Alumno_InscripcionData
        {
            get { return aiData; }
            set { aiData = value; }
        }
        public Alumnos_Inscripciones GetOne(int id)
        {
            try
            {
                return Alumno_InscripcionData.GetOne(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el alumno inscripto.", ex);
                throw ExcepcionManejada;
            }
        }

        public List<Alumnos_Inscripciones> GetAll()
        {
            try
            {
                return Alumno_InscripcionData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de alumnos inscripto.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Alumnos_Inscripciones Alumno_Inscripcion)
        {
            try
            {
                Alumno_InscripcionData.Save(Alumno_Inscripcion);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar el alumno inscripto.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Delete(int id)
        {
            try
            {
                Alumno_InscripcionData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el alumno inscripto.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Insert(Alumnos_Inscripciones Alumno_Inscripcion)
        {
            try
            {
                Alumno_InscripcionData.Insert(Alumno_Inscripcion);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar el alumno inscripto.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Alumnos_Inscripciones Alumno_Inscripcion)
        {
            try
            {
                Alumno_InscripcionData.Update(Alumno_Inscripcion);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar el alumno inscripto.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
