using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class CursosDesktop : UI.Desktop.ApplicationForm
    {
        public CursosDesktop()
        {
            InitializeComponent();
        }
        public CursosDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            MapearDeDatos();
        }
        private Business.Entities.Curso _Curso;
        public Business.Entities.Curso CursoActual
        {
            get
            { return _Curso; }
            set
            { _Curso = value; }
        }
        public CursosDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            Business.Logic.EntidadesLogic.CursoLogic curl = new Business.Logic.EntidadesLogic.CursoLogic();
            try
            {
                CursoActual = new Business.Entities.Curso();
                _Curso.ID = ID;
                CursoActual = curl.GetOne(CursoActual);
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
                this.txtIDCurso.Text = this.CursoActual.ID.ToString();
                this.txtIDMat.Text = this.CursoActual.IDMateria.ToString();
                this.txtIDCom.Text = this.CursoActual.IDComision.ToString();
                this.txtAnioEsp_Cur.Text = this.CursoActual.AnioCalendario.ToString();
                this.txtCupo.Text = this.CursoActual.Cupo.ToString();

                if (Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
                else if (Modo == ModoForm.Baja)
                {
                    this.btnModo.Text = "Eliminar";

                    this.txtIDCurso.Enabled = false;
                    this.txtIDMat.Enabled = false;
                    this.txtIDCom.Enabled = false;
                    this.txtAnioEsp_Cur.Enabled = false;
                    this.txtCupo.Enabled = false;
                }
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                CursoActual = new Business.Entities.Curso();
                CursoActual.State = BusinessEntity.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    CursoActual.State = BusinessEntity.States.Modified;
                    this.txtIDCurso.Text = this.CursoActual.ID.ToString();
                }
                this.CursoActual.IDMateria = Convert.ToInt32(this.txtIDMat.Text);
                this.CursoActual.IDComision = Convert.ToInt32(this.txtIDCom.Text);
                this.CursoActual.AnioCalendario = Convert.ToInt32(this.txtAnioEsp_Cur.Text);
                this.CursoActual.Cupo = Convert.ToInt32(this.txtCupo.Text);
            }
            if (this.Modo == ModoForm.Baja) CursoActual.State = BusinessEntity.States.Deleted;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.EntidadesLogic.CursoLogic cl = new Business.Logic.EntidadesLogic.CursoLogic();
            try
            {
                cl.Save(CursoActual);
                MessageBox.Show("La operacion se realizo correctamente", "Informacion", MessageBoxButtons.OK);
                this.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override bool Validar()
        {
            if (txtIDMat.Text.Equals(String.Empty) || txtIDCom.Text.Equals(String.Empty) || txtAnioEsp_Cur.Text.Equals(String.Empty) || txtCupo.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtIDMat.Text))
            {
                Notificar("ID Materia incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtIDCom.Text))
            {
                Notificar("ID Comision incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtAnioEsp_Cur.Text))
            {
                Notificar("Anio incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtCupo.Text))
            {
                Notificar("Cupo incorrecto.", "Intente nuevamente",
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
