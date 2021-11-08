using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            MapearDeDatos();
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usLogic = new UsuarioLogic();
            try
            {
                UsuarioActual = new Usuario();
                _usActual.ID = ID;
                UsuarioActual = usLogic.GetOne(UsuarioActual);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }  
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
            if (Modo != ModoForm.Alta)
            {
                this.txtID.Text = this.UsuarioActual.ID.ToString();
                this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
                this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
                this.txtClave.Text = this.UsuarioActual.Clave;
                this.txtConfClave.Text = this.UsuarioActual.Clave;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnModo.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                this.btnModo.Text = "Eliminar";
                this.txtID.Enabled = false;
                this.chkHabilitado.Enabled = false;
                this.txtUsuario.Enabled = false;
                this.txtConfClave.Enabled = false;
                this.txtClave.Enabled = false;
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
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            }

            if (this.Modo == ModoForm.Baja) UsuarioActual.State = BusinessEntity.States.Deleted;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            try
            {
                usuarioLogic.Save(UsuarioActual);
                MessageBox.Show("La operacion se realizo correctamente", "Informacion", MessageBoxButtons.OK);
                this.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public override bool Validar()
        {
            if (
                txtUsuario.Text.Equals(String.Empty) ||
                txtClave.Text.Equals(String.Empty)
                )
            {
                Notificar("Alguno de los campos esta incompleto", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validaciones.validarTexto(txtUsuario.Text))
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
            if (!Validaciones.validarClave(txtConfClave.Text))
            {
                Notificar("Contraseña invalida.", "Intente nuevamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(txtClave.Text == txtConfClave.Text))
            {
                Notificar("Contraseña invalida.", "Son distintas",
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
    }
}
