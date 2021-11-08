using Business.Entities;
using Business.Logic.EntidadesLogic;
using System;
using System.Windows.Forms;

namespace UI.Desktop.RegitrarDocenteCurso
{
    public partial class Cursos_Docente : Form
    {
        Usuario docente = new Usuario();
        public Usuario Docente { get => docente; set => docente = value; }
        Boolean _esDocente = false;
        public Cursos_Docente(Usuario doc)
        {
            InitializeComponent();
            Docente = doc;
            this.dgvCursosDocente.AutoGenerateColumns = false;
            this.dgvCursosDocente.ReadOnly = true;
            _esDocente = true;
        }
        public Cursos_Docente()
        {
            InitializeComponent();
            this.dgvCursosDocente.AutoGenerateColumns = false;
            this.dgvCursosDocente.ReadOnly = true;
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            try
            {
                if (_esDocente)
                    this.dgvCursosDocente.DataSource = dcl.getCursosDocente(docente);
                else
                    this.dgvCursosDocente.DataSource = dcl.GetAll();
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
            DICDesktop docente_alumnos = new DICDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                docente_alumnos.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursosDocente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Entidades.DocenteCurso)this.dgvCursosDocente.SelectedRows[0].DataBoundItem).ID;
            DICDesktop docente_alumnos = new DICDesktop(ID, ApplicationForm.ModoForm.Modificacion, _esDocente);
            try
            {
                docente_alumnos.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursosDocente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Entidades.DocenteCurso)this.dgvCursosDocente.SelectedRows[0].DataBoundItem).ID;
            DICDesktop docente_alumnos = new DICDesktop(ID, ApplicationForm.ModoForm.Baja, _esDocente);
            try
            {
                docente_alumnos.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cursos_Docente_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}