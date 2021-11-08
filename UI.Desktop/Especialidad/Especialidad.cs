using System;
using System.Windows.Forms;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Especialidad : Form
    {
        public Especialidad()
        {
            InitializeComponent();
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.ReadOnly = true;
        }
        public void Listar()
        {
            EspecialidadLogic ul = new EspecialidadLogic();
            this.dgvEspecialidades.AutoGenerateColumns = false;
            try
            {
                this.dgvEspecialidades.DataSource = ul.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error", "Error al recuperar lista de especialidades" + Ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Especialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop formPDesktop = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formPDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;

            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formEspecialidad.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;

            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formEspecialidad.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
