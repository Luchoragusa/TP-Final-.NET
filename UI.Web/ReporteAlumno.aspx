<%@ Page Title="Reporte Alumno" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="ReporteAlumno.aspx.cs" 
    Inherits="UI.Web.ReporteAlumno" 
%>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    

        <asp:ScriptManager ID="ScriptManager" runat="server">
        </asp:ScriptManager> 
        <div class="reporte" Align="Center">
            <rsweb:ReportViewer ID="rvwrAlumnos" runat="server" Height="276px" Width="535px"></rsweb:ReportViewer>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel5" runat="server" Height="45px">
            </asp:Panel>
        </div>
        

        <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center" Height="30px" style="margin-bottom: 62px">
        <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" Text="Volver al menu" Width="121px" OnClick="btnVolver_Click" />
             <br />
            <br />
            <br />
             </asp:Panel>
   

</asp:Content>
