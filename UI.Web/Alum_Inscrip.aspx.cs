using System;
using System.Web.UI;
using System.Windows.Forms;
using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic.EntidadesLogic;

namespace UI.Web
{
    public partial class Alum_Inscrip : ApplicationFormWeb
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
                if(_logic == null)
                {
                    _logic = new Alumno_InscripcionLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            Usuario us = (Usuario)Session["usuario"];
            int tipo_persona = (int)Session["tipo_persona"];
            switch (tipo_persona)
            {
                case 1:     //alumno
                    nuevoLinkButton.Enabled = false;
                    editarLinkButton.Enabled = false;
                    break;

                default:
                    break;
            }
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

        public Alumnos_Inscripciones Entity
        {
            get;
            set;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void LoadForm(int id)
        {
            Entity = new Alumnos_Inscripciones();
            this.Entity.ID = id;
            this.Entity = this.Logic.GetOne(Entity);
            this.txtNombrePersona.Text = this.Entity.NombrePersona.ToString();
            this.txtApellidoPersona.Text = this.Entity.ApellidoPersona.ToString();
            this.txtLegajoPersona.Text = this.Entity.legajoPersona.ToString();
            this.notaTextBox.Text = this.Entity.Nota.ToString();
            this.condicionTextBox.Text = this.Entity.Condicion;
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

        private Boolean LoadEntity(Alumnos_Inscripciones ali)
        {
            bool band = false;
            if (this.notaTextBox.Text.Equals(string.Empty) ||
                                this.condicionTextBox.Text.Equals(string.Empty) ||
                                this.txtNombrePersona.Text.Equals(string.Empty) ||
                                this.txtApellidoPersona.Text.Equals(string.Empty) ||
                                this.txtLegajoPersona.Text.Equals(string.Empty))
            {
                MessageBox.Show("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            else
            {
                //ali.NombrePersona = this.txtNombrePersona.Text;
                //ali.ApellidoPersona = this.txtApellidoPersona.Text;
                //ali.legajoPersona = int.Parse(this.txtLegajoPersona.Text);
                ali.Nota = this.notaTextBox.Text;
                ali.Condicion = this.condicionTextBox.Text;
            }
            return band;
        }

        private void SaveEntity(Alumnos_Inscripciones ali)
        {
            this.Logic.Save(ali);
        }

        protected override void EnableForm(bool enable)
        {
            this.notaTextBox.Enabled = enable;
            this.condicionTextBox.Enabled = enable;
            this.txtNombrePersona.Enabled = enable;
            this.txtApellidoPersona.Enabled = enable;
            this.txtLegajoPersona.Enabled = enable;
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
            this.notaTextBox.Text = string.Empty;
            this.condicionTextBox.Text = string.Empty;
            this.txtNombrePersona.Text = string.Empty;
            this.txtApellidoPersona.Text = string.Empty;
            this.txtLegajoPersona.Text = string.Empty;
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Boolean band = false;
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Alumnos_Inscripciones();
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
                    this.Entity = new Alumnos_Inscripciones();
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
            Response.Redirect("Alum_Inscrip.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}