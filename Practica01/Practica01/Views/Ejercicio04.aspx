﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio04.aspx.cs" Inherits="Practica01.Views.Ejercicio04" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Ingreso:"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <p class="col-4"></p>
            <asp:Button ID="Button1" CssClass="btn-success col-4" runat="server" Text="Calcular impuesto" OnClick="Button1_Click" />
            <p class="col-4"></p>
        </div>
        <asp:Label ID="Label11" runat="server" CssClass="" Text="El impuesto local a pagar es: $ = "></asp:Label>
    </div>
</asp:Content>
