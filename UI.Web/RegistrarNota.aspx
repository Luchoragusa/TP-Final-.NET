<%@ Page Title="AlumnoInscripcion" Language="C#" 
    MasterPageFile="~/MasterPage/MasterPage.Master" 
    AutoEventWireup="true" 
    CodeBehind="RegistrarNota.aspx.cs" 
    Inherits="UI.Web.RegistrarNota" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblMaterias" runat="server" Text="Materias asignadas del docente:"></asp:Label>
                 <asp:GridView ID="gridViewMaterias" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridViewMaterias_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                   <asp:BoundField HeaderText="ID Materia" DataField="ID" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="HS Semanales" DataField="HSSSemanales" />   
                        <asp:BoundField HeaderText="HS Totales" DataField="HSTotales" />      
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
        <asp:Panel ID="PanelComisiones" runat="server">
            <asp:Label ID="lblComisiones" runat="server" Text="Comisiones asignadas del docente:"></asp:Label>
            <br />
            <asp:GridView ID="gridViewComisiones" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="ID" DataKeysNames="ID" GridLines="Horizontal" OnSelectedIndexChanged="gridViewComisiones_SelectedIndexChanged" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID Comision" />
                    <asp:BoundField DataField="DescComision" HeaderText="Descripcion" />
                    <asp:BoundField DataField="AnioEspecialidad" HeaderText="Año Especialidad" />
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
        </asp:Panel>
        <asp:Panel ID="PanelCursos" runat="server">
            <asp:Label ID="lblCursosDelDocente" runat="server" Text="Cursos asignados del docente:"></asp:Label>
            <br />
            <asp:GridView ID="gridViewCursosDelDocente" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="ID" DataKeysNames="ID" GridLines="Horizontal" OnSelectedIndexChanged="gridViewCursos_SelectedIndexChanged" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID del Curso" />
                    <asp:BoundField DataField="AnioCalendario" HeaderText="AnioCalendario" />
                    <asp:BoundField DataField="IDComision" HeaderText="IDComision" />
                    <asp:BoundField DataField="IDComision" HeaderText="Cupo" />
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
        <br />
        <br />
        <br />



        <asp:Panel ID="PanelAlumnos" runat="server">
            <asp:Label ID="lblAlumnosAsignados" runat="server" Text="Alumnos asignados al curso:"></asp:Label>
                 <asp:GridView ID="gridViewAlumnosDelCursoDelDocente" runat="server" AutoGenerateColumns="False"
                 SelectedRowStyle-BackColor="Black"
                 SelectedRowStyle-ForeColor="White"
                 DataKeysNames="ID" DataKeyNames="ID" OnSelectedIndexChanged="gridViewAlumnos_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
               <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="NombrePersona" />
                        <asp:BoundField HeaderText="Apellido" DataField="ApellidoPersona" />
                        <asp:BoundField HeaderText="Legajo" DataField="legajoPersona" />
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
                            <br />
                            <asp:Label ID="lblNota" runat="server" Text="Nota: "></asp:Label>
                            <asp:DropDownList ID="DropDownListNotas" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                            </asp:DropDownList>
                            <br />
            <asp:Label ID="lblCondicion" runat="server" Text="Condicion del alumno: "></asp:Label>

                            <asp:DropDownList ID="DropDownListCondicion" runat="server">
                                <asp:ListItem>Aprobado</asp:ListItem>
                                <asp:ListItem>Cursando</asp:ListItem>
                                <asp:ListItem>Libre</asp:ListItem>
                                <asp:ListItem>Regular</asp:ListItem>
                            </asp:DropDownList>

            <br />
                            <br />
                            <asp:Button ID="aceptarButton" runat="server" class="btn btn-outline-primary" OnClick="acceptaButton_Click" Text="Aceptar" Width="72px" />
            &nbsp;
            <asp:Button ID="cancelarButton" runat="server" class="btn btn-outline-primary" OnClick="cancelarButton_Click" Text="Cancelar" />
                            <br />

            <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center" Visible="true">
            &nbsp;
            
        </asp:Panel>

        </asp:Panel>
    </asp:Panel>    
            <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center" Visible ="true">
        <asp:Button ID="btnVolver" runat="server" BackColor="#006666" Font-Bold="True" ForeColor="White" Text="Volver al menu" Width="121px" OnClick="btnVolver_Click" />
             </asp:Panel>

</asp:Content>
