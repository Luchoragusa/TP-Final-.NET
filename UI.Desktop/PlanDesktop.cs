using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PlanDesktop : UI.Desktop.ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo)
        {
            this.Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usLogic = new UsuarioLogic();
            //planActual = usLogic.GetOne(ID);
            MapearDeDatos();
        }

        private Plan _plan;
        public Plan PlanActual
        {
            get { return _plan; }
            set { _plan = value; }
        }





    }
}
