<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alum_Inscrip.aspx.cs" Inherits="UI.Web.Alum_Inscrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Alum_Inscrip</title>
        <style type="text/css">
            .auto-style1 {
                margin-bottom: 161px;
                margin-left: 0px;
                margin-top: 111px;
            }
            .auto-style2 {
                margin-left: 486px;
                margin-top: 0px;
                margin-bottom: 0px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="216px" Width="1498px">
                &nbsp;
                <br />
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" CssClass="auto-style2" GridLines="Horizontal" Width="485px">
                    <Columns>
                        <asp:BoundField HeaderText="ID-Curso" DataField="IDCurso" />
                        <asp:BoundField HeaderText="ID-Alumno" DataField="IDAlumno" />
                        <asp:BoundField HeaderText="Nota" DataField="Nota" />
                        <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
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
                &nbsp;</asp:Panel>

     <asp:Panel ID="formPanel" Visible="False" runat="server">
        
         <asp:Label ID ="idcursoLabel" runat="server" Text="IDCurso: "></asp:Label>
        <asp:TextBox ID="idcursoTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="idalumnoLabel" runat="server" Text="IDAlumno: "></asp:Label>
        <asp:TextBox ID="idalumnoTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="notaLabel" runat="server" Text="Nota: "></asp:Label>
        <asp:TextBox ID="notaTextBox" runat="server" Width="40px"></asp:TextBox>
        <br />
        
         <asp:Label ID="condicionLabel" runat="server" Text="Condicion: "></asp:Label>
        <asp:TextBox ID="condicionTextBox" runat="server"></asp:TextBox>
        <br />      
           
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="false">
            <asp:Button ID="aceptarButton" runat="server" class="btn btn-outline-primary" Text="Aceptar" OnClick="acceptaButton_Click" />
            <asp:Button ID="cancelarButton" runat="server" class="btn btn-outline-primary" Text="Cancelar" OnClick="cancelarButton_Click" />
        </asp:Panel>
        
     </asp:Panel>

        <!-- Parte de los botones del GridView -->
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
        <!-- Parte de los botones del GridView -->

    </form>
</body>
</html>
