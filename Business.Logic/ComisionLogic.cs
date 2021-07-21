using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        private Data.Database.ComisionAdapter comData;
        public ComisionLogic()
        {
            comData = new Data.Database.ComisionAdapter();
        }
        public Data.Database.ComisionAdapter ComisionData
        {
            get{ return comData;}
            set{ comData = value;}
        }
        public Business.Entities.Comision GetOne(int id)
        {
            try
            {
                return ComisionData.GetOne(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la comision.", ex);
                throw ExcepcionManejada;
            }
        }
        public List<Comision> GetAll()
        {
            try
            {
                return ComisionData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de comisiones.", ex);
                throw ExcepcionManejada;
            }       
        }
        public void Save(Business.Entities.Comision comision)
        {
            try
            {
                ComisionData.Save(comision);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la comision.", ex);
                throw ExcepcionManejada;
            }   
        }
        public void Delete(int id)
        {
            try
            {
                ComisionData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la comision.", ex);
                throw ExcepcionManejada;
            }  
        }

        public void Insert(Comision comision)
        {
            try
            {
                ComisionData.Insert(comision);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar una materia.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Comision comision)
        {
            try
            {
                ComisionData.Update(comision);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar la materia.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
