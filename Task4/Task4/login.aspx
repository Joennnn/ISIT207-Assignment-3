<%@ Page Title="Login Page" Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Task4.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <link href="~/css/task4.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
</head>
<body>
    <h3 class="text" style="margin-left:0;">Please login before browsing the website</h3>
    <form id="form1" runat="server">
        <div>
            <table>
                <h3 class="text" style="margin-left:0;">Login</h3>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="userlabel">Username: &nbsp;</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="usertext" runat="server" Height="20px" Width="150px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="passlabel">Password: &nbsp;</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="passtext" runat="server" TextMode="Password" Height="20px" Width="150px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Remember me: </asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox runat="server" ID="rememberme" OnCheckedChanged="rememberme_CheckedChanged"/> 
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label runat="server" ID="incorrecttext" ForeColor="red">Incorrect login credentials</asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="loginbtn" Text="Login" OnClick="loginbtn_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
