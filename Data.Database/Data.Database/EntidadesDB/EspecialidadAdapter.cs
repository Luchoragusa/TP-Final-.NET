using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public EspecialidadAdapter() { }
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * FROM especialidades", sqlConn);
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                if (drEspecialidades != null)
                {
                    while (drEspecialidades.Read())
                    {
                        Especialidad esp = new Especialidad();

                        esp.ID = (int)drEspecialidades["id_especialidad"];
                        esp.DescEspecialidad = (string)drEspecialidades["desc_especialidad"];

                        especialidades.Add(esp);
                    }
                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return especialidades;
        }
        public Especialidad GetOne(Especialidad esp)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * FROM especialidades WHERE id_especialidad = @id", sqlConn);
                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = esp.ID;
                SqlDataReader drespecialidad = cmdEspecialidades.ExecuteReader();
                if(drespecialidad != null)
                {
                    drespecialidad.Read();
                    esp.DescEspecialidad = (string)drespecialidad["desc_especialidad"];
                }
                drespecialidad.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return esp;
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Insert(Especialidad especialidad)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades (desc_especialidad)" +
                    "values(@desc_especialidad)" +
                    "select @@identity ", sqlConn);
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.DescEspecialidad;
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(Especialidad especialidad)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE especialidades SET desc_especialidad = @desc_especialidad WHERE id_especialidad = @id ", sqlConn);
                cmdUpd.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdUpd.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.DescEspecialidad;
                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidad.ID);
            }

            else if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
