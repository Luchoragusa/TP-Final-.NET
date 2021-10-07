<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Materia.aspx.cs" Inherits="UI.Web.Pag_Individuales.Materia" %>

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

        <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="225px" Width="545px">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:BoundField HeaderText="Horas Semanales" DataField="HSSSemanales" />
                    <asp:BoundField HeaderText="Horas Totales" DataField="HSTotales" />
                    <asp:BoundField HeaderText="Id del Plan" DataField="IDPlan" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
         </asp:Panel>

            <asp:Panel ID="formPanel" Visible="False" runat="server">

                <asp:Label ID ="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescripcion" runat="server" 
                    ControlToValidate="descripcionTextBox" 
                    ErrorMessage="Descripcion es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
                <br />

                <asp:Label ID="HSSSemanalesLabel" runat="server" Text="Horas Semanales: "></asp:Label>
                <asp:TextBox ID="HSSSemanalesTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorHSSSemanales" runat="server" 
                    ControlToValidate="HSSSemanalesTextBox" 
                    ErrorMessage="Las Horas Semanales son obligatorias" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
                <br />

                <asp:Label ID="HSTotalesLabel" runat="server" Text="Horas Totales: "></asp:Label>
                <asp:TextBox ID="HSTotalesTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorHSTotales" runat="server" 
                    ControlToValidate="HSTotalesTextBox" 
                    ErrorMessage="Las Horas Totales son obligatorias" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
                <br />

                <asp:Label ID="IDPlanLabel" runat="server" Text="Id del Plan: "></asp:Label>
                <asp:TextBox ID="IDPlanTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorIDPlan" runat="server" 
                    ControlToValidate="IDPlanTextBox" 
                    ErrorMessage="ID Plan es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
                <br />

                <asp:Panel ID="formActionsPanel" runat="server">
                    <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                    <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </asp:Panel>

            </asp:Panel>

            <asp:Panel ID="gridActionsPanel" runat="server">
                <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
                <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
                <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
            </asp:Panel>
    </form>
</body>
</html>
