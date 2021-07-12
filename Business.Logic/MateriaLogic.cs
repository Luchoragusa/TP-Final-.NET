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
            return MateriaData.GetOne(id);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();                //este llama al otro getAll y es un pasamanos, es decir
        }                                               //le pide a pepito y pepito pide, se lo pasa y se lo vuelve a pasar

        public void Save(Materia plan)
        {
            MateriaData.Save(plan);
        }
        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }
    }
}
