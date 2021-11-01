<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWeb.aspx.cs" Inherits="UI.Web.LoginWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>[ACADEMIA] Login</title>
    <style type="text/css">
        .auto-style1 {
            height: 472px;
            background-color: #ade2fc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" align="center">
        <h2 class="form-signin-heading">&nbsp;</h2>
        <h2 class="form-signin-heading">&nbsp;</h2>
        <h2 class="form-signin-heading" style="font-family: 'Century Gothic'">¡Bienvenido al Sistema!</h2>
            <p class="form-signin-heading" style="font-family: 'Century Gothic'">Por favor digite su información de Ingreso</p>
        <p class="form-signin-heading">&nbsp;</p>
        <asp:Label ID="usuarioLabel" runat="server" Text="Usuario" Font-Bold="True" Font-Italic="False" Font-Strikeout="False" Font-Names="Century Gothic"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUsuario" runat="server" Font-Names="Century Gothic"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombreUsuario" runat="server" 
                    ControlToValidate="txtUsuario" 
                    ErrorMessage="El nombre de usuario es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="claveLabel" runat="server" Text="Clave" Font-Bold="True" Font-Names="Century Gothic"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPass" type="password" runat="server" Font-Names="Century Gothic"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorClaveUsuario" runat="server" 
                    ControlToValidate="txtPass" 
                    ErrorMessage="La clave de usuario es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>

            <br />
        <br />
            <asp:Label ID="lblIncorrecto" Visible="False" runat="server" ForeColor="#FF3300" Text="Usuario y/o clave incorrectos" Font-Bold="True" Font-Italic="True" Font-Names="Century Gothic"></asp:Label>
            <br />
        <br />
        <asp:Button runat="server" class="btn btn-lg btn-primary btn-block" Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click" Font-Bold="True" Font-Names="Century Gothic" />
    </div>
    </form>
</body>
</html>
