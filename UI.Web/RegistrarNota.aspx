<%@ Page Title="AlumnoInscripcion" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="RegistrarNota.aspx.cs" 
    Inherits="UI.Web.RegistrarNota" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblCursosDelDocente" runat="server" Text="Cursos asignados del docente:"></asp:Label>
        <br />
               <asp:GridView ID="gridViewCursosDelDocente" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                   <asp:BoundField HeaderText="ID del Curso" DataField="ID" />
                        <asp:BoundField HeaderText="AnioCalendario" DataField="AnioCalendario" />
                        <asp:BoundField HeaderText="IDComision" DataField="IDComision" />   
                        <asp:BoundField HeaderText="Cupo" DataField="IDComision" />                                         
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />                                                
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

        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="lblAlumnosAsignados" runat="server" Text="Alumnos asignados al curso:"></asp:Label>
                 <asp:GridView ID="gridViewAlumnosDelCursoDelDocente" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="AnioCalendario" />
                        <asp:BoundField HeaderText="Apellido" DataField="Cupo" />
                        <asp:BoundField HeaderText="Nota" DataField="Nota" />
                        <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
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
                            <br />
                            <br />
                            <br />
        </asp:Panel>
    </asp:Panel>              

</asp:Content>
