<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWeb.aspx.cs" Inherits="UI.Web.LoginWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>[ACADEMIA] Login</title>
    <style type="text/css">
        .auto-style1 {
            height: 377px;
            background-color: #63bf65;
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
        <asp:Label ID="usuarioLabel" runat="server" Text="Usuario" Font-Bold="True" Font-Italic="False" Font-Strikeout="False"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombreUsuario" runat="server" 
                    ControlToValidate="txtUsuario" 
                    ErrorMessage="El nombre de usuario es obligatorio" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="claveLabel" runat="server" Text="Clave" Font-Bold="True"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPass" type="password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorClaveUsuario" runat="server" 
                    ControlToValidate="txtPass" 
                    ErrorMessage="La clave de usuario es obligatoria" 
                    ForeColor="Red">
                    *
                </asp:RequiredFieldValidator>

            <br />
        <br />
            <asp:Label ID="lblIncorrecto" Visible="false" runat="server" ForeColor="#FF3300" Text="Usuario y/o clave incorrectos"></asp:Label>
            <br />
        <asp:Button runat="server" class="btn btn-lg btn-primary btn-block" Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click" />
        <br />
    </div>
    </form>
</body>
</html>
