using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Desktop.DocenteCurso
{
    public partial class DocenteMateria : Form
    {
        Usuario docente;
        public DocenteMateria(Usuario us)
        {
            InitializeComponent();
            this.dgvDocenteCurso.AutoGenerateColumns = false;
            this.dgvDocenteCurso.ReadOnly = true;
            docente = us;
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            try
            {
                this.dgvDocenteCurso.DataSource = dcl.GetAllMateriasDelDocente(docente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            DICDesktop formDCDesktop = new DICDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formDCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (this.dgvDocenteCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Business.Entities.Materia)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID;

            DocenteComision materias_comision = new DocenteComision(ID, docente);

            //DCDesktop formDC = new DCDesktop(ID, ApplicationForm.ModoForm.Modificacion);

            try
            {
                //formDC.ShowDialog();
                materias_comision.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocenteCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Entidades.DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID;

            DICDesktop formDC = new DICDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formDC.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
