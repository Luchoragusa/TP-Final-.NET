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
        private ComisionAdapter comData;
        public ComisionLogic()
        {
            comData = new ComisionAdapter();
        }
        public ComisionAdapter ComisionData
        {
            get{ return comData;}
            set{ comData = value;}
        }
        public Comision GetOne(Comision com)
        {
            try
            {
                return ComisionData.GetOne(com);
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
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista logica de Comisiones.", ex);
                throw ExcepcionManejada;
            }       
        }

        public List<Comision> GetAllMateriasCom(Materia mat)
        {
            try
            {
                return ComisionData.GetAllMateriasCom(mat);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista logica de Comisiones.", ex);
                throw ExcepcionManejada;
            }
        }
        public void Save(Comision comision)
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
