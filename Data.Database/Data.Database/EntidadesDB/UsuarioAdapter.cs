using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Business.Entities.Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        #region DatosEnMemoria
        // Esta regi�n solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta ser� eliminada
        //private static List<Usuario> _Usuarios;

        //private static List<Usuario> Usuarios
        //{
        //    get
        //    {
        //        if (_Usuarios == null)
        //        {
        //            _Usuarios = new List<Business.Entities.Usuario>();
        //            Business.Entities.Usuario usr;
        //            usr = new Business.Entities.Usuario();
        //            usr.ID = 1;
        //            usr.State = Business.Entities.BusinessEntity.States.Unmodified;
        //            usr.Nombre = "Casimiro";
        //            usr.Apellido = "Cegado";
        //            usr.NombreUsuario = "casicegado";
        //            usr.Clave = "miro";
        //            usr.Email = "casimirocegado@gmail.com";
        //            usr.Habilitado = true;
        //            _Usuarios.Add(usr);

        //            usr = new Business.Entities.Usuario();
        //            usr.ID = 2;
        //            usr.State = Business.Entities.BusinessEntity.States.Unmodified;
        //            usr.Nombre = "Armando Esteban";
        //            usr.Apellido = "Quito";
        //            usr.NombreUsuario = "aequito";
        //            usr.Clave = "carpintero";
        //            usr.Email = "armandoquito@gmail.com";
        //            usr.Habilitado = true;
        //            _Usuarios.Add(usr);

        //            usr = new Business.Entities.Usuario();
        //            usr.ID = 3;
        //            usr.State = Business.Entities.BusinessEntity.States.Unmodified;
        //            usr.Nombre = "Alan";
        //            usr.Apellido = "Brado";
        //            usr.NombreUsuario = "alanbrado";
        //            usr.Clave = "abrete sesamo";
        //            usr.Email = "alanbrado@gmail.com";
        //            usr.Habilitado = true;
        //            _Usuarios.Add(usr);

        //        }
        //        return _Usuarios;
        //    }
        //}
        #endregion

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", sqlConn);

                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();

                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];

                    usuarios.Add(usr);
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usuarios;
        }

        #region EntityFramework Delete
        public void EliminarUno(int id)
        {
            using (tp2_netEntities db = new tp2_netEntities()) 
            {
                usuarios us = db.usuarios.Find(id);

                db.usuarios.Remove(us);
                db.SaveChanges();
            }
        }
        #endregion
        
        public Business.Entities.Usuario GetOne(int ID)         
        {
            Usuario usr = new Usuario();
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario = @id", sqlConn);  
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = ID;   
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return usr;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE usuarios WHERE id_usuario = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar usuario", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Insert(Usuario usuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO usuarios (nombre_usuario,clave,habilitado) values(@nombre_usuario,@clave,@habilitado)", sqlConn);

                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, habilitado = @habilitado WHERE id_usuario = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        
        public void Save(Usuario usuario)                   
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                Delete(usuario.ID);
                //EliminarUno(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

        public int GetOneLogin(Usuario usuario)
        {
            int tipo_persona = -1;
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select per.tipo_persona from personas per left join usuarios u on u.id_usuario = per.id_usuario where u.nombre_usuario = @nombre_usuario and u.clave = @clave;", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdUsuarios.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                if (drUsuarios != null)
                {
                    drUsuarios.Read();
                    if (drUsuarios["tipo_persona"] != null)
                    {
                        tipo_persona = (int)(Personas.TipoPersonas)drUsuarios["tipo_persona"];
                    }
                    else
                    {
                        tipo_persona = 4;
                    }                    
                }
             drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el tipo de usuario al logearse", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return tipo_persona;
        }

        public Usuario GetUsuario(Usuario u)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT us.id_usuario, us.nombre_usuario, us.clave, us.habilitado FROM usuarios us inner join personas on personas.id_persona = us.id_persona WHERE nombre_usuario = @nombre_usuario and clave = @clave", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = u.NombreUsuario;
                cmdUsuarios.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = u.Clave;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                u = null;

                if (drUsuarios != null)
                {
                    while (drUsuarios.Read())
                    {
                        u = new Usuario();
                        u.ID = (int)drUsuarios["id_usuario"];
                        u.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                        u.Clave = (string)drUsuarios["clave"];
                        u.Habilitado = (bool)drUsuarios["habilitado"];
                    }
                }
                
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos del usuario al logearse", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return u;
        }
    }
}
