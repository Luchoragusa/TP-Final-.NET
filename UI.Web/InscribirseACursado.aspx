<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="InscribirseACursado.aspx.cs" Inherits="UI.Web.InscribirseACursado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblMaterias" runat="server" Text="Inscribirse a Materias: "></asp:Label>
        <br />
               <asp:GridView ID="gridViewMateriasInscripcion" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridViewMaterias_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                   <asp:BoundField HeaderText="ID Materia" DataField="ID" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Horas semanales" DataField="HSSSemanales" />   
                        <asp:BoundField HeaderText="Horas totales" DataField="HSTotales" />                                         
                        <asp:BoundField DataField="IDPlan" HeaderText="ID Plan" />
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



        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="lblComisiones" runat="server" Text="Comisiones de la Materia:"></asp:Label>
                 <asp:GridView ID="gridViewComisionesMateria" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridViewAlumnos_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                        <asp:BoundField HeaderText="ID Comision" DataField="ID" />
                        <asp:BoundField HeaderText="Descripcion" DataField="DescComision" />
                        <asp:BoundField HeaderText="Año Especialidad" DataField="AnioEspecialidad" />
                        <asp:BoundField HeaderText="ID Plan" DataField="IDPlan" />
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

            <br />
                            <br />
                            <asp:Button ID="btnInscribirse" runat="server" class="btn btn-outline-primary" OnClick="acceptaButton_Click" Text="Inscribirse" Width="72px" />
            &nbsp;
                            <br />
            <br />
            <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" OnClick="btnVolver_Click" Text="Volver al menu" Width="121px" />
                            <br />

            <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center" Visible="true">
            &nbsp;
            
        </asp:Panel>

        </asp:Panel>
    </asp:Panel>    
            <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center" Visible ="true">
             </asp:Panel>

</asp:Content>
