using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            MapearDeDatos();
        }
        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic mat = new MateriaLogic();
            try
            {
                MateriaActual = new Business.Entities.Materia();
                _materia.ID = ID;
                MateriaActual = mat.GetOne(MateriaActual);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Business.Entities.Materia _materia;
        public Business.Entities.Materia MateriaActual
        {
            get
            { return _materia; }
            set
            { _materia = value; }
        }  
        public override void MapearDeDatos()
        {
            if(Modo == ModoForm.Alta)
                this.btnModo.Text = "Aceptar";
            else
            {
                this.txtID.Text = this.MateriaActual.ID.ToString();
                this.txtIDPlan.Text = this.MateriaActual.IDPlan.ToString();
                this.txtDesc.Text = this.MateriaActual.Descripcion;
                this.txtHSSemanales.Text = this.MateriaActual.HSSSemanales.ToString();
                this.txtHSTotales.Text = this.MateriaActual.HSTotales.ToString();

                if (Modo == ModoForm.Modificacion) this.btnModo.Text = "Guardar";
                else if (Modo == ModoForm.Baja)
                {
                    this.btnModo.Text = "Eliminar";

                    this.txtID.Enabled = false;
                    this.txtIDPlan.Enabled = false;
                    this.txtDesc.Enabled = false;
                    this.txtHSSemanales.Enabled = false;
                    this.txtHSTotales.Enabled = false;
                }
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                MateriaActual = new Business.Entities.Materia();
                MateriaActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta)
                {
                    MateriaActual.State = BusinessEntity.States.Modified;
                    this.txtID.Text = this.MateriaActual.ID.ToString();
                }
                this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text);  // OJO que tiene que ser de algun plan ya creado
                this.MateriaActual.Descripcion = this.txtDesc.Text;
                this.MateriaActual.HSSSemanales = Convert.ToInt32(this.txtHSSemanales.Text);
                this.MateriaActual.HSTotales = Convert.ToInt32(this.txtHSTotales.Text);
            }

            if (this.Modo == ModoForm.Baja) MateriaActual.State = BusinessEntity.States.Deleted;
            if (this.Modo == ModoForm.Consulta) MateriaActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic materiaLogic = new MateriaLogic();
            try
            {
                materiaLogic.Save(MateriaActual);
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
            if (txtDesc.Text.Equals(String.Empty) || txtIDPlan.Text.Equals(String.Empty) || lblHSTotales.Text.Equals(String.Empty) || txtHSSemanales.Text.Equals(String.Empty))
            {
                Notificar("Algunos de los campos están vaciós", "Complete todos para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtIDPlan.Text))
            {
                Notificar("ID incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtHSSemanales.Text))
            {
                Notificar("ID incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.validarTexto(txtHSTotales.Text))
            {
                Notificar("ID incorrecta.", "Intente nuevamente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnModo_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
