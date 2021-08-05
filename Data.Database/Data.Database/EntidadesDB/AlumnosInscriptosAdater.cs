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


                    if (string.IsNullOrEmpty(drAlumnos_Inscripcioneses["nota"].ToString())) // verifico si la nota es null
                        Alumnos_Inscripciones.Nota = " - ";
                    else
                        Alumnos_Inscripciones.Nota = (string)drAlumnos_Inscripcioneses["nota"].ToString();

                    Alumnos_Inscripcioneses.Add(Alumnos_Inscripciones);
                }
                drAlumnos_Inscripcioneses.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de alumnos inscriptos");
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

                    if (string.IsNullOrEmpty(drAlumnos_Inscripcioneses["nota"].ToString())) // verifico si la nota es null
                        Alumnos_Inscripciones.Nota = " - ";
                    else
                        Alumnos_Inscripciones.Nota = (string)drAlumnos_Inscripcioneses["nota"].ToString();
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
                SqlCommand cmdSave = null;
                if (!string.IsNullOrEmpty(Alumnos_Inscripciones.Nota)) // verifico si la nota quq carga el usuario es null
                {
                    cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_alumno,id_curso,condicion,nota) values(@id_alumno, @id_curso, @condicion, @nota) select @@identity ", sqlConn);
                    cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = int.Parse(Alumnos_Inscripciones.Nota);
                }
                else
                    cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_alumno,id_curso,condicion) values(@id_alumno, @id_curso, @condicion) select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = Alumnos_Inscripciones.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = Alumnos_Inscripciones.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Condicion;


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
                SqlCommand cmdUpd = null;
                Nullable<int> nota = null;
                nota = int.Parse(Alumnos_Inscripciones.Nota);

                if (nota.HasValue) // verifico si la nota que carga el usuario no es null
                {
                    cmdUpd = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, id_curso = @id_curso, condicion = @condicion, nota = @nota WHERE id_inscripcion = @id ", sqlConn);
                    cmdUpd.Parameters.Add("@nota", SqlDbType.Int).Value = int.Parse(Alumnos_Inscripciones.Nota);
                }
                else
                    cmdUpd = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, id_curso = @id_curso, condicion = @condicion WHERE id_inscripcion = @id ", sqlConn);

                cmdUpd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = Alumnos_Inscripciones.IDAlumno;
                cmdUpd.Parameters.Add("@id_curso", SqlDbType.Int).Value = Alumnos_Inscripciones.IDCurso;
                cmdUpd.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Condicion;

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
