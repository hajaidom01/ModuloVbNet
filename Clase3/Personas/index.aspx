<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Master.Master" CodeBehind="index.aspx.vb" Inherits="Clase3.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .card-body {
            height: 104px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Personas</h2>
    <form >
        <div class="card">
            <div class="card-body">

                <asp:Label ID="Label1" runat="server">Persona Id</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="personaId" runat="server" style="margin-top: 9px" Width="113px">
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label">Nombre</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Label">Apellido</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="txtApellido"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Label">Edad</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="txtEdad"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Label">Estado</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
                <br />
                 <asp:Label ID="Label6" runat="server" Text="Label">Tipo</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlTipo" runat="server"></asp:DropDownList>
            </div>
            <br /><br />
            <div class="card-footer">
                <asp:Button runat="server" Text="Guardar" ID="btnGuardar" />
                <asp:Button runat="server" Text="Editar" ID="btnEditar" />
                

            </div>
        </div>

    </form>
</asp:Content>
