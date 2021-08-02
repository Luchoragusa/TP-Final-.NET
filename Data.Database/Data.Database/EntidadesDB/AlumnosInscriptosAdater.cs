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
    public class AlumnosIncriptosAdapter : Adapter
    {
        public AlumnosIncriptosAdapter() { }

        public List<Alumnos_Inscripciones> GetAll()
        {
            List<Alumnos_Inscripciones> Alumnos_Inscripcioneses = new List<Alumnos_Inscripciones>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("SELECT * FROM alumnos_inscripciones", sqlConn);

                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();

                while (drAlumnos_Inscripcioneses.Read())
                {
                    Alumnos_Inscripciones Alumnos_Inscripciones = new Alumnos_Inscripciones();

                    Alumnos_Inscripciones.ID = (int)drAlumnos_Inscripcioneses["id_inscripcion"];
                    Alumnos_Inscripciones.IDAlumno = (int)drAlumnos_Inscripcioneses["id_alumno"];
                    Alumnos_Inscripciones.IDCurso = (int)drAlumnos_Inscripcioneses["id_curso"];
                    Alumnos_Inscripciones.Condicion = (string)drAlumnos_Inscripcioneses["condicion"];
                    Alumnos_Inscripciones.Nota = (int)drAlumnos_Inscripcioneses["nota"];

                    Alumnos_Inscripcioneses.Add(Alumnos_Inscripciones);
                }
                drAlumnos_Inscripcioneses.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de alumnos inscriptos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return Alumnos_Inscripcioneses;
        }

        public Alumnos_Inscripciones GetOne(int ID)
        {
            Alumnos_Inscripciones Alumnos_Inscripciones = new Alumnos_Inscripciones();
            try
            {
                OpenConnection();
                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("SELECT * FROM alumnos_inscripciones WHERE id_inscripcion = @id", sqlConn);
                cmdAlumnos_Inscripcioneses.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();
                while (drAlumnos_Inscripcioneses.Read())
                {
                    Alumnos_Inscripciones.ID = (int)drAlumnos_Inscripcioneses["id_inscripcion"];
                    Alumnos_Inscripciones.IDAlumno = (int)drAlumnos_Inscripcioneses["id_alumno"];
                    Alumnos_Inscripciones.IDCurso = (int)drAlumnos_Inscripcioneses["id_curso"];
                    Alumnos_Inscripciones.Condicion = (string)drAlumnos_Inscripcioneses["condicion"];
                    Alumnos_Inscripciones.Nota = (int)drAlumnos_Inscripcioneses["nota"];
                }
                drAlumnos_Inscripcioneses.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del alumno inscripto", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return Alumnos_Inscripciones;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la inscripcion del alumno.", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert(Alumnos_Inscripciones Alumnos_Inscripciones)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_alumno,id_curso,condicion,nota) values(@id_alumno,@id_curso,@condicion,@nota) select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_alumno", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Nota;

                Alumnos_Inscripciones.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear la inscripcion del alumno", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Alumnos_Inscripciones Alumnos_Inscripciones)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, id_curso = @id_curso, condicion = @condicion, nota = @nota WHERE id_inscripcion = @id ", sqlConn);

                cmdUpd.Parameters.Add("@id_alumno", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.IDAlumno;
                cmdUpd.Parameters.Add("@id_curso", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.IDCurso;
                cmdUpd.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Condicion;
                cmdUpd.Parameters.Add("@nota", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Nota;

                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la inscripcion del alumno.", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Alumnos_Inscripciones Alumnos_Inscripciones)
        {
            if (Alumnos_Inscripciones.State == BusinessEntity.States.Deleted)
            {
                Delete(Alumnos_Inscripciones.ID);
            }

            else if (Alumnos_Inscripciones.State == BusinessEntity.States.New)
            {
                this.Insert(Alumnos_Inscripciones);
            }
            else if (Alumnos_Inscripciones.State == BusinessEntity.States.Modified)
            {
                Update(Alumnos_Inscripciones);
            }
            Alumnos_Inscripciones.State = BusinessEntity.States.Unmodified;
        }

    }
}
