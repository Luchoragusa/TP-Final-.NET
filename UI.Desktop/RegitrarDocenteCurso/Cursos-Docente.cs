using Business.Entities;
using Business.Logic.EntidadesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.RegistrarNotas;

namespace UI.Desktop.RegitrarDocenteCurso
{
    public partial class Cursos_Docente : Form
    {
        Usuario docente = new Usuario();
        Business.Entities.Materia materia = new Business.Entities.Materia();
        Comision comision = new Comision();

        public Cursos_Docente(int idComision, Usuario doc, Business.Entities.Materia mat)
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

        private void tsbIngresar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursosDocente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Business.Entities.Curso)this.dgvCursosDocente.SelectedRows[0].DataBoundItem).ID;

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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}