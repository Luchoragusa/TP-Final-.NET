<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comision.aspx.cs" Inherits="UI.Web.Pag_Individuales.Comision" %>

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
                        <asp:BoundField HeaderText="ID-Plan" DataField="IDPlan" />
                        <asp:BoundField HeaderText="DescComision" DataField="DescComision" />
                        <asp:BoundField HeaderText="AnioEspecialidad" DataField="AnioEspecialidad" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
               </Columns>

                </asp:GridView>
            </asp:Panel>






        
            <asp:Panel ID="formPanel" Visible="False" runat="server">
        
         <asp:Label ID ="idPlanLabel" runat="server" Text="IDPlan: "></asp:Label>
        <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="descComisionLabel" runat="server" Text="descComision: "></asp:Label>
        <asp:TextBox ID="descComisionTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="anioEspecialidadLabel" runat="server" Text="anioEspecialidad: "></asp:Label>
        <asp:TextBox ID="anioEspecialidadTextBox" runat="server" Width="40px"></asp:TextBox>
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
