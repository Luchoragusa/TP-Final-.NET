﻿<%@ Page Title="Docente Curso" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="DocenteCurso.aspx.cs" 
    Inherits="UI.Web.DocenteCurso" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div>
        </div>

        <asp:Panel ID="gridPanel" runat="server" Height="185px" Width="1276px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField HeaderText="IdDocente" DataField="IdDocente" />
                        <asp:BoundField HeaderText="IdCurso" DataField="IdCurso" />
                        <asp:BoundField HeaderText="Cargo" DataField="Cargo" />   
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
        
         <asp:Label ID ="iddocenteLabel" runat="server" Text="ID del Docente: "></asp:Label>
        <asp:TextBox ID="iddocenteTextBox" runat="server" Width="37px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorIDDocente" runat="server" 
                    ControlToValidate="iddocenteTextBox" 
                    ErrorMessage="La ID del Docente es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="idcursoLabel" runat="server" Text="ID del Curso: "></asp:Label>
        <asp:TextBox ID="idcursoTextBox" runat="server" Width="37px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorIDCurso" runat="server" 
                    ControlToValidate="idcursoTextBox" 
                    ErrorMessage="La ID del Curso es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblCargo" runat="server" Text="Cargo"></asp:Label>
            &nbsp;<asp:DropDownList ID="dropDownListCargo" runat="server">
                <asp:ListItem>Titular</asp:ListItem>
                <asp:ListItem>Auxiliar</asp:ListItem>
                <asp:ListItem>Jefe de Catedra</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="aceptarButton" runat="server" class="btn btn-outline-primary" OnClick="acceptaButton_Click" Text="Aceptar" Width="72px" />
&nbsp;
            <asp:Button ID="cancelarButton" runat="server" class="btn btn-outline-primary" OnClick="cancelarButton_Click" Text="Cancelar" />
        <br />
        

        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="true">
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