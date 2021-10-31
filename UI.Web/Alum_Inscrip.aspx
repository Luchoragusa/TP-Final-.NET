<%@ Page Title="AlumnoInscripcion" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Alum_Inscrip.aspx.cs" 
    Inherits="UI.Web.Alum_Inscrip" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div dir="ltr">
        </div>
        <asp:Panel ID="gridPanel" runat="server" Height="216px" Width="1498px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    
                    <Columns>
                        <asp:BoundField HeaderText="ID-Curso" DataField="IDCurso" />
                        <asp:BoundField HeaderText="ID-Alumno" DataField="IDAlumno" />
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
        </asp:Panel>

     <asp:Panel ID="formPanel" Visible="False" runat="server">
        
         <asp:Label ID ="idcursoLabel" runat="server" Text="IDCurso: "></asp:Label>
        <asp:TextBox ID="idcursoTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="idalumnoLabel" runat="server" Text="IDAlumno: "></asp:Label>
        <asp:TextBox ID="idalumnoTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="notaLabel" runat="server" Text="Nota: "></asp:Label>
        <asp:TextBox ID="notaTextBox" runat="server" Width="40px"></asp:TextBox>
        <br />
        
         <asp:Label ID="condicionLabel" runat="server" Text="Condicion: "></asp:Label>
        <asp:TextBox ID="condicionTextBox" runat="server"></asp:TextBox>
        <br />      
           
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="false">
            <asp:Button ID="aceptarButton" runat="server" class="btn btn-outline-primary" Text="Aceptar" OnClick="acceptaButton_Click" Width="72px" />
            &nbsp;
            <asp:Button ID="cancelarButton" runat="server" class="btn btn-outline-primary" Text="Cancelar" OnClick="cancelarButton_Click" />
        </asp:Panel>
        
     </asp:Panel>

        <asp:Panel ID="gridActionsPanel" runat="server" HorizontalAlign="Center">
            <div class="container" style="background-color: darkgray">
                <div class="jumbotron text-center">
                <p class="fs-5">
                    <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
                </p>
                </div>
            </div>
        </asp:Panel>

</asp:Content>
