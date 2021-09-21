<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Usuarios</title>
        <style type="text/css">
            .auto-style1 {
                margin-bottom: 161px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
            </div>
            <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="225px" Width="545px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="EMail" DataField="EMail" />
                        <asp:BoundField HeaderText="Usuario" DataField="Usuario" />
                        <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </form>
    </body>
</html>
