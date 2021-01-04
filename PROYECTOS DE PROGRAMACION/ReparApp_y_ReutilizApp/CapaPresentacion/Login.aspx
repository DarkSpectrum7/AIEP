<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="presentacion.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
<div class="align-content-center">
    <div class="row align-items-center justify-content-center vh-100">
        <div class="col-lg-6">
            <div class="col-lg-12">
                <asp:Label ID="LabelUsuaurio" runat="server" Text="Usuario"></asp:Label><br />
                <asp:TextBox ID="TextBoxUsuario" CssClass="form-control" runat="server"></asp:TextBox>
                <%-- Validacion --%>
            </div>
            <div class="col-lg-12">
                <asp:Label ID="LabelContrasena" runat="server" Text="Contraseña"></asp:Label><br />
                <asp:TextBox ID="TextBoxContrasena" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox><br />
                <%-- Validacion --%>
            </div>
            <div class="col-lg-12">
                <asp:Button ID="ButtonIngresar" CssClass="form-control btn-success" runat="server" Text="Ingresar" />
            </div>
        </div>
    </div>
</div>
</asp:Content>
