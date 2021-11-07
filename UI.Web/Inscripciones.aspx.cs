using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Web
{
    public partial class Inscripciones : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }

        Alumno_InscripcionLogic _logic;
        private Alumno_InscripcionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new Alumno_InscripcionLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.gridViewInscripciones.DataSource = this.Logic.GetAll();
            this.gridViewInscripciones.DataBind();
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

        protected void gridViewMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}