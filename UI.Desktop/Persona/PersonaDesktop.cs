using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities.Entidades;
using Business.Logic.EntidadesLogic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PersonaDesktop : UI.Desktop.ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }
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
                //PersonaActual = peLogic.GetOne(ID);
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
            this.txtID.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtEmail.Text = this.PersonaActual.Email;
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.txtFechaNacimiento.Text = this.PersonaActual.FechaNacimiento.ToLongDateString();
            this.txtTipoPersona.Text = this.PersonaActual.TipoPersona.ToString();
            this.txtIdPlan.Text = this.PersonaActual.IDPlan.ToString();

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
                PersonaActual = new Personas();
                PersonaActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    PersonaActual.State = BusinessEntity.States.Modified;
                    this.txtID.Text = this.PersonaActual.ID.ToString();
                }
                this.PersonaActual.Nombre = this.txtNombre.Text;
                this.PersonaActual.Apellido = this.txtApellido.Text;
                this.PersonaActual.Direccion = this.txtDireccion.Text;
                this.PersonaActual.Email = this.txtEmail.Text;
                this.PersonaActual.Telefono = this.txtTelefono.Text;
                this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                this.PersonaActual.FechaNacimiento = DateTime.Parse(this.txtFechaNacimiento.Text);
                this.PersonaActual.TipoPersona = (Business.Entities.Entidades.Personas.TipoPersonas)int.Parse(this.txtTipoPersona.Text);
                this.PersonaActual.IDPlan = int.Parse(this.txtIdPlan.Text);

            }

            if (this.Modo == ModoForm.Baja) PersonaActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) PersonaActual.State = BusinessEntity.States.Unmodified;
        }

        //FALTA GUARDARCAMBIOS  VALIDAR  BTN ACEPTAR Y BTNCANCELAR
    }
}
