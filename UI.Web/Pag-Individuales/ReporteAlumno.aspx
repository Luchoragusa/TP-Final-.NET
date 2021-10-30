﻿<%@ Page Title="Reporte Alumno" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="ReporteAlumno.aspx.cs" 
    Inherits="UI.Web.Pag_Individuales.ReporteAlumno" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
            SelectedRowStyle-BackColor="Darkgray"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            
            <Columns>
                <asp:BoundField HeaderText="ID de Alumno" DataField="ID" />
                <asp:BoundField HeaderText="ID de Curso" DataField="IDCurso" />
                <asp:BoundField HeaderText="Notas" DataField="Nota" />                
            </Columns>
            
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
    </asp:Panel>

    <asp:Button ID="btnDescargarPDF" runat="server" OnClick="btnDescargarPDF_Click" Text="Descargar PDF" />

</asp:Content>
