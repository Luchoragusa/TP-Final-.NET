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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadActual = new Business.Entities.Especialidad();
        }
        private Business.Entities.Especialidad _especialidad;
        public Business.Entities.Especialidad EspecialidadActual
        {
            get
            { return _especialidad; }
            set
            { _especialidad = value; }
        }
        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic espl = new EspecialidadLogic();
            try
            {
                EspecialidadActual = new Business.Entities.Especialidad();
                _especialidad.ID = ID;
                EspecialidadActual = espl.GetOne(EspecialidadActual);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtIDEsp.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescEsp.Text = this.EspecialidadActual.DescEspecialidad;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
            else if (Modo == ModoForm.Baja)
            {
                this.btnModo.Text = "Eliminar";

                this.txtIDEsp.Enabled = false;
                this.txtDescEsp.Enabled = false;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                EspecialidadActual = new Business.Entities.Especialidad();
                EspecialidadActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    EspecialidadActual.State = BusinessEntity.States.Modified;
                    //this.txtIDEsp.Text = this.EspecialidadActual.ID.ToString();             preguntar
                }
                this.EspecialidadActual.DescEspecialidad = this.txtDescEsp.Text;
               
            }

            if (this.Modo == ModoForm.Baja) EspecialidadActual.State = BusinessEntity.States.Deleted;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic EspecialidadLogic = new EspecialidadLogic();
            try
            {
                EspecialidadLogic.Save(EspecialidadActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override bool Validar()
        {
            if (txtDescEsp.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Validaciones.validarTexto(txtDescEsp.Text))
            {
                Notificar("Descripcion incorrecta.", "Intente nuevamente",
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
