using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter usData;

        public UsuarioLogic()
        {
            usData = new Data.Database.UsuarioAdapter();
        }
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return usData;}
            set { usData = value;}
        }
        public Business.Entities.Usuario GetOne(int id)
        {
            try
            {
                return UsuarioData.GetOne(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                return UsuarioData.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }                
        }                                               

        public void Save(Business.Entities.Usuario usuario)
        {
            try
            {
                UsuarioData.Save(usuario);
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
                UsuarioData.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
