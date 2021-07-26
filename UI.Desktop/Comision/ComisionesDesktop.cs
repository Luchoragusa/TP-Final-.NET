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
    public partial class ComisionesDesktop : UI.Desktop.ApplicationForm
    {
        public ComisionesDesktop()
        {
            InitializeComponent();
        }

        public ComisionesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            MapearDeDatos();
        }

        private Business.Entities.Comision _Comision;

        public Business.Entities.Comision ComisionActual
        {
            get
            { return _Comision; }
            set
            { _Comision = value; }
        }
        public ComisionesDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            Business.Logic.ComisionLogic coml = new Business.Logic.ComisionLogic();
            try
            {
                ComisionActual = coml.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public override void MapearDeDatos()
        {
            if (Modo == ModoForm.Alta)
                this.btnModo.Text = "Aceptar";
            else
            {
                if (Modo == ModoForm.Consulta) this.btnModo.Text = "Aceptar";
                else if (Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
                else if (Modo == ModoForm.Baja) this.btnModo.Text = "Eliminar";

                this.txtIDCom.Text = this.ComisionActual.ID.ToString();
                this.txtAnioEsp_Com.Text = this.ComisionActual.AnioEspecialidad.ToString();
                this.txtDesc_Com.Text = this.ComisionActual.DescComision;
                this.txtIDPlan_Com.Text = this.ComisionActual.IDPlan.ToString();
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                ComisionActual = new Business.Entities.Comision();
                ComisionActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    ComisionActual.State = BusinessEntity.States.Modified;
                    this.txtIDCom.Text = this.ComisionActual.ID.ToString();
                }
                this.ComisionActual.DescComision = this.txtDesc_Com.Text;
                this.ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEsp_Com.Text);
                this.ComisionActual.IDPlan = int.Parse(this.txtIDPlan_Com.Text);
            }

            if (this.Modo == ModoForm.Baja) ComisionActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) ComisionActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic ComisionLogic = new ComisionLogic();
            try
            {
                ComisionLogic.Save(ComisionActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Validar()
        {
            if (txtDesc_Com.Text.Equals(String.Empty) || txtAnioEsp_Com.Text.Equals(String.Empty) || txtIDPlan_Com.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarTexto(txtDesc_Com.Text))
            {
                Notificar("Descripcion incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Validaciones.validarTexto(txtAnioEsp_Com.Text))    //quitamos el "!", siguiendo logica de UsuarioDesktop 
            {
                Notificar("Año especialidad incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Validaciones.validarTexto(txtIDPlan_Com.Text))
            {
                Notificar("ID de plan incorrecto.", "Intente nuevamente",
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

