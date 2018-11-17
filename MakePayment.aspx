<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakePayment.aspx.cs" Inherits="WebApplication1.MakePayment" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="/css/style.css" type="text/css" />


    <div class="auto-style5 content">
        <h2>Payment</h2>
        <table class="table">
            <tr>
                <td>Net Price: $<asp:Label ID="LblPrice" runat="server" Text="Label"></asp:Label></td>
                <td>Tax: $<asp:Label ID="LblTax" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">Total Price: $<asp:Label ID="LblTotal" runat="server" Text="Label"></asp:Label></td>
            </tr>

            <tr>
                <td colspan="2">Method of payment: </td>
            </tr>


            <tr>
                <td>
                    <asp:Label ID="LblCardName" runat="server" Text="Cardholder Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCardName" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RFVCardName" runat="server" ControlToValidate="txtCardName" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="REValidatorCardName" ValidationExpression="^[A-Za-z ,.'-]+$" ControlToValidate="txtCardName"
                        runat="server" ErrorMessage="Please enter letters only" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td style="height: 52px">&nbsp;<asp:Label ID="LblCardNumber" runat="server" Text="Card Number:"></asp:Label>
                </td>
                <td style="height: 52px">
                    <asp:TextBox ID="txtCardNum" runat="server" MaxLength="16"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RFVCardNum" runat="server" ControlToValidate="txtCardNum"
                        ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="REValidatorCardNum" ControlToValidate="txtCardNum"
                        ValidationExpression="^[0-9]{16}$" runat="server" ErrorMessage="Please input 16 digits" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="LblExpDate" runat="server" Text="Expiry Date (Date format: MM/YYYY)"></asp:Label>

                </td>
                <td>
                    
                        <asp:DropDownList ID="DropDownListExpMon" runat="server">
                            <asp:ListItem Enabled="true" Text="Select Month" Value="0"></asp:ListItem>
                            <asp:ListItem Text="1" Value="1"></asp:ListItem>
                            <asp:ListItem Text="2" Value="2"></asp:ListItem>
                            <asp:ListItem Text="3" Value="3"></asp:ListItem>
                            <asp:ListItem Text="4" Value="4"></asp:ListItem>
                            <asp:ListItem Text="5" Value="5"></asp:ListItem>
                            <asp:ListItem Text="6" Value="6"></asp:ListItem>
                            <asp:ListItem Text="7" Value="7"></asp:ListItem>
                            <asp:ListItem Text="8" Value="8"></asp:ListItem>
                            <asp:ListItem Text="9" Value="9"></asp:ListItem>
                            <asp:ListItem Text="10" Value="10"></asp:ListItem>
                            <asp:ListItem Text="11" Value="11"></asp:ListItem>
                            <asp:ListItem Text="12" Value="12"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownListExpYear" runat="server">
                            <asp:ListItem Enabled="true" Text="Select Year" Value="0"></asp:ListItem>
                            <asp:ListItem Text="2018" Value="2018"></asp:ListItem>
                            <asp:ListItem Text="2019" Value="2019"></asp:ListItem>
                            <asp:ListItem Text="2020" Value="2020"></asp:ListItem>
                        </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorMonth" runat="server" ControlToValidate="DropDownListExpMon" InitialValue="0"
                        ErrorMessage="Month Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorYear" runat="server" ControlToValidate="DropDownListExpYear" InitialValue="0"
                        ErrorMessage="Year Required" ForeColor="Red"></asp:RequiredFieldValidator>
                
                    </td>
                    
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Lblsecurity" runat="server" Text="Security Code:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSecCode" runat="server" MaxLength="3"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RFVSecCode" runat="server" ControlToValidate="txtSecCode"
                        ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="REValidatorSecCode" ControlToValidate="txtSecCode"
                        ValidationExpression="^[0-9]{3}$" runat="server" ErrorMessage="Please input 3 digits" ForeColor="Red">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Pay" class="btn btn-primary" runat="server" Text="Make Payment" OnClick="Pay_Click" />
                    <br />
                </td>
            </tr>

        </table>
    </div>

</asp:Content>

