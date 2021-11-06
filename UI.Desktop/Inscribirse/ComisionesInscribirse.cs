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
        public Business.Entities.Materia Mate { get => mate; set => mate = value; }
        public ComisionesInscribirse(Business.Entities.Materia mat)
        {
            InitializeComponent();
            Mate = mat;
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
    }
}
