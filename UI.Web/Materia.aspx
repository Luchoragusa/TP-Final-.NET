<%@ Page Title="Materia" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Materia.aspx.cs" 
    Inherits="UI.Web.Materia" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div>
        </div>

        <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="225px" Width="1513px">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"  HorizontalAlign="Center"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:BoundField HeaderText="Horas Semanales" DataField="HSSSemanales" />
                    <asp:BoundField HeaderText="Horas Totales" DataField="HSTotales" />
                    <asp:BoundField HeaderText="Id del Plan" DataField="IDPlan" />
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

        <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center">
        <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" Text="Volver al menu" Width="121px" OnClick="btnVolver_Click" />
             </asp:Panel>

            <asp:Panel ID="formPanel" Visible="False" runat="server">

                <asp:Label ID ="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescripcion" runat="server" 
                    ControlToValidate="descripcionTextBox" 
                    ErrorMessage="La descripcion es obligatoria" 
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
                <br />
                <asp:Button ID="aceptarButton" runat="server" class="btn btn-outline-primary" OnClick="acceptaButton_Click" Text="Aceptar" />
                &nbsp;
                <asp:Button ID="cancelarButton" runat="server" class="btn btn-outline-primary" OnClick="cancelarButton_Click" style="height: 26px" Text="Cancelar" />
                <br />

        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="false">
            &nbsp;
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
