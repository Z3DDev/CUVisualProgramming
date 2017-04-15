<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <!--Title of the Webpage-->
        <h1>Visual Programming Completion Mark</h1>
        <!--Subheader-->
        <p class="lead">Lets do a quiz (not an actual quiz)</p>
        <asp:Label ID="Label" runat="server" Text="Name"></asp:Label>
            <!--Created a TextBox named textName for the User to write their answer-->
            <asp:TextBox ID="textName" runat="server"></asp:TextBox>
            <!--Created a Button to allow the User to submit their written response-->
            <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <br />
        <!--Created a blank Label that will be used when the User submits their answer-->
        <asp:Label ID="UpdateLabel" runat="server" Text=""></asp:Label>
    </div>

    <div class="row">
        <div class="col-md-4">
            <!--Header for the Box at the Bottom-->
            <h2>GitHub</h2>
            <!--Letting people know, they should be using GitHub (important information here)-->
            <p>
                You should use GitHub, no questions asked. Best place to store your code. Do it.
            </p>
            <!--Clicking the Button redirects the user to an actual webpage-->
            <p>
                <a class="btn btn-default" href="https://github.com/Jagod101">Zach's GitHub &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
