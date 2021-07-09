using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database                                 //hacer el lab05 para pasarlo de hardcore a SQL
{
    public class PlanAdapter : Adapter
    {
        public PlanAdapter() { }

        public List<Plan> GetAll()
        {
            return null;
        }

        public Business.Entities.Plan GetOne(int ID)
        {
            return null;
        }

        public void Delete(int ID)
        {
            
        }

        public void Save(Plan plan)
        {

        }

        //¿crear un metodo Update e Insert?
    }
}
