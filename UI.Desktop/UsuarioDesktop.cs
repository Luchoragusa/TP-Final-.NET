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
            MapearADatos();
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
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtConfClave.Text = this.UsuarioActual.Clave;                  //va?

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
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    UsuarioActual.State = BusinessEntity.States.Modified;
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
            if (!txtClave.Text.Equals(txtConfClave.Text))
            {
                Notificar("ContraseÃ±a invalida", "Intente nuevamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }


    }
}
