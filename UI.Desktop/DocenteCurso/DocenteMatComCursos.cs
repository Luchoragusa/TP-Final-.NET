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
    public partial class DocenteMatComCursos : Form
    {
        Usuario docente = new Usuario();
        Business.Entities.Materia materia = new Business.Entities.Materia();
        Comision comision = new Comision();

        public DocenteMatComCursos(int idComision, Usuario doc, Business.Entities.Materia mat)
        {
            InitializeComponent();
            docente = doc;
            materia = mat;
            comision.ID = idComision;
            this.dgvDocenteMatComCur.AutoGenerateColumns = false;
            this.dgvDocenteMatComCur.ReadOnly = true;
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
                this.dgvDocenteMatComCur.DataSource = dcl.GetAllCursosDeLaComision(docente, materia, comision);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

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
