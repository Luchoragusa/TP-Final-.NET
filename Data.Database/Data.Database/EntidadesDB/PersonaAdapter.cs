using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Entities.Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database.EntidadesDB
{
    public class PersonaAdapter : Adapter
    {
        public PersonaAdapter() { }

        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas", sqlConn);

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                if (drPersonas != null)
                {
                    while (drPersonas.Read())
                    {
                        Personas persona = new Personas();

                        persona.ID = (int)drPersonas["id_persona"];
                        persona.Nombre = (String)drPersonas["nombre"];
                        persona.Apellido = (String)drPersonas["apellido"];
                        persona.Direccion = (String)drPersonas["direccion"];
                        persona.Email = (String)drPersonas["email"];
                        persona.Telefono = (String)drPersonas["telefono"];
                        persona.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                        persona.Legajo = (int)drPersonas["legajo"];
                        persona.IDPlan = (int)drPersonas["id_plan"];
                        persona.IdUsuario = (int)drPersonas["id_usuario"];
                        int tipoPersona = (int)drPersonas["tipo_persona"];

                        if (tipoPersona == (int)Personas.TipoPersonas.Alumno)
                            persona.TipoPersona = Personas.TipoPersonas.Alumno;
                        else if (tipoPersona == (int)Personas.TipoPersonas.Docente)
                            persona.TipoPersona = Personas.TipoPersonas.Docente;
                        else
                            persona.TipoPersona = Personas.TipoPersonas.Administrador;

                        personas.Add(persona);
                    }
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Personas GetOne(Personas persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas WHERE id_persona = @id", sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                persona = null;

                if (drPersonas != null)
                {
                    persona = new Personas();
                    drPersonas.Read();
                    persona.ID = (int)drPersonas["id_persona"];
                    persona.Nombre = (String)drPersonas["nombre"];
                    persona.Apellido = (String)drPersonas["apellido"];
                    persona.Direccion = (String)drPersonas["direccion"];
                    persona.Email = (String)drPersonas["email"];
                    persona.Telefono = (String)drPersonas["telefono"];
                    persona.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    persona.Legajo = (int)drPersonas["legajo"];
                    persona.IDPlan = (int)drPersonas["id_plan"];
                    persona.IdUsuario = (int)drPersonas["id_usuario"];
                    int tipoPersona = (int)drPersonas["tipo_persona"];

                    if (tipoPersona == (int)Personas.TipoPersonas.Alumno)
                        persona.TipoPersona = Personas.TipoPersonas.Alumno;
                    else if (tipoPersona == (int)Personas.TipoPersonas.Docente)
                        persona.TipoPersona = Personas.TipoPersonas.Docente;
                    else
                        persona.TipoPersona = Personas.TipoPersonas.Administrador;
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return persona;
        }

        public Personas GetOneIDUsuario(Personas persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas WHERE id_usuario = @id", sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = persona.IdUsuario;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                persona = null;

                if (drPersonas != null)
                {
                    persona = new Personas();
                    drPersonas.Read();
                    persona.ID = (int)drPersonas["id_persona"];
                    persona.Nombre = (String)drPersonas["nombre"];
                    persona.Apellido = (String)drPersonas["apellido"];
                    persona.Direccion = (String)drPersonas["direccion"];
                    persona.Email = (String)drPersonas["email"];
                    persona.Telefono = (String)drPersonas["telefono"];
                    persona.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    persona.Legajo = (int)drPersonas["legajo"];
                    persona.IDPlan = (int)drPersonas["id_plan"];
                    persona.IdUsuario = (int)drPersonas["id_usuario"];
                    int tipoPersona = (int)drPersonas["tipo_persona"];

                    if (tipoPersona == (int)Personas.TipoPersonas.Alumno)
                        persona.TipoPersona = Personas.TipoPersonas.Alumno;
                    else if (tipoPersona == (int)Personas.TipoPersonas.Docente)
                        persona.TipoPersona = Personas.TipoPersonas.Docente;
                    else
                        persona.TipoPersona = Personas.TipoPersonas.Administrador;
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return persona;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar persona", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert(Personas persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO personas (nombre,apellido, direccion, email, telefono, fecha_nac, legajo,tipo_persona,id_plan, id_usuario)" +
                    "values(@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan, @id_usuario)" , sqlConn);

                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int, 50).Value = persona.TipoPersona;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = persona.IdUsuario;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear persona", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
           
        }

        public void Update(Personas persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE personas SET nombre = @nombre, apellido = @apellido, direccion = @direccion, email = @email, telefono = @telefono, fecha_nac = @fecha_nac, legajo = @legajo, tipo_persona = @tipo_persona, id_plan = @id_plan, id_usuario = @id_usuario WHERE id_persona = @id ", sqlConn);

                cmdUpd.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = persona.Nombre;
                cmdUpd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdUpd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdUpd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdUpd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdUpd.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdUpd.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdUpd.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TipoPersona;
                cmdUpd.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                cmdUpd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = persona.IdUsuario;

                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }


        public void Save(Personas persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                Delete(persona.ID);
            }

            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

    }
}
