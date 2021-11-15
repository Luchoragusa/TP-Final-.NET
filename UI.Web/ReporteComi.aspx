<%@ Page Title="Reporte Cursos" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="ReporteComi.aspx.cs" 
    Inherits="UI.Web.ReporteComi" 
%>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    

        <div class="reporte" align="Center">
            <asp:ScriptManager ID="ScriptManager" runat="server">
            </asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewerCurso" runat="server" Height="573px" Width="1117px">
            </rsweb:ReportViewer>
            <br />
            <br />
            <br />
             <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" OnClick="btnVolver_Click" Text="Volver al menu" Width="121px" />
            <br />
            <br />
         </div>
        

</asp:Content>