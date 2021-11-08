using Business.Entities.Entidades;
using Business.Logic.EntidadesLogic;
using System;
using System.Windows.Forms;

namespace UI.Desktop.RegistrarNotas
{
    public partial class Docente_Alumnos : Form
    {
        Business.Entities.Curso cur;
        public Business.Entities.Curso Curso { get => cur; set => cur = value; }
        public Docente_Alumnos(int id)
        {
            InitializeComponent();
            this.dgvDocente_Alumnos.AutoGenerateColumns = false;
            this.dgvDocente_Alumnos.ReadOnly = true;
            Curso = new Business.Entities.Curso();
            cur.ID = id;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar(cur);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Alum_Curso_Load(object sender, EventArgs e)
        {
            Listar(Curso);
        }
        private void Listar(Business.Entities.Curso cur)
        {
            Alumno_InscripcionLogic ai = new Alumno_InscripcionLogic();
            try
            {
                    this.dgvDocente_Alumnos.DataSource = ai.GetAllByCurso(cur);     //muestra los alumnos del curso
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocente_Alumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Alumnos_Inscripciones)this.dgvDocente_Alumnos.SelectedRows[0].DataBoundItem).ID;

            Editar_InscripcionDesktop formAlum_Inscrip = new Editar_InscripcionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formAlum_Inscrip.ShowDialog();
                this.Listar(cur);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al editar ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
