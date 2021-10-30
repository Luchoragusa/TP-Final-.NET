<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWeb.aspx.cs" Inherits="UI.Web.LoginWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron text-center" align="center">
        <h2 class="form-signin-heading">&nbsp;</h2>
        <h2 class="form-signin-heading">&nbsp;</h2>
        <h2 class="form-signin-heading" style="font-family: 'Century Gothic'">¡Bienvenido al Sistema!</h2>
            <p class="form-signin-heading" style="font-family: 'Century Gothic'">Por favor digite su información de Ingreso</p>
        <p class="form-signin-heading">&nbsp;</p>
        <asp:Label ID="usuarioLabel" runat="server" Text="Usuario" Font-Bold="True" Font-Italic="False" Font-Strikeout="False"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="claveLabel" runat="server" Text="Clave" Font-Bold="True"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPass" type="password" runat="server"></asp:TextBox>
        <br />
        <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">¿Olvidó su contraseña?</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" class="btn btn-lg btn-primary btn-block" Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click" />
        <br />
    </div>
    </form>
</body>
</html>
