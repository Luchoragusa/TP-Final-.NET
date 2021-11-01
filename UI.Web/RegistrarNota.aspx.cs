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
            Usuario docente = (Usuario)Session["usuario"];
            Business.Logic.EntidadesLogic.CursoLogic cl = new Business.Logic.EntidadesLogic.CursoLogic();
            this.gridViewCursosDelDocente.DataSource = cl.GetAllDocente(docente);
            this.gridViewCursosDelDocente.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridViewCursosDelDocente.SelectedValue;
            LoadGridAlumnos();
            this.Panel2.Visible = true;
        }

        private void LoadGridAlumnos()
        {
            Business.Logic.EntidadesLogic.Alumno_InscripcionLogic al = new Business.Logic.EntidadesLogic.Alumno_InscripcionLogic();

            Business.Entities.Curso curso = null;
            int id = (int)this.gridViewCursosDelDocente.SelectedValue;
            curso.ID = id;

            this.gridViewAlumnosDelCursoDelDocente.DataSource = al.GetAllByCurso(curso);
            this.gridViewAlumnosDelCursoDelDocente.DataBind();
        }
    }
}