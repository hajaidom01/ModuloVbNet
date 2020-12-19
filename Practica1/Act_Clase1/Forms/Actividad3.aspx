<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Actividad3.aspx.vb" Inherits="Act_Clase1.Actividad3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <br />
    <br />
    <br />
    <center>
    <form id="form1" runat="server">
        <div style="height: 352px" >
            <asp:Label runat="server">Ingresa tu correo &nbsp;&nbsp; &nbsp; &nbsp;  </asp:Label>
            <asp:TextBox runat="server" ID="txtMail" style="margin-left: 9px" Width="127px"></asp:TextBox>
            <br />
            <asp:Label runat="server">Ingresa tu contraseña</asp:Label>
            <asp:TextBox runat="server" ID="txtPassword" style="margin-left: 9px" Width="126px" TextMode="Password" ></asp:TextBox>
            <br />
            <div>
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesion" OnClick="BtnLogin_Click"/> &nbsp; 
                <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="BtnCancel_Click" />
            </div>
        </div>
    </form>
        </center>
</body>
</html>
