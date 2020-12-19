<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Actividad4.aspx.vb" Inherits="Act_Clase1.Actividad4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Century Gothic" Font-Size="X-Large" ForeColor="#660066" Text="Tarea | Actividad 4"></asp:Label>
            <p>
                &nbsp;
            </p>



            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Century Gothic" ForeColor="#333399" Text="Ingresa tu número de empleado: "></asp:Label>
            &nbsp;<asp:TextBox ID="txtNoEmpl" runat="server" Font-Names="Century Gothic" Font-Size="Medium" Width="356px"></asp:TextBox>
            <br />
            <p>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Century Gothic" ForeColor="#333399" Text="Nombre:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNombre" runat="server" Width="281px"></asp:TextBox>
            </p>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Century Gothic" ForeColor="#333399" Text="Tipo de empleado:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Font-Names="Century Gothic" Font-Size="Medium" ForeColor="#666633">
                <asp:ListItem>Operador</asp:ListItem>
                <asp:ListItem Value="Tecnico">Técnico</asp:ListItem>
                <asp:ListItem>Mantenimiento</asp:ListItem>
                <asp:ListItem>Gerente</asp:ListItem>
                <asp:ListItem>Directivo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <p>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Century Gothic" ForeColor="#333399" Text="Horas trabajadas por semana:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtHoras" runat="server" Width="281px"></asp:TextBox>
            </p>

            <asp:Button ID="btnAceptar" runat="server" Font-Bold="True" Font-Names="Century Gothic" Font-Size="Medium" Text="Aceptar" OnClick="btnAceptar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancelar" runat="server" Font-Bold="True" Font-Names="Century Gothic" Font-Size="Medium" Text="Cancelar" Style="width: 102px" />
        </div>
    </form>
</body>
</html>
