<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Remindly.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="Style/Login.css">
</head>
<body style="height: 654px; width: 1104px">
    <form id="formlogin" runat="server">
        <div>
            <h1>&nbsp;</h1>
            <h1>Login</h1>
            <p>&nbsp;</p>
            <div>
                <p>
                    &nbsp;
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </p>
                <p>
                    Forgot Password?&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
                <asp:Button ID="BtnLogin" runat="server"/>
                <p>
                    Don&#39;t have a Remindly Account? <a href="Signup.aspx">Sign up! </a>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
