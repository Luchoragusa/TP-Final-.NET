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
    public partial class Usuarios : ApplicationFormWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //LoadGrid();

            //  esto fue lo q hice, linea 23, ppt 1.Unidad.5.Web.Parte1 diapo 31

            //puede ser que sea así: ?
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
            else
            {
                // 'UD ya ha repersonazado otro intento de ingreso anteriormente'
            }
        }

        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
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

        public Usuario Entity
        {
            get;
            set;
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            Boolean band = false;
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Usuario();
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
                        this.Entity = new Usuario();
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
            if(!band)
                this.formPanel.Visible = false;
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
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.nombreUsuarioTextBox.Text = string.Empty;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected override void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
        }

        private Boolean LoadEntity(Usuario usuario)
        {
            bool band = false;
                if (this.nombreTextBox.Text.Equals(string.Empty) ||
                                    this.apellidoTextBox.Text.Equals(string.Empty) ||
                                    this.emailTextBox.Text.Equals(string.Empty) ||
                                    this.nombreUsuarioTextBox.Text.Equals(string.Empty) ||
                                    this.claveTextBox.Text.Equals(string.Empty) ||
                                    this.repetirClaveTextBox.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    band = true;
                }
                else
                {
                    usuario.Nombre = this.nombreTextBox.Text;
                    usuario.Apellido = this.apellidoTextBox.Text;

                    if (!validarMail(this.emailTextBox.Text))
                    {
                        MessageBox.Show("Direccion de email Incorrecta.", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        band = true;
                    }
                    else { usuario.Email = this.emailTextBox.Text; }

                    usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;

                    if (this.claveTextBox.Text == this.repetirClaveTextBox.Text)
                    {
                        usuario.Clave = this.claveTextBox.Text;
                    }
                    else
                       {
                    MessageBox.Show("Las claves no coinciden.", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    band = true;
                    }
                    usuario.Habilitado = this.habilitadoCheckBox.Checked;
                }
            return band;
        }

        public static bool validarMail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected override void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }
    }
}