<%@ Page Title="Plan" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Plan.aspx.cs" 
    Inherits="UI.Web.Pag_Individuales.Plan" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div>
        </div>

        <asp:Panel ID="gridPanel" runat="server" Height="225px" Width="545px">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"  HorizontalAlign="Center"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:BoundField HeaderText="IDEspecialidad" DataField="IDEspecialidad" />
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
           
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="false">
            <asp:Button ID="aceptarButton" runat="server" class="btn btn-outline-primary" Text="Aceptar" OnClick="acceptaButton_Click" />
            &nbsp;
            <asp:Button ID="cancelarButton" runat="server" class="btn btn-outline-primary" Text="Cancelar" OnClick="cancelarButton_Click" style="height: 26px" />
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
