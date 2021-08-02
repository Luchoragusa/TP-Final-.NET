﻿using System;
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

namespace UI.Desktop.Alum_Inscrip
{
    public partial class Alum_InscripDesktop : ApplicationForm
    {
        public Alum_InscripDesktop()
        {
            InitializeComponent();
        }

        public Alum_InscripDesktop(ModoForm modo) : this()
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

        public Alum_InscripDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            Alumno_InscripcionLogic alu_ins = new Alumno_InscripcionLogic();
            try
            {
                Alum_InscripActual = alu_ins.GetOne(ID);
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

                this.txtID.Text = this.Alum_InscripActual.ID.ToString();
                this.txtIDAlumno.Text = this.Alum_InscripActual.IDAlumno.ToString();
                this.txtIDCurso.Text = this.Alum_InscripActual.IDCurso.ToString();
                this.txtCondicion.Text = this.Alum_InscripActual.Condicion;
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
                    this.txtID.Text = this.Alum_InscripActual.ID.ToString();
                }
                this.txtIDAlumno.Text = this.Alum_InscripActual.IDAlumno.ToString();
                this.txtIDCurso.Text = this.Alum_InscripActual.IDCurso.ToString();
                this.txtCondicion.Text = this.Alum_InscripActual.Condicion;
                this.txtNota.Text = this.Alum_InscripActual.Nota.ToString();
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
            if (txtIDAlumno.Text.Equals(String.Empty) || txtIDCurso.Text.Equals(String.Empty) || txtCondicion.Text.Equals(String.Empty) || txtNota.Text.Equals(String.Empty))
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