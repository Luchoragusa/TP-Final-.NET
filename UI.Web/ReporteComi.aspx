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
            <rsweb:ReportViewer ID="ReportViewerCurso" runat="server" Height="367px" Width="550px">
            </rsweb:ReportViewer>
            <br />
            <br />
            <br />
        </div>
        

        <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center">
            <asp:Panel ID="Panel5" runat="server">
            </asp:Panel>
            <asp:Panel ID="Panel6" runat="server">
                <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" OnClick="btnVolver_Click" style="margin-bottom: 0px" Text="Volver al menu" Width="121px" />
                <br />
            </asp:Panel>
             </asp:Panel>
   

</asp:Content>