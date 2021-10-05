<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alum_Inscrip.aspx.cs" Inherits="UI.Web.Alum_Inscrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <title>Alum_Inscrip
            </title>
        <style type="text/css">
            .auto-style1 {
                margin-bottom: 161px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="225px" Width="545px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="ID-Curso" DataField="IDCurso" />
                        <asp:BoundField HeaderText="ID-Alumno" DataField="IDAlumno" />
                        <asp:BoundField HeaderText="Nota" DataField="Nota" />
                        <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
        </asp:Panel>

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
