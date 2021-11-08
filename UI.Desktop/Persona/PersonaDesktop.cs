using System;
using System.Windows.Forms;
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        public PersonaDesktop(Usuario us)
        {
            InitializeComponent();
            try
            {
                this.Modo = ModoForm.Alta;
                usuarioNuevo.ID = us.ID;
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario usuarioNuevo = new Usuario();

        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public PersonaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PersonaLogic peLogic = new PersonaLogic();
            try
            {
                PersonaActual = new Personas();
                _peActual.ID = ID;
                PersonaActual = peLogic.GetOne(PersonaActual);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Personas _peActual;
        public Personas PersonaActual
        {
            get
            { return _peActual; }
            set
            { _peActual = value; }
        }
        public override void MapearDeDatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.txtIDUsuario.Text = this.usuarioNuevo.ID.ToString();
                this.txtIDUsuario.Enabled = false;
            }
            else   
            {
                this.txtID.Text = this.PersonaActual.ID.ToString();
                this.txtIDUsuario.Text = this.PersonaActual.IdUsuario.ToString();
                this.txtNombre.Text = this.PersonaActual.Nombre;
                this.txtApellido.Text = this.PersonaActual.Apellido;
                this.txtDireccion.Text = this.PersonaActual.Direccion;
                this.txtEmail.Text = this.PersonaActual.Email;
                this.txtTelefono.Text = this.PersonaActual.Telefono;
                this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
                this.txtFechaNacimiento.Text = this.PersonaActual.FechaNacimiento.ToString();
                this.cbTipoPersona.Text = this.PersonaActual.TipoPersona.ToString();
                this.txtIdPlan.Text = this.PersonaActual.IDPlan.ToString();
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnModo.Text = "Guardar";
                if (Modo == ModoForm.Modificacion)
                    this.txtID.Enabled = false;
            }
            else if (Modo == ModoForm.Baja)
            {
                this.btnModo.Text = "Eliminar";
                this.txtID.Enabled = false;
                this.txtIDUsuario.Enabled = false;
                this.txtNombre.Enabled = false;
                this.txtApellido.Enabled = false;
                this.txtDireccion.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtTelefono.Enabled = false;
                this.txtLegajo.Enabled = false;
                this.txtFechaNacimiento.Enabled = false;
                this.cbTipoPersona.Enabled = false;
                this.txtIdPlan.Enabled = false;
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                PersonaActual = new Personas();
                PersonaActual.State = BusinessEntity.States.New;
                PersonaActual.IdUsuario = usuarioNuevo.ID;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    PersonaActual.State = BusinessEntity.States.Modified;
                    this.txtID.Text = this.PersonaActual.ID.ToString();
                }
                this.PersonaActual.IdUsuario = int.Parse(this.txtIDUsuario.Text);
                this.PersonaActual.Nombre = this.txtNombre.Text;
                this.PersonaActual.Apellido = this.txtApellido.Text;
                this.PersonaActual.Direccion = this.txtDireccion.Text;
                this.PersonaActual.Email = this.txtEmail.Text;
                this.PersonaActual.Telefono = this.txtTelefono.Text;
                this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                this.PersonaActual.FechaNacimiento = DateTime.Parse(this.txtFechaNacimiento.Text);

                if (cbTipoPersona.Text == "Alumno")
                    this.PersonaActual.TipoPersona = Personas.TipoPersonas.Alumno;
                else if (cbTipoPersona.Text == "Docente")
                    this.PersonaActual.TipoPersona = Personas.TipoPersonas.Docente;
                else
                    this.PersonaActual.TipoPersona = Personas.TipoPersonas.Administrador;

                this.PersonaActual.IDPlan = int.Parse(this.txtIdPlan.Text);

            }

            if (this.Modo == ModoForm.Baja) PersonaActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) PersonaActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PersonaLogic peLogic = new PersonaLogic();
            try
            {
                peLogic.Save(PersonaActual);
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
            if (txtNombre.Text.Equals(String.Empty) || txtApellido.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Validaciones.validarTexto(txtNombre.Text))
            {
                Notificar("Nombre incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Validaciones.validarTexto(txtApellido.Text))    
            {
                Notificar("Apellido incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarMail(txtEmail.Text))
            {
                Notificar("Direccion de email Incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtTelefono.Text))
            {
                Notificar("Telefono Incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtLegajo.Text))
            {
                Notificar("Legajo Incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtIdPlan.Text))
            {
                Notificar("id Plan incorrecto ", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtIDUsuario.Text))
            {
                Notificar("ID de usuario incorrecto.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnModo_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
