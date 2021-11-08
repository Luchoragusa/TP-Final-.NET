﻿using System;
using System.Web.UI;
using Business.Logic;
using Business.Logic.EntidadesLogic;
using Business.Entities;
using Business.Entities.Entidades;

namespace UI.Web
{
    public partial class InscribirseACursado : ApplicationFormWeb
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGridMaterias();
                if (this.gridViewMateriasInscripcion.SelectedIndex == -1)
                {
                    this.gridViewComisionesMateria.Visible = false;
                }
            }
        }

        public FormModes FormMode
        {
            get
            {
                return (FormModes)this.ViewState["FormMode"];
            }
            set
            {
                this.ViewState["FormMode"] = value;
            }
        }

        public Alumnos_Inscripciones Entity
        {
            get;
            set;
        }

        private int SelectedIDComision
        {
            get
            {
                if (this.ViewState["SelectedIDComision"] != null)
                    return (int)this.ViewState["SelectedIDComision"];
                else
                    return 0;
            }
            set
            {
                this.ViewState["SelectedIDComision"] = value;
            }
        }

        private void LoadGridMaterias ()
        {
            btnVolver.Visible = true;            
            MateriaLogic ml = new MateriaLogic();
            this.gridViewMateriasInscripcion.DataSource = ml.GetAll();
            this.gridViewMateriasInscripcion.DataBind();
        }

        Business.Entities.Materia mate = new Business.Entities.Materia();
        public Business.Entities.Materia Mate { get => mate; set => mate = value; }

        public void LoadGridComisiones()
        {
            ComisionLogic cl = new ComisionLogic();

            Mate.ID = this.SelectedID;           

            this.gridViewComisionesMateria.DataSource = cl.GetAllMateriasCom(Mate);
            this.gridViewComisionesMateria.DataBind();
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            PersonaLogic perl = new PersonaLogic();
            Usuario usuario = (Usuario)Session["usuario"];
            Business.Entities.Comision com = new Business.Entities.Comision();
            Business.Entities.Curso curso = new Business.Entities.Curso();
            Personas persona = new Personas();


            com.ID = SelectedIDComision;
            curso = cl.getByComision(com);
            persona = perl.GetIDPersona(usuario);

            Entity = new Alumnos_Inscripciones();

            this.Entity.IDCurso = curso.ID;
            this.Entity.IDAlumno = persona.ID;
            this.Entity.Condicion = "Cursando";

            this.Entity.State = BusinessEntity.States.Modified;

            Alumno_InscripcionLogic al = new Alumno_InscripcionLogic();
            al.Insert(Entity);
            
            this.LoadGridComisiones();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        protected void gridViewMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridViewMateriasInscripcion.SelectedValue;
            LoadGridComisiones();
            this.gridViewComisionesMateria.Visible = true;
        }

        protected void gridViewAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedIDComision = (int)this.gridViewComisionesMateria.SelectedValue;
        }
    }
}