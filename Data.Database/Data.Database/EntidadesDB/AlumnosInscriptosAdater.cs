﻿using System;
using System.Collections.Generic;
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
            List<Alumnos_Inscripciones> Alumnos_Inscripciones = null;
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, ai.nota, p.nombre, p.apellido, p.legajo from cursos inner join alumnos_inscripciones ai on cursos.id_curso = ai.id_curso inner join personas p on ai.id_alumno = p.id_persona where p.tipo_persona = 1", sqlConn);
                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();
                if (drAlumnos_Inscripcioneses != null)
                {
                    Alumnos_Inscripciones = new List<Alumnos_Inscripciones>();
                    while (drAlumnos_Inscripcioneses.Read())
                    {
                        Alumnos_Inscripciones Alumnos_I = new Alumnos_Inscripciones();
                        Personas p = new Personas();
                        p.Nombre = (string)drAlumnos_Inscripcioneses["nombre"];
                        p.Apellido = (string)drAlumnos_Inscripcioneses["apellido"];
                        p.Legajo = (int)drAlumnos_Inscripcioneses["legajo"];

                        Alumnos_I.Personas = p;
                        Alumnos_I.ID = (int)drAlumnos_Inscripcioneses["id_inscripcion"];
                        Alumnos_I.IDAlumno = (int)drAlumnos_Inscripcioneses["id_alumno"];
                        Alumnos_I.IDCurso = (int)drAlumnos_Inscripcioneses["id_curso"];
                        Alumnos_I.Condicion = (string)drAlumnos_Inscripcioneses["condicion"];

                        if (string.IsNullOrEmpty(drAlumnos_Inscripcioneses["nota"].ToString()))
                            Alumnos_I.Nota = " - ";
                        else
                            Alumnos_I.Nota = (string)drAlumnos_Inscripcioneses["nota"].ToString();

                        Alumnos_Inscripciones.Add(Alumnos_I);
                    }
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
            return Alumnos_Inscripciones;
        }

        public Alumnos_Inscripciones ValidarInscripcion(Materia materia, Usuario alumno)
        {
            Alumnos_Inscripciones alu = null;
            try
            {
                OpenConnection();
                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("select m.* from alumnos_inscripciones ai inner join cursos c on c.id_curso = ai.id_curso inner join materias m on m.id_materia  = c.id_materia inner join personas p on ai.id_alumno = p.id_persona inner join usuarios u on p.id_usuario = u.id_usuario where u.id_usuario=@idUsuario and m.id_materia = @idMat and c.anio_calendario = 2021", sqlConn);
                cmdAlumnos_Inscripcioneses.Parameters.Add("@idMat", SqlDbType.Int).Value = materia.ID;
                cmdAlumnos_Inscripcioneses.Parameters.Add("@idUsuario", SqlDbType.Int).Value = alumno.ID;

                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();

                if (drAlumnos_Inscripcioneses.Read())
                {
                    alu = new Alumnos_Inscripciones();
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
            return alu;
        }

        public List<Alumnos_Inscripciones> GetAllByAlumno(Usuario u)
        {
            List<Alumnos_Inscripciones> inscripciones = null;
            try
            {
                this.OpenConnection();

                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("select * from alumnos_inscripciones ai inner join personas p on ai.id_alumno = p.id_persona inner join usuarios u on p.id_usuario = u.id_usuario where u.id_usuario = @idUsuario", sqlConn);
                cmdAlumnos_Inscripcioneses.Parameters.Add("@idUsuario", SqlDbType.Int).Value = u.ID;
                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();
                if (drAlumnos_Inscripcioneses != null)
                {
                    inscripciones = new List<Alumnos_Inscripciones>();

                    while (drAlumnos_Inscripcioneses.Read())
                    {
                        Alumnos_Inscripciones Alumno_Inscripcion = new Alumnos_Inscripciones();
                        Personas p = new Personas();
                        p.Nombre = (string)drAlumnos_Inscripcioneses["nombre"];
                        p.Apellido = (string)drAlumnos_Inscripcioneses["apellido"];
                        p.Legajo = (int)drAlumnos_Inscripcioneses["legajo"];

                        Alumno_Inscripcion.Personas = p;
                        Alumno_Inscripcion.ID = (int)drAlumnos_Inscripcioneses["id_inscripcion"];
                        Alumno_Inscripcion.IDAlumno = (int)drAlumnos_Inscripcioneses["id_alumno"];
                        Alumno_Inscripcion.IDCurso = (int)drAlumnos_Inscripcioneses["id_curso"];
                        Alumno_Inscripcion.Condicion = (string)drAlumnos_Inscripcioneses["condicion"];

                        if (string.IsNullOrEmpty(drAlumnos_Inscripcioneses["nota"].ToString()))
                            Alumno_Inscripcion.Nota = " - ";
                        else
                            Alumno_Inscripcion.Nota = (string)drAlumnos_Inscripcioneses["nota"].ToString();

                        inscripciones.Add(Alumno_Inscripcion);
                    }
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
            return inscripciones;
        }
        public List<Alumnos_Inscripciones> GetAllByCurso(Curso cur)
        {
            List<Alumnos_Inscripciones> AlumnosDeUnCurso = null;
            try
            {
                this.OpenConnection();

                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, ai.nota,p.nombre, p.apellido, p.legajo  from cursos inner join alumnos_inscripciones ai on cursos.id_curso = ai.id_curso inner join personas p on ai.id_alumno = p.id_persona where cursos.id_curso = @idCurso and tipo_persona = 1", sqlConn);
                cmdAlumnos_Inscripcioneses.Parameters.Add("@idCurso", SqlDbType.Int).Value = cur.ID;
                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();
                if (drAlumnos_Inscripcioneses != null)
                {
                    AlumnosDeUnCurso = new List<Alumnos_Inscripciones>();
                    while (drAlumnos_Inscripcioneses.Read())
                    {
                        Alumnos_Inscripciones Alumnos_Inscripciones = new Alumnos_Inscripciones();
                        Personas p = new Personas();
                        p.Nombre = (string)drAlumnos_Inscripcioneses["nombre"];
                        p.Apellido = (string)drAlumnos_Inscripcioneses["apellido"];
                        p.Legajo = (int)drAlumnos_Inscripcioneses["legajo"];

                        Alumnos_Inscripciones.Personas = p;
                        Alumnos_Inscripciones.ID = (int)drAlumnos_Inscripcioneses["id_inscripcion"];
                        Alumnos_Inscripciones.IDAlumno = (int)drAlumnos_Inscripcioneses["id_alumno"];
                        Alumnos_Inscripciones.IDCurso = (int)drAlumnos_Inscripcioneses["id_curso"];
                        Alumnos_Inscripciones.Condicion = (string)drAlumnos_Inscripcioneses["condicion"];

                        if (string.IsNullOrEmpty(drAlumnos_Inscripcioneses["nota"].ToString())) // verifico si la nota es null
                            Alumnos_Inscripciones.Nota = " - ";
                        else
                            Alumnos_Inscripciones.Nota = (string)drAlumnos_Inscripcioneses["nota"].ToString();

                        AlumnosDeUnCurso.Add(Alumnos_Inscripciones);
                    }
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
            return AlumnosDeUnCurso;
        }

        public Alumnos_Inscripciones GetOne(Alumnos_Inscripciones alu)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdAlumnos_Inscripcioneses = new SqlCommand("SELECT p.nombre, p.apellido, p.legajo, ai.condicion, ai.nota FROM alumnos_inscripciones ai inner join personas p on ai.id_alumno = p.id_persona WHERE id_inscripcion = @id; ", sqlConn);
                cmdAlumnos_Inscripcioneses.Parameters.Add("@id", SqlDbType.Int).Value = alu.ID;

                SqlDataReader drAlumnos_Inscripcioneses = cmdAlumnos_Inscripcioneses.ExecuteReader();
                while (drAlumnos_Inscripcioneses.Read())
                {
                    alu.Condicion = (string)drAlumnos_Inscripcioneses["condicion"];

                    if (string.IsNullOrEmpty(drAlumnos_Inscripcioneses["nota"].ToString())) // verifico si la nota es null
                        alu.Nota = " - ";
                    else
                        alu.Nota = (string)drAlumnos_Inscripcioneses["nota"].ToString();

                    Personas p = new Personas();
                    p.Nombre = (string)drAlumnos_Inscripcioneses["nombre"];
                    p.Apellido = (string)drAlumnos_Inscripcioneses["apellido"];
                    p.Legajo = (int)drAlumnos_Inscripcioneses["legajo"];

                    alu.Personas = p;
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
            return alu;
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
                
                cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_alumno,id_curso,condicion) values(@id_alumno, @id_curso, @condicion)", sqlConn);

                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = Alumnos_Inscripciones.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = Alumnos_Inscripciones.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = Alumnos_Inscripciones.Condicion;

                cmdSave.ExecuteNonQuery();
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

                if (Alumnos_Inscripciones.Nota != " - ") // verifico si la nota quq carga el usuario es null
                {
                    cmdUpd = new SqlCommand("UPDATE ai SET condicion = @condicion, nota = @nota from alumnos_inscripciones ai inner join personas p on ai.id_alumno = p.id_persona WHERE p.legajo = @legajo", sqlConn);
                   cmdUpd.Parameters.Add("@nota", SqlDbType.Int).Value = int.Parse(Alumnos_Inscripciones.Nota);
                }
                else
                    cmdUpd = new SqlCommand("UPDATE ai SET condicion = @condicion from alumnos_inscripciones ai inner join personas p on ai.id_alumno = p.id_persona WHERE p.legajo = @legajo ", sqlConn);
                cmdUpd.Parameters.Add("@legajo", SqlDbType.Int).Value = Alumnos_Inscripciones.legajoPersona;
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
