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
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", sqlConn);

                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios != null)
                {
                    while (drUsuarios.Read())
                    {
                        Usuario usr = new Usuario();

                        usr.ID = (int)drUsuarios["id_usuario"];
                        usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                        usr.Clave = (string)drUsuarios["clave"];
                        usr.Habilitado = (bool)drUsuarios["habilitado"];

                        usuarios.Add(usr);
                    }
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
        
        public Usuario GetOne(Usuario usr)         
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario = @id", sqlConn);  
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = usr.ID;   
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios != null)
                {
                    drUsuarios.Read();
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
                SqlCommand cmdUsuarios = new SqlCommand("select p.tipo_persona from usuarios u left join personas p on p.id_usuario = u.id_usuario where u.nombre_usuario = @nombre_usuario and u.clave = @clave", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdUsuarios.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                

                if (drUsuarios != null)
                {
                    if (drUsuarios.Read())
                    {
                        if (!string.IsNullOrEmpty(drUsuarios["tipo_persona"].ToString()))
                        {
                            tipo_persona = (int)(Personas.TipoPersonas)drUsuarios["tipo_persona"];
                        }
                        else
                        {
                            tipo_persona = 4;
                        }
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
        public Usuario GetUsuario(Usuario u)        //parametros nombre_usuario y clave
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario and clave = @clave", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = u.NombreUsuario;
                cmdUsuarios.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = u.Clave;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                u = null;
                if (drUsuarios != null)
                {
                    drUsuarios.Read();
                    u = new Usuario();
                    u.ID = (int)drUsuarios["id_usuario"];
                    u.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    u.Clave = (string)drUsuarios["clave"];
                    u.Habilitado = (bool)drUsuarios["habilitado"];
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
