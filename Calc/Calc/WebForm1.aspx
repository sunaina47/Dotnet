<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            length:<asp:TextBox ID="TextLength" runat="server"></asp:TextBox>
            <br />
            <br />
            width:<asp:TextBox ID="TextWidth" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnArea" runat="server" OnClick="BtnArea_Click" Text="Area" />
            <br />
        </div>
        <asp:Label ID="LblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
