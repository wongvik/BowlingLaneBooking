<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="WebApplication1.ThankYou" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="/css/style.css" type="text/css" />
    <div class="auto-style5 content">
        Thank you for your reservation 
        <br />
        <br />
        We will see you then

        <br />
        <br />

        <br />

        <asp:Button ID="btnEnjoy" runat="server" Height="33px" Text="Enjoy" Width="70px" OnClick="btnEnjoy_Click" />

        <br />
        
    </div>

</asp:Content>

