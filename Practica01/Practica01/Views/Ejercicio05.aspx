<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio05.aspx.cs" Inherits="Practica01.Views.Ejercicio05" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Numero 1"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label2" runat="server" CssClass="col-4" Text="Numero 2"></asp:Label>
            <asp:TextBox ID="TextBox2" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Button ID="btnSumar" CssClass="btn-success col-2 m-1" runat="server" Text="Sumar" OnClick="Button1_Click" />
            <asp:Button ID="btnRestar" CssClass="btn-success col-2 m-1" runat="server" Text="Restar" OnClick="Button1_Click" />
            <asp:Button ID="btnMultiplicar" CssClass="btn-success col-2 m-1" runat="server" Text="Multiplicar" OnClick="Button1_Click" />
            <asp:Button ID="btnDividir" CssClass="btn-success col-2 m-1" runat="server" Text="Dividir" OnClick="Button1_Click" />
            <asp:Button ID="btnSumar2" CssClass="btn-success col-2 m-1" runat="server" Text="Sumar2" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label11" runat="server" CssClass="" Text=""></asp:Label>
    </div>

</asp:Content>
