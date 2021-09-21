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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

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
