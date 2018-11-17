<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakePayment.aspx.cs" Inherits="WebApplication1.UpdateForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="/css/style.css" type="text/css" />
    Please enter your information to update or delete your booking:
    <table>
        <tr>
            <td>Name : </td>
            <td>
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RFVTxtName" runat="server" ErrorMessage="This field is required"
                    ControlToValidate="txtName" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Phone # : </td>
            <td>
                <asp:TextBox ID="TxtPhone" runat="server" MaxLength="10"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RFVTxtPhone" runat="server" ErrorMessage="This field is required"
                    ControlToValidate="txtPhone" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ControlToValidate="txtPhone" ValidationExpression="^[0-9]{10}$"
                    ID="RegularExpressionPhone"  runat="server" ErrorMessage="Phone number has to be in 10 digits" ForeColor="Red">
                </asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Email : </td>
            <td>
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredValidatorEmail" runat="server" ControlToValidate="TxtEmail"
                    ErrorMessage="Email required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="REValidatorEmail" runat="server" ControlToValidate="TxtEmail"
                    ErrorMessage="Please enter valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                </asp:RegularExpressionValidator>
        </tr>
        <tr>
            <td>Receipt Number: </td>
            <td>
                <asp:Label ID="LblReceiptNo" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Time Slot Booked: </td>
            <td>
                <asp:Label ID="LblTimeSlot" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Receipt Total: </td>
            <td>
                <asp:Label ID="LblTotal" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
    <asp:Button ID="BtnCheck" class="btn btn-primary" OnClick="BtnCheck_Click" runat="server" Text ="Check your Invoice"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Button ID="BtnUpdate" class="btn btn-primary" OnClick="BtnUpdate_Click" runat="server" Text="Update your Information" />&emsp;&emsp;&emsp;&emsp;
    <asp:Button ID="BtnDelete" class="btn btn-delete" runat="server"  OnClick="BtnDelete_Click" Text="Cancel Booking" />
</asp:Content>
