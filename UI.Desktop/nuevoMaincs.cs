using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class nuevoMaincs : Form
    {
        public nuevoMaincs()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelAluSubMenu.Visible = false;
            panelDocSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }


        private void esconderSubMenu()
        {
            if (panelAluSubMenu.Visible == true)
                panelAluSubMenu.Visible = false;
            if (panelDocSubMenu.Visible == true)
                panelDocSubMenu.Visible = false;
            if (panelAdminSubMenu.Visible == true)
                panelAdminSubMenu.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAlu_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAluSubMenu); //falta conceder permisos para que solo se vea el menu de alumno si inicio secion alumno, lo mismo con los otros dos
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelDocSubMenu);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAdminSubMenu);
        }
    }
}
