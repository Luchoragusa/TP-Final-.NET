using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic.EntidadesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.RegistrarNotas
{
    public partial class Editar_InscripcionDesktop : ApplicationForm
    {
        public Editar_InscripcionDesktop()
        {
            InitializeComponent();
        }
        public Editar_InscripcionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            MapearDeDatos();
        }
        private Alumnos_Inscripciones _Alumn_Incrip;
        public Alumnos_Inscripciones Alum_InscripActual
        {
            get
            { return _Alumn_Incrip; }
            set
            { _Alumn_Incrip = value; }
        }

        public Editar_InscripcionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            Alumno_InscripcionLogic alu_ins = new Alumno_InscripcionLogic();
            try
            {
                Alumnos_Inscripciones ai = new Alumnos_Inscripciones();
                ai.ID = ID;
                Alum_InscripActual = alu_ins.GetOne(ai);
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
                if (Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
                else if (Modo == ModoForm.Baja) this.btnModo.Text = "Eliminar";

                this.txtNombre.Text = this.Alum_InscripActual.NombrePersona.ToString();
                this.txtApellido.Text = this.Alum_InscripActual.ApellidoPersona.ToString();
                this.txtLegajo.Text = this.Alum_InscripActual.legajoPersona.ToString();
                this.cbCondicion.Text = this.Alum_InscripActual.Condicion;
                this.txtNota.Text = this.Alum_InscripActual.Nota.ToString();
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Alum_InscripActual = new Alumnos_Inscripciones();
                Alum_InscripActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    Alum_InscripActual.State = BusinessEntity.States.Modified;
                }
                this.Alum_InscripActual.Condicion = this.cbCondicion.Text;
                this.Alum_InscripActual.Nota = this.txtNota.Text;
            }

            if (this.Modo == ModoForm.Baja) Alum_InscripActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) Alum_InscripActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            Alumno_InscripcionLogic alumno_InscripcionLogic = new Alumno_InscripcionLogic();
            try
            {
                alumno_InscripcionLogic.Save(Alum_InscripActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Validar()
        {
            if (txtApellido.Text.Equals(String.Empty) || txtLegajo.Text.Equals(String.Empty) || cbCondicion.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (!Validaciones.validarTexto(txtIDCurso.Text))
            //{
            //    Notificar("Descripcion incorrecta.", "Intente nuevamente",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //if (Validaciones.validarTexto(txtIDAlumno.Text)) // validar lo de abajo con que sea correspondiente a un plan ya creado
            //{
            //    Notificar("ID incorrecta.", "Intente nuevamente",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
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
