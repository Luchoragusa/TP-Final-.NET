<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="UI.Web.Persona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Persona</title>
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
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="EMail" DataField="Email" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                        <asp:BoundField HeaderText="Telefono" DataField="Habilitado" />
                        <asp:BoundField HeaderText="ID-Plan" DataField="IDPlan" />
                        <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                        <asp:BoundField HeaderText="Fecha de nacimiento" DataField="FechaNacimiento" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
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
        <asp:TextBox ID="emailTextBox" runat="server" Width="124px"></asp:TextBox>
        <br />
        
         <asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <br />      

        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
        <br />    
            
        <asp:Label ID="idplanLabel" runat="server" Text="IDPlan: "></asp:Label>
        <asp:TextBox ID="idplanTextBox" runat="server" Width="37px"></asp:TextBox>
        <br />   
            
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server" Width="72px"></asp:TextBox>
        <br />     

        <asp:Label ID="fechanacLabel" runat="server" Text="FechaNac: "></asp:Label>
        <asp:TextBox ID="fechanacTextBox" runat="server"></asp:TextBox>
        <br />     
           
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
