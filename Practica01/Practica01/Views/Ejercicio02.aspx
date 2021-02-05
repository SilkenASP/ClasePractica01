<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio02.aspx.cs" Inherits="Practica01.Views.Ejercicio02" %>
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
            <asp:Label ID="Label3" runat="server" CssClass="col-4" Text="Numero 3"></asp:Label>
            <asp:TextBox ID="TextBox3" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label4" runat="server" CssClass="col-4" Text="Numero 4"></asp:Label>
            <asp:TextBox ID="TextBox4" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label5" runat="server" CssClass="col-4" Text="Numero 5"></asp:Label>
            <asp:TextBox ID="TextBox5" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label6" runat="server" CssClass="col-4" Text="Numero 6"></asp:Label>
            <asp:TextBox ID="TextBox6" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label7" runat="server" CssClass="col-4" Text="Numero 7"></asp:Label>
            <asp:TextBox ID="TextBox7" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label8" runat="server" CssClass="col-4" Text="Numero 8"></asp:Label>
            <asp:TextBox ID="TextBox8" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label9" runat="server" CssClass="col-4" Text="Numero 9"></asp:Label>
            <asp:TextBox ID="TextBox9" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="Label10" runat="server" CssClass="col-4" Text="Numero 10"></asp:Label>
            <asp:TextBox ID="TextBox10" CssClass="col-8" runat="server"></asp:TextBox>
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
