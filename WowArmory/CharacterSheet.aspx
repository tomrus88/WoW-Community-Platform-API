<%@ Page Title="Character Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CharacterSheet.aspx.cs" Inherits="character_sheet" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <% PrintData(); %>
</asp:Content>
