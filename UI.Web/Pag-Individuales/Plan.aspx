<%@ Page Title="" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Plan.aspx.cs" 
    Inherits="UI.Web.Pag_Individuales.Plan" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
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
                <asp:Label ID ="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescripcion" runat="server" 
                    ControlToValidate="descripcionTextBox" 
                    ErrorMessage="Descripcion es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="IDEspecialidadLabel" runat="server" Text="IDEspecialidad: "></asp:Label>
                <asp:TextBox ID="IDEspecialidadTextBox" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidatorIdEspecialidad" runat="server" 
                    ControlToValidate="IDEspecialidadTextBox" 
                    ErrorMessage="ID Especialidad es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
           
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
