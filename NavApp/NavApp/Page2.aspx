<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="NavApp.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 204px;
            height: 117px;
            border-width: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello from page 2<br />
            <br />
            <asp:Label ID="LblResult" runat="server"></asp:Label>
            <br />
            <br />
            <a href="default.aspx">
            <img class="auto-style1" src="images/coollogo.png" /></a></div>
    </form>
</body>
</html>
