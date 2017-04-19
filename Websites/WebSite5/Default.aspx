<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" UnobtrusiveValidationMode="None"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            background-color: #FFCC99;
        }
        .auto-style3 {
            text-align: right;
            width: 1159px;
            background-color: #FFCC99;
        }
        .auto-style4 {
            width: 296px;
            background-color: #FFCC99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Username</td>
                <td class="auto-style4">
                    <asp:TextBox ID="userTextBox" runat="server" style="margin-right: 4px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="userTextBox" ErrorMessage="Username Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="passTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passTextBox" ErrorMessage="Password Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Confirm Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="confirmPassTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="confirmPassTextBox" ErrorMessage="Password Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passTextBox" ControlToValidate="confirmPassTextBox" ErrorMessage="Passwords Must Match" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="addressTextBox" ErrorMessage="Address Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Zip Code</td>
                <td class="auto-style4">
                    <asp:TextBox ID="zipTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="zipTextBox" ErrorMessage="Zipcode Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="zipTextBox" ErrorMessage="Zipcode Format is Wrong" ForeColor="#CC0000"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Email Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Email Format is Wrong" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Social Security</td>
                <td class="auto-style4">
                    <asp:TextBox ID="socialTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="socialTextBox" ErrorMessage="Social Security Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="socialTextBox" ErrorMessage="Social Security Format is Wrong" ForeColor="#CC0000" ValidationExpression="\d{3}-\d{2}-\d{4}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Phone Number</td>
                <td class="auto-style4">
                    <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="phoneTextBox" ErrorMessage="Phone Number Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="phoneTextBox" ErrorMessage="Phone Number Format is Wrong" ForeColor="#CC0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
