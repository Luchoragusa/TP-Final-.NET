<%@ Page Title="Persona" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="Persona.aspx.cs" 
    Inherits="UI.Web.Persona" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div>
        </div>

        <asp:Panel ID="gridPanel" runat="server"  Height="225px" Width="1512px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
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
        
         <asp:Label ID ="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server" 
                    ControlToValidate="nombreTextBox" 
                    ErrorMessage="El nombre es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellido" runat="server" 
                    ControlToValidate="apellidoTextBox" 
                    ErrorMessage="El apellido es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" Width="124px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" 
                    ControlToValidate="emailTextBox" 
                    ErrorMessage="El email es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorDireccion" runat="server" 
                    ControlToValidate="direccionTextBox" 
                    ErrorMessage="La direccion es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />      

        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorTelefono" runat="server" 
                    ControlToValidate="telefonoTextBox" 
                    ErrorMessage="El telefono es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />    
            
        <asp:Label ID="idplanLabel" runat="server" Text="ID del Plan: "></asp:Label>
        <asp:TextBox ID="idplanTextBox" runat="server" Width="37px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorIDPlan" runat="server" 
                    ControlToValidate="idplanTextBox" 
                    ErrorMessage="La ID del Plan es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />   
            
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server" Width="72px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLegajo" runat="server" 
                    ControlToValidate="legajoTextBox" 
                    ErrorMessage="El legajo es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />     

        <asp:Label ID="fechanacLabel" runat="server" Text="Fecha de nacimiento: "></asp:Label>
        <asp:TextBox ID="fechanacTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaNac" runat="server" 
                    ControlToValidate="fechanacTextBox" 
                    ErrorMessage="La fecha de nacimiento es obligatoria" 
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