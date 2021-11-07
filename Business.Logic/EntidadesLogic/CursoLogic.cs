using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic.EntidadesLogic
{
    public class CursoLogic : BusinessLogic
    {
        private Data.Database.CursoAdapter cursoData;
        public CursoLogic()
        {
            cursoData = new Data.Database.CursoAdapter();
        }
        public Data.Database.CursoAdapter CursoData
        {
            get { return cursoData; }
            set { cursoData = value; }
        }

        public List<Curso> getCursosDelDocente(int idDoc)
        {
            List<Curso> cursosDelDocente = new List<Curso>();
            try
            {
                return CursoData.getCursosDelDocente(idDoc);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public Curso getByMateria(Materia mat)
        {
            try
            {
                return CursoData.getByMateria(mat);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la Materia.", ex);
                throw ExcepcionManejada;
            }
        }
        public Curso GetOne(Curso curso)
        {
            try
            {
                return CursoData.GetOne(curso);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public Curso GetCursoComision(int idComision)
        {
            try
            {
                return CursoData.GetcursoComision(idComision);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public List<Curso> GetAll()
        {
            try
            {
                return CursoData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista logica de Cursos.", ex);
                throw ExcepcionManejada;
            }
        }
    
        public List<Curso> GetAllDocente(Usuario docente)
        {
            try
            {
                return CursoData.GetAllByDocente(docente);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista logica de Cursos.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Business.Entities.Curso Curso)
        {
                try
                {
                    CursoData.Save(Curso);
                }
                catch (Exception ex)
                {
                    Exception ExcepcionManejada = new Exception("Error al guardar el Curso.", ex);
                    throw ExcepcionManejada;
                }
        }
        public void Delete(int id)
        {
            try
            {
                CursoData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el Curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Insert(Curso Curso)
        {
            try
            {
                CursoData.Insert(Curso);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar un curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Curso Curso)
        {
            try
            {
                CursoData.Update(Curso);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar el curso.", ex);
                throw ExcepcionManejada;
            }
        }
    }
  }

