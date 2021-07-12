using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.ReadOnly = true;
        }

        public void Listar()
        {
            MateriaLogic mat = new MateriaLogic();
            this.dgvMaterias.DataSource = mat.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            MateriaDesktop formMDesktop = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formPlan = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Plan)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formPlan = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
            formPlan.ShowDialog();
            this.Listar();
        }
    }
}
