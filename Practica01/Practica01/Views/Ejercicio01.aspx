<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio01.aspx.cs" Inherits="Practica01.Views.Ejercicio01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Ingrese las pulgadas que desea convertir"></asp:Label>
            <asp:TextBox ID="pulgadas" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <p class="col-4"></p>
            <asp:Button ID="btnConvertir" CssClass="col-4" runat="server" Text="Convertir" OnClick="btnConvertir_Click" />
            <p class="col-4"></p>
        </div>
        <div class="row">
            <asp:Label ID="Respuesta" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
