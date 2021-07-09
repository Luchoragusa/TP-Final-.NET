using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : UI.Desktop.ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usLogic = new UsuarioLogic();
            UsuarioActual = usLogic.GetOne(ID);
            MapearDeDatos();
        }

        private Usuario _usActual;
        public Usuario UsuarioActual
        {
            get
            { return _usActual; }
            set
            { _usActual = value; }
        }


        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtEmail.Text = this.UsuarioActual.Email;    
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;              

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnModo.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                this.btnModo.Text = "Eliminar";
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.btnModo.Text = "Aceptar";
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                UsuarioActual = new Usuario();
                UsuarioActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    UsuarioActual.State = BusinessEntity.States.Modified;
                    this.txtID.Text = this.UsuarioActual.ID.ToString();          
                }
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtConfClave.Text;
            }

            if (this.Modo == ModoForm.Baja) UsuarioActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) UsuarioActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            usuarioLogic.Save(UsuarioActual);
        }
        public override bool Validar()
        {
            if (
                txtNombre.Text.Equals(String.Empty) ||
                txtApellido.Text.Equals(String.Empty) ||
                txtEmail.Text.Equals(String.Empty) ||
                txtUsuario.Text.Equals(String.Empty) ||
                txtClave.Text.Equals(String.Empty) ||
                txtConfClave.Text.Equals(String.Empty)
                )
            {
                Notificar("Alguno de los campos esta incompleto", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarTexto(txtNombre.Text))
            {
                Notificar("Nombre incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarTexto(txtApellido.Text))
            {
                Notificar("Apellido incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.EsMailValido(txtEmail.Text))
            {
                Notificar("Mail invalido", "Intente nuevamente.",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarTexto(txtUsuario.Text))
            {
                Notificar("Nombre de Usuario incorrecto.", "Intente nuevamente. Recuerde que no puede llevar numeros.",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.validarClave(txtClave.Text))     
            {
                Notificar("Contraseña invalida.", "Intente nuevamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!Validaciones.Clave_Conf(txtClave.Text, txtConfClave.Text))
                {
                    Notificar("Contraseñas no coinciden.", "Intente nuevamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void botonAceptarClick(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }
        private void botonCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
