<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:label runat="server" text="Label" ID="notALabel"></asp:label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" Height="58px" Width="128px"/>
        <br />
        <br />
        <asp:TextBox ID="TextBoxEnter" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonToUpper" runat="server" Text="To Upper" OnClick="ButtonToUpper_Click"/>
        <br />
        <br />
            <h3> Results: </h3>
                <span runat="server" id="changed_text" />
        <table style="width: 100%;">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="TextBoxPerson" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Street</td>
                <td>
                    <asp:TextBox ID="TextBoxStreet" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:TextBox ID="TextBoxState" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Submit</td>
                <td>
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit Address" OnClick="ButtonSubmit_Click"/>
                </td>
            </tr>
            <tr>
                <td>Display</td>
                <td id="displayRow" runat="server"></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
