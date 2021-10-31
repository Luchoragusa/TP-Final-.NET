<%@ Page Title="" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="DocenteCurso.aspx.cs" 
    Inherits="UI.Web.DocenteCurso" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
        <div>
        </div>

        <asp:Panel ID="gridPanel" runat="server" CssClass="auto-style1" Height="225px" Width="545px">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White"
                    DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="IdDocente" DataField="IdDocente" />
                        <asp:BoundField HeaderText="IdCurso" DataField="IdCurso" />
                        <asp:BoundField HeaderText="Cargo" DataField="Cargo" />   
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>

        <asp:Panel ID="formPanel" Visible="False" runat="server">
        
         <asp:Label ID ="iddocenteLabel" runat="server" Text="IdDocente: "></asp:Label>
        <asp:TextBox ID="iddocenteTextBox" runat="server"></asp:TextBox>
        <br />
        
         <asp:Label ID="idcursoLabel" runat="server" Text="IdCurso: "></asp:Label>
        <asp:TextBox ID="idcursoTextBox" runat="server"></asp:TextBox>
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

  <!--poner tipo cargos?-->
