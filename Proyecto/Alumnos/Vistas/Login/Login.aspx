<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Alumnos.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../../Css/Login.css" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <h1>Sistema de gestion de alumnos</h1>
        </center>
        
        <div>
            <div class="login-page">
                <div class="form">
                    
                    <form>
                        
                        <asp:TextBox ID="txtUser" runat="server" placeholder="Usuario" AutoComplete="off"></asp:TextBox>
                        <asp:TextBox ID="txtMail" runat="server" placeholder="Contraseña" AutoComplete="off" TextMode="Password"></asp:TextBox>
                        <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                       
                    </form>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
