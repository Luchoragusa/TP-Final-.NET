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
            get
            {
                return comData;
            }
            set
            {
                comData = value;
            }
        }
        public Business.Entities.Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }
        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }
        public void Save(Business.Entities.Comision comision)
        {
            ComisionData.Save(comision);
        }
        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }
    }
}
