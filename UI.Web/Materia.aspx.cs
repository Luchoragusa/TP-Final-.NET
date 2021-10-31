using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Materia : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }
        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic();
                }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
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
        public Business.Entities.Materia Entity
        {
            get;
            set;
        }

        protected override void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);

            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.HSTotalesTextBox.Text = this.Entity.HSTotales.ToString();
            this.HSSSemanalesTextBox.Text = this.Entity.HSSSemanales.ToString();
            this.IDPlanTextBox.Text = this.Entity.IDPlan.ToString();
        }

        protected override void EnableForm(bool enable)
        {
            this.descripcionTextBox.Enabled = enable;
            this.HSTotalesTextBox.Enabled = enable;
            this.HSSSemanalesTextBox.Enabled = enable;
            this.IDPlanTextBox.Enabled = enable;
        }

        protected override void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
            this.HSTotalesTextBox.Text = string.Empty;
            this.HSSSemanalesTextBox.Text = string.Empty;
            this.IDPlanTextBox.Text = string.Empty;
        }
        private void SaveEntity(Business.Entities.Materia materia)
        {
            this.Logic.Save(materia);
        }
        protected override void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadEntity(Business.Entities.Materia materia)
        {
            materia.Descripcion = this.descripcionTextBox.Text;
            materia.HSTotales = int.Parse(this.HSTotalesTextBox.Text);
            materia.HSSSemanales = int.Parse(this.HSSSemanalesTextBox.Text);
            materia.IDPlan = int.Parse(this.IDPlanTextBox.Text);
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
                    this.Entity = new Business.Entities.Materia();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Materia();
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
            Response.Redirect("Materia.aspx");
        }
    }
}