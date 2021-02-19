<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="TarjetaEjercicio.aspx.cs" Inherits="Practica01.Views.TarjetaEjercicio" %>
<%@ Register src="../UserControl/TarjetaCredito.ascx" tagname="TarjetaCredito" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <uc1:TarjetaCredito ID="TarjetaCredito1" runat="server" />

</asp:Content>
