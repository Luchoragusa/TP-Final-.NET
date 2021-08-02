using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.Entidades
{
    public class DocenteCurso : BusinessEntity
    {
        private TipoCargos _Cargo;
        private int _IDCurso, _IDDocente;
        public TipoCargos Cargo { get => _Cargo; set => _Cargo = value; }
        public int IDCurso { get => _IDCurso; set => _IDCurso = value; }
        public int IDDocente { get => _IDDocente; set => _IDDocente = value; }

        public enum TipoCargos
        {
            Titular = 1,
            Auxiliar = 2,
            JefeCatedra = 3
        }
    }
}
