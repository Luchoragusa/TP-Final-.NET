<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginEstilo.aspx.cs" Inherits="UI.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <style type ="text/css">
body {
  margin: 0;
  padding: 0;
  background-color: #a2e0d9;
  height: 70vh;
}
#login .container #login-row #login-column #login-box {
  margin-top: 120px;
  max-width: 650px;
  height: 380px;
  border: 10px solid #d0f2f0;
  background-color: #edfffe;
}
#login .container #login-row #login-column #login-box #login-form {
  padding: 20px;
}
#login .container #login-row #login-column #login-box #login-form #register-link {
  margin-top: -85px;
}
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="login"> 
            </br>
            </br>
        <h3 class="text-center" style="font-family: 'Century Gothic'; font-weight: bolder; font-size: 30px; color: #000000;">Bienvenido al Sistema!</h3>
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6" style="color: #C9E7F5">
                    <div id="login-box" class="col-md-12">
                        <form id="login-form" class="form" action="" method="post">
                            </br>
                            <h3 class="text-center text-info" style="color:darkslateblue; font-family: 'Century Gothic'; font-weight: bold;">Login</h3><br>
                            <div class="form-group">
                                <label for="username" class="text-info" style="font-family: 'Century Gothic'; font-weight: bold;">Usuario:</label><br>
                                <asp:TextBox ID="txtUsuario" runat="server" Font-Names="Century Gothic" Width="485px" align= "center"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="password" class="text-info" style="font-family: 'Century Gothic'; font-weight: bold;">Contraseña:</label><br>
                                <asp:TextBox ID="txtPass" type="password" runat="server" Font-Names="Century Gothic" Width="485px" align= "center"></asp:TextBox>
                             <div>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="lblIncorrecto" Visible="False" runat="server" ForeColor="#FF3300" align= "middle" Text="Usuario y/o clave incorrectos" Font-Bold="True" Font-Italic="True" Font-Names="Century Gothic"></asp:Label>
                            </div>
                            </div>
                            <div class="form-group">
                                <asp:Button runat="server" class="btn btn-lg btn-primary btn-block" Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click" Font-Bold="True" Font-Names="Century Gothic" Width="485px" />
                            </div>
                           
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
