<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    CodeBehind="MenuPrincipal.aspx.cs" 
    Inherits="UI.Web.MenuPrincipal"%>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="MP1" %> 

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent1" runat="server">
    <uc1:MP1 runat="server" id="MP2"/> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="server">
    

 <style type ="text/css">
.margin{
    margin-top:20px;    
    margin-bottom:20px;
}

.themeBtn {
    background: #ff5c00;
    color: #ffffff !important;
    display: inline-block;
    font-size: 15px;
    font-weight: 500;
    height: 50px;
    line-height: 0.8;
    padding: 18px 30px;
    text-transform: capitalize;
    border-radius: 1px;
    letter-spacing: 0.5px;
	border:0px !important;
	cursor:pointer;
	border-radius:100px;

}
a:hover{
    color: #ffffff;
    text-decoration:none;
}
.themeBtn:hover {
    background: rgb(255, 92, 0);
    color: #ffffff;
    box-shadow: 0 10px 25px -2px rgba(255, 92, 0, 0.6);
}
</style>
    <head>
        <title>Menu Principal</title>
    </head>
    
     <div class="d-grid gap-2 col-2 mx-auto" align="center">
            <br />
            <br />
            <asp:Label ID="lblAlumno" runat="server" Text="Alumno" Font-Names="Century Gothic" Font-Bold="True"></asp:Label>
            <br />
            <asp:Button ID="btnComision" runat="server" Text="Comision" BackColor="#33CCCC" OnClick="btnComision_Click" Font-Names="Century Gothic" class="themeBtn" Font-Bold="True" Font-Overline="False" Height="55px" />
&nbsp;
            &nbsp;
            <asp:Button ID="btnMateria" runat="server" OnClick="btnMateria_Click" Text="Materia" BackColor="#33CCCC" Font-Names="Century Gothic" class="themeBtn" Font-Bold="True" Height="55px"/>
            <br />
            <asp:Button ID="btnInscripciones" runat="server" BackColor="#33CCCC" OnClick="btnInscripciones_Click" Text="Inscripciones" Width="184px" Font-Names="Century Gothic" class="themeBtn" Font-Bold="True" Height="55px"/>
&nbsp;
            <asp:Button ID="btnInscribirseACursado" runat="server" BackColor="#33CCCC" OnClick="btnInscribirseACursado_Click" Text="Inscribirse a Cursado" Width="232px" Font-Names="Century Gothic" class="themeBtn" Font-Bold="True" Height="55px"/>
            <br />
            <br />
            <asp:Label ID="lblDocente" runat="server" Text="Docente" Font-Names="Century Gothic" Font-Bold="True"></asp:Label>
            <br />
            <asp:Button ID="btnDocenteCurso"  runat="server" Text="Cursos del docente" OnClick="btnProfesor_Click" Width="211px" BackColor="#9999FF" Font-Names="Century Gothic" Font-Bold="True" Height="55px"  class="themeBtn"/>
            &nbsp;&nbsp;
            <asp:Button ID="btnRegistrarNota" runat="server" Text="Registrar Nota" Width="185px" BackColor="#9999FF" OnClick="btnRegistrarNota_Click" Font-Names="Century Gothic" Font-Bold="True" Height="55px" class="themeBtn"/>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblReportes" runat="server" Text="Reportes" Font-Bold="True" Font-Names="Century Gothic"></asp:Label>
            <br />
            <asp:Button ID="btnReporteAlumno" runat="server" BackColor="#99CC00" OnClick="btnReporteAlumno_Click" Text="Reporte Personas" Width="210px" Font-Names="Century Gothic" Font-Bold="True" Height="55px" class="themeBtn"/>
&nbsp;
            <asp:Button ID="btnReporteComision" runat="server" BackColor="#99CC00" OnClick="btnReporteComision_Click" Text="Reporte Cursos" Font-Names="Century Gothic" Font-Bold="True" Height="55px" class="themeBtn" Width="210px"/>
            <br />
            <br />
            <asp:Label ID="lblAdmin" runat="server" Text="Admin" Font-Bold="True" Font-Names="Century Gothic"></asp:Label>
            <br />
            <asp:Button ID="btnEspecialidad" runat="server" Text="Especialidad" Width="169px" BackColor="#FFCC66" OnClick="btnEspecialidad_Click" Font-Names="Century Gothic" Font-Bold="True" Height="55px" class="themeBtn"/>
            &nbsp;
            <asp:Button ID="btnCurso" runat="server" BackColor="#FFCC66" OnClick="btnCurso_Click" Text="Curso" Font-Names="Century Gothic" Font-Bold="True" Height="55px" class="themeBtn"/>
            <br />
            <br />
            <asp:Button ID="btnCerrarSesion"  runat="server" Text="Cerrar Sesión"  a OnClick="btnCerrarSesion_Click" BackColor="#FF6600" Font-Names="Century Gothic" Font-Bold="True" Height="55px" class="themeBtn" Width="170px"/>
        </div>
    </asp:Content>

