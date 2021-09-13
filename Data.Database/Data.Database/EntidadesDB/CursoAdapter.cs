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
    public class CursoAdapter : Adapter
    {
        public CursoAdapter() { }

        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdcursos = new SqlCommand("SELECT * FROM cursos", sqlConn);

                SqlDataReader drcursos = cmdcursos.ExecuteReader();

                while (drcursos.Read())
                {
                    Curso Curso = new Curso();

                    Curso.ID = (int)drcursos["id_Curso"];
                    Curso.IDMateria = (int)drcursos["id_materia"];
                    Curso.IDComision = (int)drcursos["id_comision"];
                    Curso.AnioCalendario = (int)drcursos["anio_calendario"];
                    Curso.Cupo = (int)drcursos["cupo"];

                    cursos.Add(Curso);
                }
                drcursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }


        public List<Curso> GetAllByDocente(Usuario docente)
        {
            List<Curso> cursosDelDocente = new List<Curso>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdcursos = new SqlCommand("select c.id_curso from usuarios us inner join personas per on us.id_persona = per.id_persona inner join docentes_cursos doc on doc.id_docente = per.id_persona inner join cursos c on c.id_curso = doc.id_curso where nombre_usuario = ? and clave = ?", sqlConn);
                cmdcursos.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = docente.NombreUsuario;
                cmdcursos.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = docente.Clave;
                SqlDataReader drcursos = cmdcursos.ExecuteReader();

                while (drcursos.Read())
                {
                    Curso Curso = new Curso();

                    Curso.ID = (int)drcursos["id_Curso"];
                    Curso.IDMateria = (int)drcursos["id_materia"];
                    Curso.IDComision = (int)drcursos["id_comision"];
                    Curso.AnioCalendario = (int)drcursos["anio_calendario"];
                    Curso.Cupo = (int)drcursos["cupo"];

                    cursosDelDocente.Add(Curso);
                }
                drcursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursosDelDocente;
        }

        public Curso GetOne(int ID)
        {
            Curso Curso = new Curso();
            try
            {
                OpenConnection();
                SqlCommand cmdcursos = new SqlCommand("SELECT * FROM cursos WHERE id_curso = @id", sqlConn);
                cmdcursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drcursos = cmdcursos.ExecuteReader();
                while (drcursos.Read())
                {
                    Curso.ID = (int)drcursos["id_Curso"];
                    Curso.IDMateria = (int)drcursos["id_materia"];
                    Curso.IDComision = (int)drcursos["id_comision"];
                    Curso.AnioCalendario = (int)drcursos["anio_calendario"];
                    Curso.Cupo = (int)drcursos["cupo"];
                }
                drcursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del Curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return Curso;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar Curso", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert(Curso Curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO cursos (id_materia, id_comision, anio_calendario, cupo values(@desc_Curso,@id_especialidad) select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = Curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = Curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = Curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = Curso.Cupo;

                Curso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear Curso", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Curso Curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE cursos SET id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo WHERE id_Curso = @id ", sqlConn);

                cmdUpd.Parameters.Add("@id_comision", SqlDbType.Int).Value = Curso.IDComision;
                cmdUpd.Parameters.Add("@id_materia", SqlDbType.Int).Value = Curso.IDMateria;
                cmdUpd.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = Curso.AnioCalendario;
                cmdUpd.Parameters.Add("@cupo", SqlDbType.Int).Value = Curso.Cupo;

                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del Curso", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Curso Curso)
        {
            if (Curso.State == BusinessEntity.States.Deleted)
            {
                Delete(Curso.ID);
            }

            else if (Curso.State == BusinessEntity.States.New)
            {
                this.Insert(Curso);
            }
            else if (Curso.State == BusinessEntity.States.Modified)
            {
                Update(Curso);
            }
            Curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
