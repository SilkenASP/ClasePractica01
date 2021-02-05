<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio09.aspx.cs" Inherits="Practica01.Views.Ejercicio09" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="a"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label2" runat="server" CssClass="col-4" Text="b"></asp:Label>
            <asp:TextBox ID="TextBox2" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label3" runat="server" CssClass="col-4" Text="c"></asp:Label>
            <asp:TextBox ID="TextBox3" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Button ID="Button1" CssClass="btn-success col-2 m-1" runat="server" Text="Continuar" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label11" runat="server" CssClass="" Text=""></asp:Label>
    </div>
</asp:Content>
