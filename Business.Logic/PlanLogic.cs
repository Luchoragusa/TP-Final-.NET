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
            get { return planData;}
            set{ planData = value; }
        }


        public Business.Entities.Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();                //este llama al otro getAll y es un pasamanos, es decir
        }                                               //le pide a pepito y pepito pide, se lo pasa y se lo vuelve a pasar

        public void Save(Business.Entities.Plan plan)
        {
            PlanData.Save(plan);
        }
        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
