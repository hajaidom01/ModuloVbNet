<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Master.Master" CodeBehind="index.aspx.vb" Inherits="Clase3.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Estados</h2>
    <form>
        <div class="card">
            <div class="card-body">

                <asp:Label ID="Label1" runat="server" Text="Persona Id"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>

            </div>
        </div>
    </form>
</asp:Content>
