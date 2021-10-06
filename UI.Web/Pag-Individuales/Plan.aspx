<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Plan.aspx.cs" Inherits="UI.Web.Pag_Individuales.Plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Plan</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="225px" Width="545px">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:BoundField HeaderText="IDEspecialidad" DataField="IDEspecialidad" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
         </asp:Panel>

            <asp:Panel ID="formPanel" Visible="False" runat="server">
                <asp:Label ID ="descipcionLabel" runat="server" Text="Descripcion: "></asp:Label>
                <asp:TextBox ID="descipcionTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="IDEspecialidadLabel" runat="server" Text="IDEspecialidad: "></asp:Label>
                <asp:TextBox ID="IDEspecialidadTextBox" runat="server"></asp:TextBox>
           
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
    </form>
</body>
</html>
