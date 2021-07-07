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
using Business.Logic;

namespace UI.Desktop
{
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
            this.dgvPlanes.ReadOnly = true;
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvPlanes.DataSource = ul.GetAll();
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
