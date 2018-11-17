<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="WebApplication1.BookingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="/css/style.css" type="text/css" />
    <div class="content">
            <div class="container">
                
            Please fill your information
            
            <div class="row mb-4">
                <div class="col">Name:</div>
                <div class="col-6">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVTxtName" runat="server" ErrorMessage="This field is required"
                    ControlToValidate="txtName" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </div>
            </div>   

            <div class="row mb-4">
                    <div class="col">Phone # :</div>
                    <div class="col-6">
                        <asp:TextBox ID="txtPhone" runat="server" MaxLength="10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFVTxtPhone" runat="server" ErrorMessage="This field is required"
                            ControlToValidate="txtPhone" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ControlToValidate="txtPhone" ValidationExpression="^[0-9]{10}$"
                            ID="RegularExpressionPhone" runat="server" ErrorMessage="Phone number has to be in 10 digits" ForeColor="Red">
                        </asp:RegularExpressionValidator>
                    </div>
            </div>   
            <div class="row mb-4">
                    <div class="col">Street :</div>
                    <div class="col-6">
                        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ValidationExpression="^\d+\s[A-z]+\s[A-z]+" ControlToValidate="txtStreet"
                            ErrorMessage="Please enter a valid Street Address" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
            </div>   
            <div class="row mb-4">
                    <div class="col">Unit # :</div>
                    <div class="col-6">
                        <asp:TextBox ID="txtUnit" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtUnit"
                            ErrorMessage="Only Numbers allowed" ValidationExpression="\d+" runat="server" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
            </div>   
            <div class="row mb-4">
                    <div class="col">City: </div>
                    <div class="col-6">
                        
                            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    
                    
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtCity"
                                ErrorMessage="Please enter a valid city" ValidationExpression="^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$" ForeColor="Red">
                            </asp:RegularExpressionValidator>
                    </div>
            </div>
            <div class="row mb-4">
                    <div class="col">Province: </div>
                    <div class="col-6">
                            <asp:DropDownList ID="dropDownProv" runat="server" Style="height: 25px">
                            <asp:ListItem Value="" Selected="true">Province</asp:ListItem>
                            <asp:ListItem Value="AB">AB</asp:ListItem>
                            <asp:ListItem Value="BC">BC</asp:ListItem>
                            <asp:ListItem Value="MB">MB</asp:ListItem>
                            <asp:ListItem Value="NB">NB</asp:ListItem>
                            <asp:ListItem Value="NL">NL</asp:ListItem>
                            <asp:ListItem Value="NP">NP</asp:ListItem>
                            <asp:ListItem Value="NT">NT</asp:ListItem>
                            <asp:ListItem Value="NS">NS</asp:ListItem>
                            <asp:ListItem Value="ON">ON</asp:ListItem>
                            <asp:ListItem Value="PE">PE</asp:ListItem>
                            <asp:ListItem Value="QC">QC</asp:ListItem>
                            <asp:ListItem Value="SK">SK</asp:ListItem>
                            <asp:ListItem Value="YT">YT</asp:ListItem>
                        </asp:DropDownList>
                    </div>
            </div>   
            <div class="row mb-4">
                    <div class="col">Postal Code: </div>
                    <div class="col-6">
                            <asp:TextBox ID="txtPostal" runat="server" MaxLength="6"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtPostal"
                                ValidationExpression="[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]"
                                runat="server" ErrorMessage="Please enter a valid postal code" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
            </div>
            <div class="row mb-4">
                    <div class="col">Email:</div>
                    <div class="col-6">
                        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredValidatorEmail" runat="server" ControlToValidate="TxtEmail"
                            ErrorMessage="Email required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="REValidatorEmail" runat="server" ControlToValidate="TxtEmail"
                            ErrorMessage="Please enter valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                        </asp:RegularExpressionValidator>
                    </div>
            </div>  
        <br />
        <asp:Label ID="Label3" runat="server" Text="When would you like to start booking?"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownTime" OnSelectedIndexChanged="DropDownTime_SelectedIndexChanged" runat="server" AutoPostBack="True">
            <asp:ListItem Enabled="true" Text="Select Time" Value="-1"></asp:ListItem>
            <asp:ListItem Text="12:00 pm" Value="0"></asp:ListItem>
            <asp:ListItem Text="1:00 pm" Value="1"></asp:ListItem>
            <asp:ListItem Text="2:00 pm" Value="2"></asp:ListItem>
            <asp:ListItem Text="3:00 pm" Value="3"></asp:ListItem>
            <asp:ListItem Text="4:00 pm" Value="4"></asp:ListItem>
            <asp:ListItem Text="5:00 pm" Value="5"></asp:ListItem>
            <asp:ListItem Text="6:00 pm" Value="6"></asp:ListItem>
            <asp:ListItem Text="7:00 pm" Value="7"></asp:ListItem>
            <asp:ListItem Text="8:00 pm" Value="8"></asp:ListItem>
            <asp:ListItem Text="9:00 pm" Value="9"></asp:ListItem>
            <asp:ListItem Text="10:00 pm" Value="10"></asp:ListItem>
            <asp:ListItem Text="11:00 pm" Value="11"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:RequiredFieldValidator ID="RFVDropDownTime" runat="server" ControlToValidate="DropDownTime"
            ErrorMessage="This field is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="How many hours would you like to book?"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownNumHours" OnSelectedIndexChanged="DropDownNumHours_SelectedIndexChanged"
            runat="server" AutoPostBack="True">
            <asp:ListItem Enabled="true" Text="Select Number of hours" Value="-1"></asp:ListItem>
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:RequiredFieldValidator ID="RFVDropDownNumHours" runat="server" ControlToValidate="DropDownNumHours"
            ErrorMessage="This field is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        How many people?<br />
        <br />
        <asp:DropDownList ID="DropDownNumPpl" runat="server" OnSelectedIndexChanged="DropDownNumPpl_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Enabled="true" Text="Select Number of people" Value="-1"></asp:ListItem>
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
            <asp:ListItem Text="5" Value="5"></asp:ListItem>
            <asp:ListItem Text="6" Value="6"></asp:ListItem>
            <asp:ListItem Text="7" Value="7"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:RequiredFieldValidator ID="RFVDropDownNumPpl" runat="server" ControlToValidate="DropDownNumPpl"
            ErrorMessage="This field is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>

        <br />
        <br />
        <br />
        <asp:Button ID="BtnShowAvail" class="btn btn-primary" runat="server" Text="Show Availability" OnClick="BtnShowAvail_Click" />
        <br />
        <br />
        <asp:Label ID="LblAvailable" runat="server" Text="Select the time you would like to book, then click the button above to check!"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkBtnPayment" class="btn btn-primary" runat="server" OnClick="LinkBtnPayment_Click">Make Payment</asp:LinkButton>


    </div>

</asp:Content>



