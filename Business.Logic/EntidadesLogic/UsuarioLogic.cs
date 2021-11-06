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
        private UsuarioAdapter usData;

        public UsuarioLogic()
        {
            usData = new UsuarioAdapter();
        }
        public UsuarioAdapter UsuarioData
        {
            get { return usData;}
            set { usData = value;}
        }
        public Usuario GetOne(Usuario u)
        {
            try
            {
                return UsuarioData.GetOne(u);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el usuario.", ex);
                throw ExcepcionManejada;
            }
        }

        public int login(Usuario usuario)
        {
            try
            {
                return UsuarioData.GetOneLogin(usuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el usuario.", ex);
                throw ExcepcionManejada;
            }
        }

        public Usuario GetUsuario(Usuario u)
        {
            return UsuarioData.GetUsuario(u);
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

        public void Save(Usuario usuario)
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

        //public void EliminarUno(int id)               EntityFramework
        //{
        //    try
        //    {
        //        UsuarioData.EliminarUno(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al eliminar el usuario.", ex);
        //        throw ExcepcionManejada;
        //    }
        //}
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
