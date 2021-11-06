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
    public partial class DocenteMaterias_Comision : Form
    {
        Usuario docente = new Usuario();
        Business.Entities.Materia materia = new Business.Entities.Materia();


        public DocenteMaterias_Comision(int idMateria, Usuario docent)
        {
            InitializeComponent();
            docente = docent;
            materia.ID = idMateria;
            this.dgvDocenteMateriasCom.AutoGenerateColumns = false;
            this.dgvDocenteMateriasCom.ReadOnly = true;
        }

        private void DocenteMaterias_Comision_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            try
            {
                this.dgvDocenteMateriasCom.DataSource = dcl.GetAllComisionesDeLasMateriasDelDocente(docente, materia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvDocenteMateriasCom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Business.Entities.Comision)this.dgvDocenteMateriasCom.SelectedRows[0].DataBoundItem).ID;

            //DocenteMatComCursos comision_cursos = new DocenteMatComCursos(ID, _docente.ID, _materia.ID);

            try
            {
                //comision_cursos.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
