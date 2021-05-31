using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter usData;

        public Data.Database.UsuarioAdapter UsuarioData
        {
            get 
            {
               return usData; 
            }
            set
            {
                usData = value; 
            }
        }

        public Business.Entities.Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();                //este llama al otro getAll y es un pasamanos, es decir
        }                                               //le pide a pepito y pepito pide, se lo pasa y se lo vuelve a pasar

        public void Save(Business.Entities.Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }

    }
}
