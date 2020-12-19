<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="Alumnos.aspx.vb" Inherits="Alumnos.Alumnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
        <center>
            <br />
            <div class="container">
                <label>Matricula</label>&nbsp;<asp:TextBox ID="txtMat" runat="server" CssClass="font-weight-bold" AutoComplete="off"></asp:TextBox>&nbsp;
                <asp:Button runat="server" ID="btnBuscar"  Text="Buscar" OnClick="BtnBuscar_Click" CssClass="btn" AutoComplete="off"/>&nbsp;
                <asp:Button runat="server" ID="btnLimpiar" Text="Limpiar" OnClick="BtnLimpiar_Click" CssClass="btn" AutoComplete="off"/>
                <asp:Button runat="server" ID="btnNuevo" Text="Nuevo" OnClick="BtnNuevo_Click" CssClass="btn" AutoComplete="off"/>
            </div>
            <div class="container">
             
                <div class="row">
                    <label>Id Alumno</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtId" runat="server" CssClass="form-control" AutoComplete="off"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Nombre Alumno</label>&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" AutoComplete="off"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Apellido</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" AutoComplete="off" ></asp:TextBox>
                </div>
                <div class="row">
                    <label>Matricula</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" AutoComplete="off"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="container">
                <div class="btn-group">
                    <asp:Button ID="btnGuarda" runat="server" Text="Guardar" OnClick="BtnGuarda_Click" CssClass="btn"/>&nbsp;
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="BtnEditar_Click" CssClass="btn" />&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click" CssClass="btn" />
                </div>
            </div>
        </center>
    </form>
</asp:Content>
