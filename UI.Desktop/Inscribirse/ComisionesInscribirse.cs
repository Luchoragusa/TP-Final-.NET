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

namespace UI.Desktop.Inscribirse
{
    public partial class ComisionesInscribirse : Form
    {

        Business.Entities.Materia mate = new Business.Entities.Materia();
        Business.Entities.Curso curso = new Business.Entities.Curso();
        Alumnos_Inscripciones aluInsc = new Alumnos_Inscripciones();
        Business.Entities.Usuario alumno = new Business.Entities.Usuario();

        public Business.Entities.Materia Mate { get => mate; set => mate = value; }
        public ComisionesInscribirse(Business.Entities.Materia mat, Business.Entities.Usuario alu)
        {
            InitializeComponent();
            Mate = mat;
            alumno = alu;
            this.dgvComInscribirse.AutoGenerateColumns = true;
            this.dgvComInscribirse.ReadOnly = true;
        }

        public void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            try
            {
                this.dgvComInscribirse.DataSource = cl.GetAllMateriasCom(Mate);
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
            try
            {
                curso = cursoL.getByMateria(Mate);
                aluInsc.IDCurso = curso.ID;
                aluInsc.IDAlumno = alumno.ID;
                aluIL.Insert(aluInsc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
