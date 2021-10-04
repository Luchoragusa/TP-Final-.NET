using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //LoadGrid();

            //  esto fue lo q hice, linea 23, ppt 1.Unidad.5.Web.Parte1 diapo 31

            //puede ser que sea así: ?
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
            else
            {
                // 'UD ya ha realizado otro intento de ingreso anteriormente'
            }
        }

        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }
    }
}