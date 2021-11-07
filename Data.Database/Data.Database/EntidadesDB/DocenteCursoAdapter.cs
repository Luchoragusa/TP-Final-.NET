using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities.Entidades;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database.EntidadesDB
{
    public class DocenteCursoAdapter : Adapter
    {
        public DocenteCursoAdapter() { }

        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> DocenteCursoes = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdDocenteCursoes = new SqlCommand("SELECT * FROM docentes_cursos", sqlConn);

                SqlDataReader drDocenteCursos = cmdDocenteCursoes.ExecuteReader();
                if (drDocenteCursos != null)
                {
                    while (drDocenteCursos.Read())
                    {
                        DocenteCurso DocenteCurso = new DocenteCurso();
                        DocenteCurso.ID = (int)drDocenteCursos["id_dictado"];
                        DocenteCurso.IDCurso = (int)drDocenteCursos["id_curso"];
                        DocenteCurso.IDDocente = (int)drDocenteCursos["id_docente"];
                        DocenteCurso.Cargo = (DocenteCurso.TipoCargos)drDocenteCursos["cargo"];

                        DocenteCursoes.Add(DocenteCurso);
                    }
                }
                drDocenteCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de Docente cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return DocenteCursoes;
        }

        public List<Materia> GetAllMateriaslDelDocente(Usuario docente)
        {
            List<Materia> materiasDelDocente = new List<Materia>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdmateriasDocente = new SqlCommand("select mat.id_materia, mat.desc_materia, mat.hs_semanales, mat.hs_totales, mat.id_plan  from materias mat  inner join cursos c 	on c.id_materia = mat.id_materia  inner join docentes_cursos doc 	on doc.id_curso = c.id_curso  inner join comisiones com  	on com.id_comision = c.id_comision  inner join personas p  	on p.id_persona = doc.id_docente  inner join usuarios u  on u.id_usuario = p.id_usuario where u.nombre_usuario = @nombre_usuario and u.clave =@clave", sqlConn);

                cmdmateriasDocente.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = docente.NombreUsuario;
                cmdmateriasDocente.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = docente.Clave;

                SqlDataReader drMateriasDocente = cmdmateriasDocente.ExecuteReader();

                while (drMateriasDocente.Read())
                {
                    Materia mat = new Materia();

                    mat.ID = (int)drMateriasDocente["id_materia"];
                    mat.Descripcion = (string)drMateriasDocente["desc_materia"];
                    mat.HSSSemanales = (int)drMateriasDocente["hs_semanales"];
                    mat.HSTotales = (int)drMateriasDocente["hs_totales"];
                    mat.IDPlan = (int)drMateriasDocente["id_plan"];

                    materiasDelDocente.Add(mat);
                }
                drMateriasDocente.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return materiasDelDocente;
        }

        public List<Comision> GetAllComisionesDeLasMateriaslDelDocente(Usuario docente, Materia materia)
        {
            List<Comision> materiasDelDocente = new List<Comision>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdComisionesDeLasMaterias = new SqlCommand("select com.id_comision, com.desc_comision, com.anio_especialidad, com.id_plan from materias mat  inner join cursos c on c.id_materia = mat.id_materia  inner join docentes_cursos doc on doc.id_curso = c.id_curso inner join comisiones com on com.id_comision = c.id_comision  inner join personas p on p.id_persona = doc.id_docente  inner join usuarios u on u.id_usuario = p.id_usuario  where u.nombre_usuario = @nombre_usuario and u.clave = @clave and mat.id_materia = @idmat", sqlConn);

                cmdComisionesDeLasMaterias.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = docente.NombreUsuario;
                cmdComisionesDeLasMaterias.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = docente.Clave;
                cmdComisionesDeLasMaterias.Parameters.Add("@idmat", SqlDbType.Int).Value = materia.ID;

                SqlDataReader drComisionesDeLasMaterias = cmdComisionesDeLasMaterias.ExecuteReader();

                if (drComisionesDeLasMaterias != null)
                {
                    while (drComisionesDeLasMaterias.Read())
                    {
                        Comision com = new Comision();

                        com.ID = (int)drComisionesDeLasMaterias["id_comision"];
                        com.DescComision = (string)drComisionesDeLasMaterias["desc_comision"];
                        com.AnioEspecialidad = (int)drComisionesDeLasMaterias["anio_especialidad"];
                        com.IDPlan = (int)drComisionesDeLasMaterias["id_plan"];

                        materiasDelDocente.Add(com);
                    }
                }                    
                drComisionesDeLasMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return materiasDelDocente;
        }

        public List<Curso> GetAllCursosDeLaComision(Usuario docente, Materia materia, Comision comision)
        {
            List<Curso> cursosDelDocente = new List<Curso>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdCursosDeLaComision = new SqlCommand("select c.id_curso, c.id_comision, c.id_materia, c.anio_calendario, c.cupo from materias mat inner join cursos c on c.id_materia = mat.id_materia inner join docentes_cursos doc on doc.id_curso = c.id_curso inner join comisiones com on com.id_comision = c.id_comision inner join personas p on p.id_persona = doc.id_docente inner join usuarios u on u.id_usuario = p.id_usuario where u.nombre_usuario = @nombre_usuario and u.clave = @clave and mat.id_materia = @idmat and com.id_comision = @idcom", sqlConn);

                cmdCursosDeLaComision.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = docente.NombreUsuario;
                cmdCursosDeLaComision.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = docente.Clave;
                cmdCursosDeLaComision.Parameters.Add("@idmat", SqlDbType.Int).Value = materia.ID;
                cmdCursosDeLaComision.Parameters.Add("@idcom", SqlDbType.Int).Value = comision.ID;

                SqlDataReader drCursosDeLaComision = cmdCursosDeLaComision.ExecuteReader();

                if (drCursosDeLaComision != null)
                {
                    while (drCursosDeLaComision.Read())
                    {
                        Curso curso = new Curso();

                        curso.ID = (int)drCursosDeLaComision["id_curso"];
                        curso.IDComision = (int)drCursosDeLaComision["id_comision"];
                        curso.IDMateria = (int)drCursosDeLaComision["id_materia"];
                        curso.AnioCalendario = (int)drCursosDeLaComision["anio_calendario"];
                        curso.Cupo = (int)drCursosDeLaComision["cupo"];

                        cursosDelDocente.Add(curso);
                    }
                }
                drCursosDeLaComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return cursosDelDocente;
        }

        public DocenteCurso GetOne(DocenteCurso DocenteCurso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDocenteCursos = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_dictado = @id", sqlConn);
                cmdDocenteCursos.Parameters.Add("@id", SqlDbType.Int).Value = DocenteCurso.ID;
                SqlDataReader drDocenteCursos = cmdDocenteCursos.ExecuteReader();
                if (drDocenteCursos != null)
                {

                    while (drDocenteCursos.Read())
                    {
                        DocenteCurso.ID = (int)drDocenteCursos["id_dictado"];
                        DocenteCurso.IDCurso = (int)drDocenteCursos["id_curso"];
                        DocenteCurso.IDDocente = (int)drDocenteCursos["id_docente"];
                        int cargo = (int)drDocenteCursos["cargo"];

                        if (cargo == (int)DocenteCurso.TipoCargos.Titular)
                            DocenteCurso.Cargo = DocenteCurso.TipoCargos.Titular;

                        else if (cargo == (int)DocenteCurso.TipoCargos.Auxiliar)
                            DocenteCurso.Cargo = DocenteCurso.TipoCargos.Auxiliar;

                        else if (cargo == (int)DocenteCurso.TipoCargos.JefeCatedra)
                            DocenteCurso.Cargo = DocenteCurso.TipoCargos.JefeCatedra;
                    }
                    
                    drDocenteCursos.Read();
                    DocenteCurso.IDCurso = (int)drDocenteCursos["id_curso"];
                    DocenteCurso.IDDocente = (int)drDocenteCursos["id_docente"];
                    DocenteCurso.Cargo = (DocenteCurso.TipoCargos)drDocenteCursos["cargo"];

                }
                drDocenteCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del DocenteCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return DocenteCurso;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar el docente del curso", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert(DocenteCurso DocenteCurso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO docentes_cursos (id_dictado,id_curso, id_docente, cargo) values(@id_dictado,@id_curso,@id_docente,@cargo) select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.VarChar, 50).Value = DocenteCurso.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.VarChar, 50).Value = DocenteCurso.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = DocenteCurso.Cargo;

                DocenteCurso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear el docente del curso", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(DocenteCurso DocenteCurso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE docentes_cursos SET id_curso = @id_curso, id_docente = @id_docente, cargo = @cargo HERE id_dictado = @id ", sqlConn);

                cmdUpd.Parameters.Add("@id_curso", SqlDbType.VarChar, 50).Value = DocenteCurso.IDCurso;
                cmdUpd.Parameters.Add("@id_docente", SqlDbType.VarChar, 50).Value = DocenteCurso.IDDocente;
                cmdUpd.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = DocenteCurso.Cargo;

                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del docente del curso", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(DocenteCurso DocenteCurso)
        {
            if (DocenteCurso.State == BusinessEntity.States.Deleted)
            {
                Delete(DocenteCurso.ID);
            }

            else if (DocenteCurso.State == BusinessEntity.States.New)
            {
                this.Insert(DocenteCurso);
            }
            else if (DocenteCurso.State == BusinessEntity.States.Modified)
            {
                Update(DocenteCurso);
            }
            DocenteCurso.State = BusinessEntity.States.Unmodified;
        }
    }
}
