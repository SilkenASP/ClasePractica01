<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio03.aspx.cs" Inherits="Practica01.Views.Ejercicio03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Años"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label2" runat="server" CssClass="col-4" Text="Meses"></asp:Label>
            <asp:TextBox ID="TextBox2" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <p class="col-4"></p>
            <asp:Button ID="Button1" CssClass="btn-success col-4" runat="server" Text="Calcular promedio" OnClick="Button1_Click" />
            <p class="col-4"></p>
        </div>
        <asp:Label ID="Label11" runat="server" CssClass="" Text="Promedio = "></asp:Label>
    </div>
</asp:Content>
