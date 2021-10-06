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
    public partial class Alum_Inscrip : System.Web.UI.Page
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
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
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
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.idcursoTextBox.Text = this.Entity.IDCurso.ToString();
            this.idalumnoTextBox.Text = this.Entity.IDAlumno.ToString();
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
            if (this.idcursoTextBox.Text.Equals(string.Empty) ||
                                this.idalumnoTextBox.Text.Equals(string.Empty) ||
                                this.notaTextBox.Text.Equals(string.Empty) ||
                                this.condicionTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            else
            {
                ali.IDCurso = int.Parse(this.idcursoTextBox.Text);
                ali.IDAlumno = int.Parse(this.idalumnoTextBox.Text);
                ali.Nota = this.notaTextBox.Text;
                ali.Condicion = this.condicionTextBox.Text;
            }
            return band;
        }

        private void SaveEntity(Alumnos_Inscripciones ali)
        {
            this.Logic.Save(ali);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
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

        private void EnableForm(bool enable)
        {
            this.idcursoTextBox.Enabled = enable;
            this.idalumnoTextBox.Enabled = enable;
            this.notaTextBox.Enabled = enable;
            this.notaTextBox.Enabled = enable;
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

        private void DeleteEntity(int id)
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

        private void ClearForm()
        {
            this.idcursoTextBox.Text = string.Empty;
            this.idalumnoTextBox.Text = string.Empty;
            this.notaTextBox.Text = string.Empty;
            this.condicionTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alum_Inscrip.aspx");
        }
    }
}