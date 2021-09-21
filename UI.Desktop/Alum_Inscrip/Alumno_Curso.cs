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
using Business.Entities.Entidades;
using Business.Logic;

namespace UI.Desktop.Alum_Inscrip
{
    public partial class Alumno_Curso : Form
    {
        Business.Entities.Curso cur;
        public Alumno_Curso(Business.Entities.Curso c)
        {
            InitializeComponent();
            cur = c;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar(cur);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlum_Incrip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           int ID = ((Alumnos_Inscripciones)this.dgvAlum_Incrip.SelectedRows[0].DataBoundItem).ID;

            Alum_InscripDesktop formAlum_Inscrip = new Alum_InscripDesktop(ID, ApplicationForm.ModoForm.Modificacion);
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
        private void Alum_Curso_Load(object sender, EventArgs e)
        {
            Listar(cur);
        }

        private void Listar(Business.Entities.Curso cur)
        {
            Alumno_InscripcionLogic ai = new Alumno_InscripcionLogic();
            try
            {
                this.dgvAlum_Incrip.DataSource = ai.GetAllByCurso(cur);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
