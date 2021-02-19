<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TarjetaCredito.ascx.cs" Inherits="Practica01.UserControl.TarjetaCredito" %>
<div class="container">
    <br />
    <div class="row">
        <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Numero Tarjeta"></asp:Label>
        <asp:TextBox ID="txtNumeroTarjeta" runat="server" CssClass="col-8"></asp:TextBox>
    </div>
    <br />
    <div class="row">
        <asp:Label ID="Label2" runat="server" CssClass="col-4" Text="CVV"></asp:Label>
        <asp:TextBox ID="txtCVV" runat="server" CssClass="col-8"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Label ID="Label3" runat="server" CssClass="col-4" Text="Mes/Fecha vencimiento"></asp:Label>
        <asp:DropDownList ID="DropDownList1" CssClass="col-4" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="col-4"></asp:TextBox>
    </div>
    <br />
    <div class="row">
        <div class="col-4"></div>
        <asp:Button ID="Button1" runat="server" CssClass="col-4" Text="Verificar" OnClick="Button1_Click" />
        <div class="col-4"></div>
    </div>
    <br />
    <div class="row">
        <div class="col-4"></div>
        <asp:Label ID="lblError" runat="server" CssClass="col-4" Text=""></asp:Label>
        <div class="col-4"></div>
    </div>
    <div class="row">
        <div class="col-4"></div>
        <asp:Label ID="lblMarca" runat="server" CssClass="col-4" Text=""></asp:Label>
        <div class="col-4"></div>
    </div>
</div>