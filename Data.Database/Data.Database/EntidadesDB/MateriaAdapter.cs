using System;
using System.Collections.Generic;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public MateriaAdapter() { }
        public List<Materia> GetAll()
        {
            List<Materia> materias = null;
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias", sqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                if (drMaterias != null)
                {
                    materias = new List<Materia>();
                    while (drMaterias.Read())
                    {
                        Materia mat = new Materia();

                        mat.ID = (int)drMaterias["id_materia"];
                        mat.Descripcion = (string)drMaterias["desc_materia"];
                        mat.HSSSemanales = (int)drMaterias["hs_semanales"];
                        mat.HSTotales = (int)drMaterias["hs_totales"];
                        mat.IDPlan = (int)drMaterias["id_plan"];

                        materias.Add(mat);
                    }
                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public List<Materia> GetAllByAlumno(Usuario us)
        {
            List<Materia> materias = null;
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select m.* from materias m  inner join cursos cu on cu.id_materia = m.id_materia inner join alumnos_inscripciones ai on ai.id_curso = cu.id_curso  inner join personas p on p.id_persona = ai.id_alumno  where p.id_usuario = @id", sqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = us.ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                if (drMaterias != null)
                {
                    materias = new List<Materia>();
                    while (drMaterias.Read())
                    {
                        Materia mat = new Materia();

                        mat.ID = (int)drMaterias["id_materia"];
                        mat.Descripcion = (string)drMaterias["desc_materia"];
                        mat.HSSSemanales = (int)drMaterias["hs_semanales"];
                        mat.HSTotales = (int)drMaterias["hs_totales"];
                        mat.IDPlan = (int)drMaterias["id_plan"];

                        materias.Add(mat);
                    }
                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public Materia GetOne(Materia mat)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias WHERE id_materia = @id", sqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = mat.ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                if (drMaterias != null)
                {
                    drMaterias.Read();
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HSSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return mat;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE materias WHERE id_materia = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la materia", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert(Materia materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO materias (desc_materia,hs_semanales,hs_totales,id_plan)" +
                    "values(@desc_materia,@hs_semanales,@hs_totales,@id_plan)", sqlConn);

                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear materia", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Materia materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE materias SET desc_materia = @desc_materia, hs_semanales = @hs_semanales, hs_totales = @hs_totales, id_plan = @id_plan WHERE id_materia = @id ", sqlConn);

                cmdUpd.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdUpd.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdUpd.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSSemanales;
                cmdUpd.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdUpd.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;

                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                Delete(materia.ID);
            }

            else if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
