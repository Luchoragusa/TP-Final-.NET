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
                Exception ExcepcionManejada = new Exception("Error al recuperar el usuario.", ex);
                throw ExcepcionManejada;
            }
        }

        public bool login(Usuario usuario)
        {
            try
            {
                if (UsuarioData.GetOneLogin(usuario) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el usuario.", ex);
                throw ExcepcionManejada;
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
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios.", ex);
                throw ExcepcionManejada;
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
                Exception ExcepcionManejada = new Exception("Error al guardar el usuario.", ex);
                throw ExcepcionManejada;
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
                Exception ExcepcionManejada = new Exception("Error al eliminar el usuario.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Insert(Usuario usuario)
        {
            try
            {
                UsuarioData.Insert(usuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar un usuario.", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                UsuarioData.Update(usuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar el usuario.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
