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

        private void LoadGridMaterias ()
        {
            btnVolver.Visible = true;
            Usuario alumno = (Usuario)Session["usuario"];
            Business.Logic.MateriaLogic ml = new Business.Logic.MateriaLogic();
            this.gridViewMateriasInscripcion.DataSource = ml.GetAll();
            this.gridViewMateriasInscripcion.DataBind();
        }

        private void LoadGridComisiones()
        {
            
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {

        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        protected void gridViewMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridViewMateriasInscripcion.SelectedValue;
        }
    }
}