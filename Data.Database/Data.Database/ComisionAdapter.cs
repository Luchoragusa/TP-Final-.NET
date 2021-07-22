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
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdComision = new SqlCommand("SELECT * FROM comisiones", sqlConn);

                SqlDataReader drComision = cmdComision.ExecuteReader();

                while (drComision.Read())
                {
                    Comision com = new Comision();

                    com.ID = (int)drComision["id_comision"];
                    com.DescComision = (string)drComision["desc_comision"];
                    com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    com.IDPlan = (int)drComision["id_plan"];

                    comisiones.Add(com);
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

        public Business.Entities.Comision GetOne(int ID)
        {
            Comision com = new Comision();
            try
            {
                OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id", sqlConn);
                cmdComisiones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComision = cmdComisiones.ExecuteReader();
                while (drComision.Read())
                {
                    com.ID = (int)drComision["id_comision"];
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
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones (desc_comision,anio_especialidad,id_plan)" +
                    "values(@desc_comision,@anio_especialidad,@id_plan)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;

                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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
                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET desc_comision = @desc_comision, anio_especialidad = @anio_especialdiad, " +
                    "id_plan = @id_plan" +
                    "WHERE id_comision = @id ", sqlConn);

                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                cmdSave.ExecuteNonQuery();
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
