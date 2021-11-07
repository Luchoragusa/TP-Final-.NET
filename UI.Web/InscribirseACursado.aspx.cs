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
            Business.Logic.MateriaLogic ml = new Business.Logic.MateriaLogic();
            this.gridViewMateriasInscripcion.DataSource = ml.GetAll();
            this.gridViewMateriasInscripcion.DataBind();
        }

        Business.Entities.Materia mate = new Business.Entities.Materia();
        public Business.Entities.Materia Mate { get => mate; set => mate = value; }

        private void LoadGridComisiones()
        {
            ComisionLogic cl = new ComisionLogic();

            Mate.ID = this.SelectedID;           

            this.gridViewComisionesMateria.DataSource = cl.GetAllMateriasCom(Mate);
            this.gridViewComisionesMateria.DataBind();
        }

        Personas persona = new Personas();
        Business.Entities.Curso curso = new Business.Entities.Curso();
        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
            CursoLogic cl = new CursoLogic();
            PersonaLogic perl = new PersonaLogic();
            Usuario usuario = (Usuario)Session["usuario"];

            curso = cl.getByMateria(Mate);
            persona = perl.GetIDPersona(usuario);

            Entity = new Alumnos_Inscripciones();

            this.Entity.IDCurso = curso.ID;
            this.Entity.IDAlumno = persona.ID;
            this.Entity.Condicion = "Cursando";

            this.Entity.State = BusinessEntity.States.Modified;
            this.SaveEntity();
            this.LoadGridComisiones();
        }


        private void SaveEntity()
        {
            try
            {
                Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
                alumnoLogic.Save(Entity);

            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
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