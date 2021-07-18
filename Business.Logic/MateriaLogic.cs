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
                throw ex;
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
                throw ex;
            }               
        }                                               

        public void Save(Materia plan)
        {
            try
            {
                MateriaData.Save(plan);
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
            }
        }
    }
}
