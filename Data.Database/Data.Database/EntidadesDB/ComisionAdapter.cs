using System;
using System.Collections.Generic;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database                         
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = null;
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("SELECT * FROM comisiones", sqlConn);
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision != null)
                {
                    comisiones = new List<Comision>();
                    while (drComision.Read())
                    {
                        Comision com = new Comision();
                        com.ID = (int)drComision["id_comision"];
                        com.DescComision = (string)drComision["desc_comision"];
                        com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                        com.IDPlan = (int)drComision["id_plan"];

                        comisiones.Add(com);
                    }
                }
                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de Comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }

        public List<Comision> GetAllByAlumno(Usuario u)
        {
            List<Comision> comisiones = null;
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select co.* from comisiones co inner join cursos cu on cu.id_comision = co.id_comision inner join alumnos_inscripciones ai on ai.id_curso = cu.id_curso inner join personas p on p.id_persona = ai.id_alumno where p.id_usuario = @id", sqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = u.ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision != null)
                {
                    comisiones = new List<Comision>();
                    while (drComision.Read())
                    {
                        Comision comi = new Comision();
                        comi.ID = (int)drComision["id_comision"];
                        comi.DescComision = (string)drComision["desc_comision"];
                        comi.AnioEspecialidad = (int)drComision["anio_especialidad"];
                        comi.IDPlan = (int)drComision["id_plan"];

                        comisiones.Add(comi);
                    }
                }
                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de Comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }

        public List<Comision> GetAllMateriasCom(Materia mat)
        {
            List<Comision> comisiones = null;
            try
            {
                this.OpenConnection();
                // SqlCommand cmdComision = new SqlCommand("drop table if exists #comiConUltimoAño; select m.id_materia, com.desc_comision, com.id_plan, com.id_comision, MAX(anio_calendario) ultimoAño into #comiConUltimoAño from comisiones com inner join cursos c on c.id_comision = com.id_comision inner join materias m on m.id_materia = c.id_materia group by   m.id_materia, com.id_comision, com.desc_comision, com.id_plan; select  ultComi.id_comision, c.id_materia, ultComi.desc_comision, ultComi.id_plan, ultComi.ultimoAño, c.id_curso, c.cupo from cursos c inner join #comiConUltimoAño ultComi on ultComi.id_materia = c.id_materia and ultComi.id_comision = c.id_comision and c.anio_calendario = ultComi.ultimoAño where ultComi.id_materia = @id_materia; drop table if exists #comiConUltimoAño", sqlConn);
                SqlCommand cmdComision = new SqlCommand("select com.id_comision, m.id_materia, com.desc_comision, com.id_plan, com.anio_especialidad, c.cupo from comisiones com inner join cursos c on c.id_comision = com.id_comision inner join materias m on m.id_materia = c.id_materia where m.id_materia = @id_materia", sqlConn);
                cmdComision.Parameters.Add("@id_materia", SqlDbType.Int).Value = mat.ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision != null)
                {
                    comisiones = new List<Comision>(); 
                    while (drComision.Read())
                    {
                        Comision comi = new Comision();
                        comi.ID = (int)drComision["id_comision"];
                        comi.DescComision = (string)drComision["desc_comision"];
                        comi.AnioEspecialidad = (int)drComision["anio_especialidad"];
                        comi.IDPlan = (int)drComision["id_plan"];

                        comisiones.Add(comi);
                    }
                }
                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de Comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }

        public Comision GetOne(Comision com)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id", sqlConn);
                cmdComisiones.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;
                SqlDataReader drComision = cmdComisiones.ExecuteReader();
                if (drComision != null)
                {
                    drComision.Read();
                    com.DescComision = (string)drComision["desc_comision"];
                    com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    com.IDPlan = (int)drComision["id_plan"];
                }
                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return com;
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la comision", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Insert(Comision comision)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones (desc_comision,anio_especialidad,id_plan) values(@desc_comision,@anio_especialidad,@id_plan)", sqlConn);
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear la comision", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(Comision comision)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE comisiones SET desc_comision = @desc_comision, anio_especialidad = @anio_especialidad, id_plan = @id_plan WHERE id_comision = @id", sqlConn);                
                cmdUpd.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdUpd.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdUpd.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                cmdUpd.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;

                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la comision", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision.ID);
            }

            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
