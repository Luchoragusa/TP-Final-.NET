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
    public partial class DocenteCurso : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }

        DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new DocenteCursoLogic();
                }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            Usuario docente = (Usuario)Session["usuario"];
            Business.Entities.Entidades.Personas per = new Business.Entities.Entidades.Personas();
            per.ID = (int)Session["id_persona"];
            switch (per.ID)
            {
                case 1:     //docente
                    nuevoLinkButton.Enabled = false;
                    editarLinkButton.Enabled = false;
                    eliminarLinkButton.Enabled = false;
                    this.gridView.DataSource = this.Logic.getCursosDocente(docente);
                    this.gridView.DataBind();
                    break;

                default:
                    this.gridView.DataSource = this.Logic.GetAll();
                    this.gridView.DataBind();
                    break;
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
        public Business.Entities.Entidades.DocenteCurso Entity
        {
            get;
            set;
        }

        protected void LoadForm(int id)
        {
            Entity = new Business.Entities.Entidades.DocenteCurso();
            this.Entity.ID = id;
            this.Entity = this.Logic.GetOne(Entity);

            this.iddocenteTextBox.Text = this.Entity.IDDocente.ToString();
            this.idcursoTextBox.Text = this.Entity.IDCurso.ToString();
            this.dropDownListCargo.SelectedValue = this.Entity.Cargo.ToString();
           
        }

        protected override void EnableForm(bool enable)
        {
            this.iddocenteTextBox.Enabled = enable;
            this.idcursoTextBox.Enabled = enable;
            this.dropDownListCargo.Enabled = enable;
        }

        protected override void ClearForm()
        {
            this.iddocenteTextBox.Text = string.Empty;
            this.idcursoTextBox.Text = string.Empty;
            this.dropDownListCargo.SelectedValue = string.Empty;
        }
        private void SaveEntity(Business.Entities.Entidades.DocenteCurso DocenteCurso)
        {
            this.Logic.Save(DocenteCurso);
        }
        protected override void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadEntity(Business.Entities.Entidades.DocenteCurso DocenteCurso)
        {
            DocenteCurso.IDDocente = int.Parse(this.iddocenteTextBox.Text);
            DocenteCurso.IDCurso = int.Parse(this.idcursoTextBox.Text);
            //DocenteCurso.Cargo = this.dropDownListCargo.SelectedValue;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Entidades.DocenteCurso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Entidades.DocenteCurso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DocenteCurso.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}