<%@ Page Title="Reporte Personas" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="ReportePersonas.aspx.cs" 
    Inherits="UI.Web.ReportePersonas" 
%>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    

        <div class="reporte" align="Center">
            <asp:ScriptManager ID="ScriptManager" runat="server">
            </asp:ScriptManager>
            <rsweb:ReportViewer ID="rvwrPersonass" runat="server" Height="573px" Width="1117px"></rsweb:ReportViewer>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
             <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" OnClick="btnVolver_Click" Text="Volver al menu" Width="121px" />
            <br />
            <br />
        </div>
</asp:Content>
