using System;
using System.Collections.Generic;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter planData;

        public PlanLogic()
        {
            planData = new PlanAdapter();
        }
        public PlanAdapter PlanData
        {
            get { return planData; }
            set { planData = value; }
        }
        
        
        public Plan GetOne(Plan plan)
        {
            try
            {
                return PlanData.GetOne(plan);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el plan.", ex);
                throw ExcepcionManejada;
            }
        }
        public List<Plan> GetAll()
        {
            try
            {
                return PlanData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de planes.", ex);
                throw ExcepcionManejada;
            }
        }
        public void Save(Plan plan)
        {
            try
            {
                PlanData.Save(plan);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar el plan.", ex);
                throw ExcepcionManejada;
            }
        }
        public void Delete(int id)
        {
            try
            {
                PlanData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el plan.", ex);
                throw ExcepcionManejada;
            }
        }
    
        public void Insert(Plan plan)
        {
            try
            {
                PlanData.Insert(plan);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar un plan.", ex);
                throw ExcepcionManejada;
            }
        }
    
        public void Update(Plan plan)
        {
            try
            {
                PlanData.Insert(plan);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar un plan.", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
