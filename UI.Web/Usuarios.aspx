<%@ Page Title="Usuarios" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Usuarios.aspx.cs" 
    Inherits="UI.Web.Usuarios" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
            <div>
            </div>
            <asp:Panel ID="gridPanel" runat="server" Height="225px" Width="1266px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="EMail" DataField="Email" />
                        <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                        <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
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
            </asp:Panel>
    
    <asp:Panel ID="formPanel" Visible="False" runat="server">
        <asp:Label ID ="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
        <asp:CheckBox ID="habilitadoCheckBox" runat="server" />
        <br />
        <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir clave: ">
        </asp:Label>
        <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server">
        </asp:TextBox>
           
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
</asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

</asp:Content>
