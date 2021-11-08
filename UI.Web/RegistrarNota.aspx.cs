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
                LoadGridMaterias();
                if (this.gridViewAlumnosDelCursoDelDocente.SelectedIndex == -1)
                {
                    this.PanelComisiones.Visible = false;
                    this.PanelCursos.Visible = false;
                    this.PanelAlumnos.Visible = false;            //grid view alumno
                }
            }
        }

        private void LoadGridMaterias()
        {
            btnVolver.Visible = true;
            Usuario docente = (Usuario)Session["usuario"];
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            this.gridViewMaterias.DataSource = dcl.GetAllMateriasDelDocente(docente);
            this.gridViewMaterias.DataBind();
        }

        private void LoadGridComisiones()
        {
            btnVolver.Visible = true;
            Usuario docente = (Usuario)Session["usuario"];
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            Business.Entities.Materia materia = new Business.Entities.Materia();
            materia.ID = SelectedIDMateria;
            this.gridViewComisiones.DataSource = dcl.GetAllComisionesMateria(docente, materia);
            this.gridViewComisiones.DataBind();
        }

        private void LoadGridCursos()
        {
            btnVolver.Visible = true;
            Usuario docente = (Usuario)Session["usuario"];
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            Business.Entities.Materia materia = new Business.Entities.Materia();
            materia.ID = SelectedIDMateria;
            Business.Entities.Comision comision = new Business.Entities.Comision();
            comision.ID = SelectedIDComision;

            this.gridViewCursosDelDocente.DataSource = dcl.GetAllCursosDeLaComision(docente, materia, comision);
            this.gridViewCursosDelDocente.DataBind();
        }

        private void LoadGridAlumnos()
        {
            Business.Logic.EntidadesLogic.Alumno_InscripcionLogic al = new Business.Logic.EntidadesLogic.Alumno_InscripcionLogic();

            Business.Entities.Curso curso = new Business.Entities.Curso();
            curso.ID = SelectedIDCurso;  //id de curso

            this.gridViewAlumnosDelCursoDelDocente.DataSource = al.GetAllByCurso(curso);
            this.gridViewAlumnosDelCursoDelDocente.DataBind();
        }

        public Alumnos_Inscripciones Entity
        {
            get;set;
        }

        private int SelectedIDCurso
        {
            get
            {
                if (this.ViewState["SelectedIDCurso"] != null)
                    return (int)this.ViewState["SelectedIDCurso"];
                else
                    return 0;
            }
            set
            {
                this.ViewState["SelectedIDCurso"] = value;
            }
        }

        private int SelectedIDMateria
        {
            get
            {
                if (this.ViewState["SelectedIDMateria"] != null)
                    return (int)this.ViewState["SelectedIDMateria"];
                else
                    return 0;
            }
            set
            {
                this.ViewState["SelectedIDMateria"] = value;
            }
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

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
            Entity = new Alumnos_Inscripciones();
            Entity.ID = SelectedID;

            this.Entity = alumnoLogic.GetOne(Entity);
            this.Entity.State = BusinessEntity.States.Modified;
            this.LoadEntity(this.Entity);
            this.SaveEntity();
            this.LoadGridAlumnos();
        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarNota.aspx");
        }

        private void SaveEntity()
        {
            try
            {
                Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
                alumnoLogic.Update(Entity);

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
            this.SelectedIDCurso = (int)this.gridViewCursosDelDocente.SelectedValue;
            LoadGridAlumnos();
            this.PanelAlumnos.Visible = true;
        }

        protected void gridViewAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridViewAlumnosDelCursoDelDocente.SelectedValue;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        protected void gridViewMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedIDMateria = (int)this.gridViewMaterias.SelectedValue;
            LoadGridComisiones();
            this.PanelComisiones.Visible = true;
        }

        protected void gridViewComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedIDComision = (int)this.gridViewComisiones.SelectedValue;
            LoadGridCursos();
            this.PanelCursos.Visible = true;
        }
    }
}