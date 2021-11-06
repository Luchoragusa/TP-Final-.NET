using Business.Entities;
using Business.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;

namespace Business.Logic.EntidadesLogic
{
    public class DocenteCursoLogic : BusinessLogic
    {
        private Data.Database.EntidadesDB.DocenteCursoAdapter docData;

        public DocenteCursoLogic()
        {
            docData = new Data.Database.EntidadesDB.DocenteCursoAdapter();
        }
        public Data.Database.EntidadesDB.DocenteCursoAdapter DocenteCursoData
        {
            get { return docData; }
            set { docData = value; }
        }

        public List<Materia> GetAllMateriasDelDocente(Usuario docente)
        {
            try
            {
                return DocenteCursoData.GetAllMateriaslDelDocente(docente);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista logica de Cursos.", ex);
                throw ExcepcionManejada;
            }
        }

        public List<Comision> GetAllComisionesDeLasMateriasDelDocente(Usuario docente)
        {
            try
            {
                return DocenteCursoData.GetAllComisionesDeLasMateriaslDelDocente(docente);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista logica de Cursos.", ex);
                throw ExcepcionManejada;
            }
        }

        public DocenteCurso GetOne(DocenteCurso dc)
        {
            try
            {
                return DocenteCursoData.GetOne(dc);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el docente del curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public List<DocenteCurso> GetAll()
        {
            try
            {
                return DocenteCursoData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de docentes del curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(DocenteCurso DocenteCurso)
        {
            try
            {
                DocenteCursoData.Save(DocenteCurso);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar el docente del curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Delete(int id)
        {
            try
            {
                DocenteCursoData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el docente del curso.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Insert(DocenteCurso DocenteCurso)
        {
            try
            {
                DocenteCursoData.Insert(DocenteCurso);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar un DocenteCurso.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(DocenteCurso DocenteCurso)
        {
            try
            {
                DocenteCursoData.Update(DocenteCurso);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar el DocenteCurso.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
