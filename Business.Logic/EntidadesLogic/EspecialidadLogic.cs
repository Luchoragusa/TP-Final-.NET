using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter especialidadData;

        public EspecialidadLogic()
        {
            especialidadData = new EspecialidadAdapter();
        }
        public EspecialidadAdapter EspecialidadData
        {
            get { return especialidadData; }
            set { especialidadData = value; }
        }
        public Especialidad GetOne(int id)
        {
            try
            {
                return EspecialidadData.GetOne(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la especialidad.", ex);
                throw ExcepcionManejada;
            }
        }
        public List<Especialidad> GetAll()
        {
            try
            {
                return EspecialidadData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de especialidades.", ex);
                throw ExcepcionManejada;
            }

        }
        public void Save(Business.Entities.Especialidad especialidad)
        {
            try
            {
                EspecialidadData.Save(especialidad);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la especialidad.", ex);
                throw ExcepcionManejada;
            }
        }
        public void Delete(int id)
        {
            try
            {
                EspecialidadData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la especialidad.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Especialidad especialidad)
        {
            try
            {
                EspecialidadData.Update(especialidad);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar el usuario.", ex);
                throw ExcepcionManejada;
            }

        }

        public void Insert(Especialidad especialidad)
        {
            try
            {
                EspecialidadData.Insert(especialidad);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar la especialidad.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}

