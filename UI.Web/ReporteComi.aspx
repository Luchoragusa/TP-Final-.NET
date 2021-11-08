<%@ Page Title="Reporte Comi" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="ReporteComi.aspx.cs" 
    Inherits="UI.Web.ReporteComi" 
%>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    

        <asp:ScriptManager ID="ScriptManager" runat="server">
        </asp:ScriptManager> 
        <div class="reporte" Align="center">
            <rsweb:ReportViewer ID="ReportViewerCurso" runat="server" Height="922px" Width="1144px">
            </rsweb:ReportViewer>
            <br />
            <br />
                <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" OnClick="btnVolver_Click" style="margin-bottom: 0px" Text="Volver al menu" Width="121px" />
                <br />
            <br />
            <br />
            <br />
        </div>
        

        </asp:Content>