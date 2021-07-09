using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database                         //hacer el lab05 para pasarlo de hardcore a SQL
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            //return new List<Comision>(Comision)
            return null;
        }

        public Business.Entities.Comision GetOne(int ID)
        {
            return null;
        }

        public void Delete(int ID)
        {

        }

        public void Save(Comision comision)
        {

        }
    }
}
