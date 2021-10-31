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

namespace UI.Web.Pag_Individuales
{
    public partial class Comision : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }

        }

        ComisionLogic _logic;
        private ComisionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionLogic();
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


        public Business.Entities.Comision Entity
        {
            get;
            set;
        }


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected override void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);

            this.idPlanTextBox.Text = this.Entity.IDPlan.ToString();
            this.descComisionTextBox.Text = this.Entity.DescComision.ToString();
            this.anioEspecialidadTextBox.Text = this.Entity.AnioEspecialidad.ToString();
     
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
        private Boolean LoadEntity(Business.Entities.Comision comi)
        {
            bool band = false;
            if (this.idPlanTextBox.Text.Equals(string.Empty) ||
                                this.descComisionTextBox.Text.Equals(string.Empty) ||
                                this.anioEspecialidadTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            else
            {
                comi.IDPlan = int.Parse(this.idPlanTextBox.Text);
                comi.DescComision = this.descComisionTextBox.Text;
                comi.AnioEspecialidad = int.Parse(this.anioEspecialidadTextBox.Text);
            }
            return band;
        }

        private void SaveEntity(Business.Entities.Comision comi)
        {
            this.Logic.Save(comi);
        }

        protected override void EnableForm(bool enable)
        {
            this.idPlanTextBox.Enabled = enable;
            this.descComisionTextBox.Enabled = enable;
            this.anioEspecialidadTextBox.Enabled = enable;
           
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

        protected override void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }


        protected override void ClearForm()
        {
            this.idPlanTextBox.Text = string.Empty;
            this.descComisionTextBox.Text = string.Empty;
            this.anioEspecialidadTextBox.Text = string.Empty;
            
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Boolean band = false;
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Comision();
                    band = this.LoadEntity(this.Entity);
                    if (band)
                        break;
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Comision();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    band = this.LoadEntity(this.Entity);
                    if (band)
                        break;

                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            if (!band)
                this.formPanel.Visible = false;
        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comision.aspx");
        }
    }   
}