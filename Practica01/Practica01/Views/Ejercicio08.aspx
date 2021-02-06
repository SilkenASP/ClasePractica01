<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Ejercicio08.aspx.cs" Inherits="Practica01.Views.Ejercicio08" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Fecha Nacimiento"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="1970-10-17"></asp:Calendar>
        </div>
        <br />
        <div class="row">
            <asp:Button ID="Button1" CssClass="btn-success col-2 m-1" runat="server" Text="Sumar" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label11" runat="server" CssClass="" Text=""></asp:Label>
    </div>
</asp:Content>
