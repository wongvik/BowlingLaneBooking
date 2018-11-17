<%@ Page Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="ConfirmForm.aspx.cs"
    Inherits="WebApplication1.ConfirmForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="/css/style.css" type="text/css" />
    <div>
        <asp:Label ID="lblConfBooking" runat="server" Text="Confirmation booking"></asp:Label>
    </div>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Label ID="LblReservInfo" runat="server" Text="Reservation Information:"></asp:Label>
    </p>
    <asp:Label ID="LblName" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="LblNameOutput" runat="server" Text="Label"></asp:Label>
    <p>
        <asp:Label ID="LblDate" runat="server" Text="Date:"></asp:Label>
        <asp:Label ID="LblDateOutput" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Label ID="LblTime" runat="server" Text="Time:"></asp:Label>
    <asp:Label ID="LblTimeOutput" runat="server" Text="Label"></asp:Label>
    <p>
        <asp:Label ID="LblHours" runat="server" Text="Number of hours:"></asp:Label>
        <asp:Label ID="LblHoursOutput" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Label ID="LblPeople" runat="server" Text="Number of people:"></asp:Label>
    <asp:Label ID="LblPeopleOutput" runat="server" Text="Label"></asp:Label>
    <p>
        <asp:Label ID="LblLaneID" runat="server" Text="Lane Number:"></asp:Label>
        <asp:Label ID="LblLaneIDOutput" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LblConfNumber" runat="server" Text="Confirmation Number:"></asp:Label>
        <asp:Label ID="LblConfNumbOutput" runat="server" Text="Label"></asp:Label>

    </p>
    <p>
        <asp:Button ID="BtnSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
</asp:Content>
