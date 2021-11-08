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
    public partial class Persona : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((int)Session["tipo_persona"] == 4)
                {
                    this.FormMode = FormModes.Alta;
                    this.btnVolver.Visible = true;
                    this.gridPanel.Visible = false;
                    this.Panel4.Visible = true;
                    this.gridActionsPanel.Visible = false;
                    this.formPanel.Visible = true;
                }
                else
                {
                    this.formPanel.Visible = false;
                    this.gridActionsPanel.Visible = false;
                    LoadGrid(); 
                }               
            }
        }

        PersonaLogic _logic;
        private PersonaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonaLogic();
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

        public Personas Entity
        {
            get;
            set;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            this.gridActionsPanel.Visible = true;
        }

        protected void LoadForm(int id)
        {
            Entity = new Personas();
            this.Entity.ID = id;
            this.Entity = this.Logic.GetOne(Entity);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.emailTextBox.Text = this.Entity.Email;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.fechanacTextBox.Text = this.Entity.FechaNacimiento.ToLongDateString();
            this.idplanTextBox.Text = this.Entity.IDPlan.ToString();
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
        private Boolean LoadEntity(Personas persona)
        {
            bool band = false;
            if (this.nombreTextBox.Text.Equals(string.Empty) ||
                                this.apellidoTextBox.Text.Equals(string.Empty) ||
                                this.direccionTextBox.Text.Equals(string.Empty) ||
                                this.emailTextBox.Text.Equals(string.Empty) ||
                                this.telefonoTextBox.Text.Equals(string.Empty) ||
                                this.legajoTextBox.Text.Equals(string.Empty) ||                                
                                this.fechanacTextBox.Text.Equals(string.Empty) ||
                                this.idplanTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            else
            {
                Usuario usuario = (Usuario)Session["usuario"];
                persona.IdUsuario = usuario.ID;

                if (this.DropDownList1.SelectedValue == "Alumno")
                    persona.TipoPersona = Personas.TipoPersonas.Alumno;
                else if (this.DropDownList1.SelectedValue == "Docente")
                    persona.TipoPersona = Personas.TipoPersonas.Docente;
                else
                    persona.TipoPersona = Personas.TipoPersonas.Administrador;

                persona.Apellido = this.apellidoTextBox.Text;
                persona.Nombre = this.nombreTextBox.Text;
                persona.Direccion = this.direccionTextBox.Text;

                if (Validaciones.validarMail(this.emailTextBox.Text))
                    band = true;
                else
                    persona.Email = this.emailTextBox.Text; 

                persona.Telefono = this.telefonoTextBox.Text;
                persona.Legajo = int.Parse(this.legajoTextBox.Text);
                persona.FechaNacimiento = DateTime.Parse(this.fechanacTextBox.Text);
                persona.IDPlan = int.Parse(this.idplanTextBox.Text);
            }
            return band;
        }

        private void SaveEntity(Personas persona)
        {
            this.Logic.Save(persona);
        }

        protected override void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.telefonoTextBox.Enabled = enable;
            this.legajoTextBox.Enabled = enable;
            this.fechanacTextBox.Enabled = enable;
            this.idplanTextBox.Enabled = enable;
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
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.fechanacTextBox.Text = string.Empty;
            this.idplanTextBox.Text = string.Empty;
        }

        protected void acceptaButton_Click(object sender, EventArgs e)
        {
            Boolean band = false;
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Personas();
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
                    this.Entity = new Personas();
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

            if ((int)Session["tipo_persona"] == 4)
            {
                Response.Redirect("LoginWeb.aspx");
            }
            else
            {
                Response.Redirect("MenuPrincipal.aspx");
            }
        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Persona.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}