using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic.EntidadesLogic;
using UI.Desktop.RegistrarNotas;

namespace UI.Desktop.DocenteCurso
{
    public partial class DcoenteCursos : Form
    {
        Usuario docente = new Usuario();
        Business.Entities.Materia materia = new Business.Entities.Materia();
        Comision comision = new Comision();

        public DcoenteCursos(int idComision, Usuario doc, Business.Entities.Materia mat)
        {
            InitializeComponent();
            docente = doc;
            materia = mat;
            comision.ID = idComision;
            this.dgvCursosDocente.AutoGenerateColumns = false;
            this.dgvCursosDocente.ReadOnly = true;
        }

        private void DocenteMatComCursos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            try
            {
                this.dgvCursosDocente.DataSource = dcl.GetAllCursosDeLaComision(docente, materia, comision);
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

        private void tsbSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursosDocente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Curso)this.dgvCursosDocente.SelectedRows[0].DataBoundItem).ID;

            Docente_Alumnos docente_alumnos = new Docente_Alumnos(ID);

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
    }
}
