﻿<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    CodeBehind="MenuPrincipal.aspx.cs" 
    Inherits="UI.Web.MenuPrincipal" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">

     <div class="d-grid gap-2 col-2 mx-auto" align="center">
            ¡<asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido al Sistema"></asp:Label>
            !&nbsp;
            &nbsp;
            <br />
            <br />
            <asp:Label ID="lblAlumno" runat="server" Text="Alumno"></asp:Label>
            <br />
            <asp:Button ID="btnComision" runat="server" Text="Comision" BackColor="#33CCCC" OnClick="btnComision_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCursoAlumno" runat="server" Text="Curso" Width="62px" BackColor="#33CCCC" OnClick="btnCursoAlumno_Click" />
            &nbsp;
            <asp:Button ID="btnPersonaAlumno" runat="server" BackColor="#33CCCC" OnClick="btnPersonaAlumno_Click" Text="Persona Alumno" Width="121px" />
            <br />
            <asp:Button ID="btnInscripciones" runat="server" BackColor="#33CCCC" OnClick="btnInscripciones_Click" Text="Inscripciones" Width="96px" />
&nbsp;
            <asp:Button ID="btnInscribirseACursado" runat="server" BackColor="#33CCCC" OnClick="btnInscribirseACursado_Click" Text="Inscribirse a Cursado" Width="152px" />
            <br />
            <br />
            <asp:Label ID="lblDocente" runat="server" Text="Docente"></asp:Label>
            <br />
            <asp:Button ID="btnDocenteCurso" class="btn btn-outline-primary btn-lg" runat="server" Text="Inscribirse a un curso" OnClick="btnProfesor_Click" Width="135px" BackColor="#9999FF" />
            &nbsp;&nbsp;
            <asp:Button ID="btnRegistrarNota" runat="server" Text="Registrar Nota" Width="108px" BackColor="#9999FF" OnClick="btnRegistrarNota_Click" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblReportes" runat="server" Text="Reportes"></asp:Label>
            <br />
            <asp:Button ID="btnReporteAlumno" runat="server" BackColor="#99CC00" OnClick="btnReporteAlumno_Click" Text="Reporte Alumno" />
&nbsp;
            <asp:Button ID="btnReporteComision" runat="server" BackColor="#99CC00" OnClick="btnReporteComision_Click" Text="Reporte Comision" />
            <br />
            <br />
            <asp:Label ID="lblAdmin" runat="server" Text="Admin"></asp:Label>
            <br />
            <asp:Button ID="btnEspecialidad" runat="server" Text="Especialidad" Width="98px" BackColor="#FFCC66" OnClick="btnEspecialidad_Click" />
            <br />
            <br />
            <asp:Button ID="btnCerrarSesion" CssClass="btn btn-danger btn-lg" runat="server" Text="Cerrar Sesión"  a OnClick="btnCerrarSesion_Click" BackColor="#FF6600" BorderColor="#990000" />
        </div>

</asp:Content>
