using System;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class Comisiones : Form
    {
        Usuario _u;
        Boolean _esAlumno = true;
        public Comisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
            this.dgvComisiones.ReadOnly = true;
            _esAlumno = false;
        }
        public Comisiones(Usuario usuario)
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
            this.dgvComisiones.ReadOnly = true;
            _u = usuario;
            tsbEditar.Enabled = false;
            tsbEliminar.Enabled = false;
            tsbNuevo.Enabled = false;
        }
        public void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            try
            {
                if (_esAlumno)
                    this.dgvComisiones.DataSource = cl.GetAllByAlumno(_u);
                else
                    this.dgvComisiones.DataSource = cl.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected ", "Ha habido un error interno:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionesDesktop formCDesktop = new ComisionesDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;

            ComisionesDesktop formCDesktop = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected ", "Ha habido un error interno: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;

            ComisionesDesktop formCDesktop = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
