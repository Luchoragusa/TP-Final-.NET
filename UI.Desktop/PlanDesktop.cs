using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PlanDesktop : UI.Desktop.ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            PlanActual = new Business.Entities.Plan();
        }

        private Business.Entities.Plan _plan;
        public Business.Entities.Plan PlanActual { get; set; }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            Business.Logic.PlanLogic pl = new Business.Logic.PlanLogic();
            try
            {
                PlanActual = pl.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
  
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDesc.Text = this.PlanActual.Descripcion;
            this.txtIDEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();

            if (Modo == ModoForm.Consulta) this.btnModo.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnModo.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                PlanActual = new Business.Entities.Plan();
                PlanActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    PlanActual.State = BusinessEntity.States.Modified;
                    this.txtID.Text = this.PlanActual.ID.ToString();
                }
                this.PlanActual.Descripcion = this.txtDesc.Text;
                this.PlanActual.IDEspecialidad = Convert.ToInt32(this.txtIDEspecialidad.Text);
            }

            if (this.Modo == ModoForm.Baja) PlanActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) PlanActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic planLogic = new PlanLogic();
            try
            {
                planLogic.Save(PlanActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public override bool Validar()
        {
            if (txtDesc.Text.Equals(String.Empty) || txtIDEspecialidad.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarTexto(txtDesc.Text))
            {
                Notificar("Descripcion incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Validaciones.validarTexto(txtIDEspecialidad.Text))    //quitamos el "!", siguiendo logica de UsuarioDesktop 
            {
                Notificar("ID incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnModo_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
