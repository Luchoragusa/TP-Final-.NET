using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private string _DescComision;
        private int _AnioEspecialidad, _IDPlan;

        public string DescComision { get => _DescComision; set => _DescComision = value; }
        public int AnioEspecialidad { get => _AnioEspecialidad; set => _AnioEspecialidad = value; }
        public int IDPlan { get => _IDPlan; set => _IDPlan = value; }
    }
}
