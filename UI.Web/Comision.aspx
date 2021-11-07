<%@ Page Title="Comision" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Comision.aspx.cs" 
    Inherits="UI.Web.Comision" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div>
        </div>
            <asp:Panel ID="gridPanel" runat="server" Height="302px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                        <asp:BoundField HeaderText="ID Comision" DataField="ID" />
                        <asp:BoundField HeaderText="ID-Plan" DataField="IDPlan" />
                        <asp:BoundField HeaderText="DescComision" DataField="DescComision" />
                        <asp:BoundField HeaderText="AnioEspecialidad" DataField="AnioEspecialidad" />
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
                <br />
            </asp:Panel>

        <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center">
        <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" Text="Volver al menu" Width="121px" OnClick="btnVolver_Click" />
             </asp:Panel>
      
            <asp:Panel ID="formPanel" Visible="False" runat="server">
        
                <br />
        
         <asp:Label ID ="idPlanLabel" runat="server" Text="IDPlan: "></asp:Label>
        <asp:TextBox ID="idPlanTextBox" runat="server" Width="47px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPlan" runat="server" 
                    ControlToValidate="idPlanTextBox" 
                    ErrorMessage="La ID del plan es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="descComisionLabel" runat="server" Text="Descripcion Comision"></asp:Label>
        <asp:TextBox ID="descComisionTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorComision" runat="server" 
                    ControlToValidate="descComisionTextBox" 
                    ErrorMessage="La descripcion de la comision es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="anioEspecialidadLabel" runat="server" Text="Año especialidad: "></asp:Label>
        <asp:TextBox ID="anioEspecialidadTextBox" runat="server" Width="51px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAnioEspecialidad" runat="server" 
                    ControlToValidate="anioEspecialidadTextBox" 
                    ErrorMessage="El anio de la especialidad es obligatoria" 
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
