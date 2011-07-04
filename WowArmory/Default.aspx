<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="Label1" runat="server" Text="Realm: " />
    <asp:TextBox ID="TextBox1" runat="server" /><br />

    <asp:Label ID="Label2" runat="server" Text="Character: " />
    <asp:TextBox ID="TextBox2" runat="server" /><br />

    <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
</asp:Content>
