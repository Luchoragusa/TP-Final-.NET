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
    public partial class Curso : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }

        }
        CursoLogic  _logic;

        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
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

        public Business.Entities.Curso Entity
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

            this.anioCalendarioTextBox.Text = this.Entity.AnioCalendario.ToString();
            this.cupoTextBox.Text = this.Entity.Cupo.ToString();
            this.idComisionTextBox.Text = this.Entity.IDComision.ToString();
            this.idMateriaTextBox.Text = this.Entity.IDMateria.ToString();
            this.descripcionTextBox.Text = this.Entity.Descripcion.ToString();
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

        private Boolean LoadEntity(Business.Entities.Curso cur)
        {
            bool band = false;
            if (this.anioCalendarioTextBox.Text.Equals(string.Empty) ||
                                this.cupoTextBox.Text.Equals(string.Empty) ||
                                this.idComisionTextBox.Text.Equals(string.Empty) ||
                                this.idMateriaTextBox.Text.Equals(string.Empty) ||
                                this.descripcionTextBox.Text.Equals(string.Empty)
                                )
            {
                MessageBox.Show("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            else
            {
                cur.AnioCalendario = int.Parse(this.anioCalendarioTextBox.Text);
                cur.Cupo = int.Parse(this.cupoTextBox.Text);
                cur.IDComision = int.Parse(this.idComisionTextBox.Text);
                cur.IDMateria = int.Parse(this.idMateriaTextBox.Text);
                cur.Descripcion = this.descripcionTextBox.Text;
               
            }
            return band;
        }
        private void SaveEntity(Business.Entities.Curso cur)
        {
            this.Logic.Save(cur);
        }

        protected override void EnableForm(bool enable)
        {
            this.anioCalendarioTextBox.Enabled = enable;
            this.cupoTextBox.Enabled = enable;
            this.idComisionTextBox.Enabled = enable;
            this.idMateriaTextBox.Enabled = enable;
            this.descripcionTextBox.Enabled = enable;

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
            this.anioCalendarioTextBox.Text = string.Empty;
            this.cupoTextBox.Text = string.Empty;
            this.idComisionTextBox.Text = string.Empty;
            this.idMateriaTextBox.Text = string.Empty;
            this.descripcionTextBox.Text = string.Empty;

        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Boolean band = false;
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Curso();
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
                    this.Entity = new Business.Entities.Curso();
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
            Response.Redirect("Curso.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}