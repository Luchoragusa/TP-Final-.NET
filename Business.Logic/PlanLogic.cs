using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        private Data.Database.PlanAdapter planData;

        public PlanLogic()
        {
            planData = new Data.Database.PlanAdapter();
        }
        public Data.Database.PlanAdapter PlanData
        {
            get{ return planData;}
            set{ planData = value;}
        }
        public Business.Entities.Plan GetOne(int id)
        {
            try
            {
                return PlanData.GetOne(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }     
        }
        public List<Plan> GetAll()
        {
            try
            {
                return PlanData.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }                    
        }                                               
        public void Save(Business.Entities.Plan plan)
        {
            try
            {
                PlanData.Save(plan);
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
                PlanData.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
