using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Logic.EntidadesLogic;
using Business.Entities;
using Business.Entities.Entidades;

namespace UI.Web
{
    public partial class RegistrarNota : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGridCursos();
                if (this.gridViewCursosDelDocente.SelectedIndex == -1)
                {
                    this.Panel2.Visible = false;
                }
            }
        }
        private void LoadGridCursos()
        {
            btnVolver.Visible = true;
            Usuario docente = (Usuario)Session["usuario"];
            Business.Logic.EntidadesLogic.CursoLogic cl = new Business.Logic.EntidadesLogic.CursoLogic();
            this.gridViewCursosDelDocente.DataSource = cl.GetAllDocente(docente);
            this.gridViewCursosDelDocente.DataBind();
        }

        private void LoadGridAlumnos()
        {
            Business.Logic.EntidadesLogic.Alumno_InscripcionLogic al = new Business.Logic.EntidadesLogic.Alumno_InscripcionLogic();

            Business.Entities.Curso curso = new Business.Entities.Curso();
            curso.ID = (int)this.gridViewCursosDelDocente.SelectedValue;

            this.gridViewAlumnosDelCursoDelDocente.DataSource = al.GetAllByCurso(curso);
            this.gridViewAlumnosDelCursoDelDocente.DataBind();
        }

        public Alumnos_Inscripciones Entity
        {
            get;set;
        }

        private int SelectedIDAlumno
        {
            get
            {
                if (this.ViewState["SelectedIDAlumno"] != null)
                    return (int)this.ViewState["SelectedIDAlumno"];
                else
                    return 0;
            }
            set
            {
                this.ViewState["SelectedIDAlumno"] = value;
            }
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
            this.Entity.ID = SelectedIDAlumno;
            this.Entity = alumnoLogic.GetOne(Entity);
            this.Entity.State = BusinessEntity.States.Modified;
            this.LoadEntity(this.Entity);
            this.SaveEntity(this.Entity);
            this.LoadGridAlumnos();
        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarNota.aspx");
        }

        private void SaveEntity(Alumnos_Inscripciones alumno)
        {
            try
            {
                Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
                alumnoLogic.Save(alumno);

            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }
    
        private void LoadEntity(Alumnos_Inscripciones alumno)
        {
            alumno.Nota = this.DropDownListNotas.SelectedValue;
            alumno.Condicion = this.DropDownListCondicion.SelectedValue;
        }

        protected void gridViewCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridViewCursosDelDocente.SelectedValue;
            LoadGridAlumnos();
            this.Panel2.Visible = true;
        }

        protected void gridViewAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedIDAlumno = (int)this.gridViewAlumnosDelCursoDelDocente.SelectedValue;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }


    }
}