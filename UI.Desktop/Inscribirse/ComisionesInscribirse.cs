using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Desktop.Inscribirse
{
    public partial class ComisionesInscribirse : Form
    {

        Business.Entities.Materia mate = new Business.Entities.Materia();
        Curso curso = new Curso();
        Alumnos_Inscripciones aluInsc = new Alumnos_Inscripciones();
        Usuario usuario = new Usuario();
        Personas persona = new Personas();

        public Business.Entities.Materia Mate { get => mate; set => mate = value; }
        public ComisionesInscribirse(Business.Entities.Materia mat, Usuario usu)
        {
            InitializeComponent();
            Mate = mat;
            usuario = usu;
            this.dgvComInscribirse.AutoGenerateColumns = true;
            this.dgvComInscribirse.ReadOnly = true;
        }

        public void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            try
            {
                this.dgvComInscribirse.DataSource = cl.GetAllMateriasCom(Mate);     //trae comisiones de la materia, donde cupo != 0 y año 2021
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComisionesInscribirse_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            Alumno_InscripcionLogic aluIL = new Alumno_InscripcionLogic();
            CursoLogic cursoL = new CursoLogic();
            PersonaLogic perL = new PersonaLogic();
            try
            {
                if (this.dgvComInscribirse.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Comision com = ((Comision)this.dgvComInscribirse.SelectedRows[0].DataBoundItem);

                    curso = cursoL.getByComision(com);      //trae el curso asociado a la comision
                    persona = perL.GetIDPersona(usuario);    //recuperar "id_persona" que es es igual a "id_alumno" 
                    aluInsc.IDCurso = curso.ID;
                    aluInsc.IDAlumno = persona.ID;
                    aluInsc.Condicion = "Cursando";
                    aluIL.Insert(aluInsc);
                    MessageBox.Show("Se inscribio correctamente", "Inscripcion a cursado", MessageBoxButtons.OK);
                    this.Dispose();
                }
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
    }
}
