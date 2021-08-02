using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Desktop
{
    public partial class DCDesktop : UI.Desktop.ApplicationForm
    {
        public DCDesktop()
        {
            InitializeComponent();
        }

        public DCDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            DCActual = new Business.Entities.Entidades.DocenteCurso();
        }

        private Business.Entities.Entidades.DocenteCurso _dc;
        public Business.Entities.Entidades.DocenteCurso DCActual  { get; set; }

        public DCDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            Business.Logic.EntidadesLogic.DocenteCursoLogic dcl = new Business.Logic.EntidadesLogic.DocenteCursoLogic();
            try
            {
                DCActual = dcl.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtIDDictado.Text = this.DCActual.ID.ToString();
            this.txtIDCurso.Text = this.DCActual.IDCurso.ToString();
            this.txtIDDocente.Text = this.DCActual.IDDocente.ToString();
            this.txtCargo.Text = this.DCActual.Cargo.ToString();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnModo.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            try
            {
                if (Modo == ModoForm.Alta)
                {
                    DCActual = new Business.Entities.Entidades.DocenteCurso();
                    DCActual.State = BusinessEntity.States.New;
                }

                if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
                {
                    if (Modo != ModoForm.Alta)
                    {
                        DCActual.State = BusinessEntity.States.Modified;
                        this.txtIDDictado.Text = this.DCActual.ID.ToString();
                    }
                    this.DCActual.IDCurso = int.Parse(this.txtIDCurso.Text);
                    this.DCActual.IDDocente = int.Parse(this.txtIDDocente.Text);
                    this.DCActual.Cargo = (Business.Entities.Entidades.DocenteCurso.TipoCargos)int.Parse(this.txtCargo.Text);
                }

                if (this.Modo == ModoForm.Baja) DCActual.State = BusinessEntity.States.Deleted;
                if (this.Modo == ModoForm.Consulta) DCActual.State = BusinessEntity.States.Unmodified;
            }
            catch (Exception)
            {
                Notificar("Error", "Se produjo un error al conectar con la BD.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic dcLogic = new DocenteCursoLogic();
            try
            {
                dcLogic.Save(DCActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Validar()
        {
            if (txtIDCurso.Text.Equals(String.Empty) || txtIDDocente.Text.Equals(String.Empty) || txtCargo.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarTexto(txtIDCurso.Text))
            {
                Notificar("ID del curso incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtIDDocente.Text))    
            {
                Notificar("ID del docente incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtCargo.Text))
            {
                Notificar("Cargo incorrecto.", "Intente nuevamente",
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
