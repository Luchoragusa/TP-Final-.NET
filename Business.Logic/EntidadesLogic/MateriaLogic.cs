using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        private MateriaAdapter materiaData;

        public MateriaLogic()
        {
            materiaData = new MateriaAdapter();
        }
        public MateriaAdapter MateriaData
        {
            get { return materiaData; }
            set { materiaData = value; }
        }
        public Materia GetOne(int id)
        {
            try
            {
                return MateriaData.GetOne(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el la materia.", ex);
                throw ExcepcionManejada;
            }  
        }

        public List<Materia> GetAll()
        {
            try
            {
                return MateriaData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de materias.", ex);
                throw ExcepcionManejada;
            }               
        }                                               

        public void Save(Materia materia)
        {
            try
            {
                MateriaData.Save(materia);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la materia (logic).", ex);
                throw ExcepcionManejada;
            }
        }
        public void Delete(int id)
        {
            try
            {
                MateriaData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la materia.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Insert(Materia materia)
        {
            try
            {
                MateriaData.Insert(materia);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar una materia.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Materia materia)
        {
            try
            {
                MateriaData.Update(materia);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar la materia.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
