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
    public partial class Especialidad : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }
        EspecialidadLogic _logic;
        private EspecialidadLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new EspecialidadLogic();
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
        public Business.Entities.Especialidad Entity
        {
            get;
            set;
        }
        protected override void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);

            this.descripcionTextBox.Text = this.Entity.DescEspecialidad;
        }

        protected override void EnableForm(bool enable)
        {
            this.descripcionTextBox.Enabled = enable;
            
        }

        protected override void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
        }
        private void SaveEntity(Business.Entities.Especialidad Especialidad)
        {
            this.Logic.Save(Especialidad);
        }
        protected override void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadEntity(Business.Entities.Especialidad Especialidad)
        {
            Especialidad.DescEspecialidad = this.descripcionTextBox.Text;
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
                    this.Entity = new Business.Entities.Especialidad();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Especialidad();
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
            Response.Redirect("Especialidad.aspx");
        }
    }
}