<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="UI.Web.Pag_Individuales.Curso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="gridPanel" runat="server" Height="143px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
               <Columns>
                        <asp:BoundField HeaderText="AnioCalendario" DataField="AnioCalendario" />
                        <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
                        <asp:BoundField HeaderText="IDComision" DataField="IDComision" />
                        <asp:BoundField HeaderText="IDMateria" DataField="IDMateria" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
               </Columns>

                </asp:GridView>
            </asp:Panel>

        

        
            <asp:Panel ID="formPanel" Visible="False" runat="server">
        
         <asp:Label ID ="anioCalendarioLabel" runat="server" Text="anioCalendario: "></asp:Label>
        <asp:TextBox ID="anioCalendarioTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="cupoLabel" runat="server" Text="cupo: "></asp:Label>
        <asp:TextBox ID="cupoTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="idComisionLabel" runat="server" Text="idComision: "></asp:Label>
        <asp:TextBox ID="idComisionTextBox" runat="server" Width="40px"></asp:TextBox>
        <br />
                <asp:Label ID="idMateriaLabel" runat="server" Text="idMateria: "></asp:Label>
        <asp:TextBox ID="idMateriaTextBox" runat="server" Width="40px"></asp:TextBox>
        <br />
                <asp:Label ID="descripcionLabel" runat="server" Text="descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server" Width="40px"></asp:TextBox>
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
