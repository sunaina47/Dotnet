<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Craving.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What are you craving to eat from the following?<br />
            <asp:RadioButton ID="RdoPizza" runat="server" GroupName="Food" Text="Pizza" />
        </div>
        <asp:RadioButton ID="RdoBurger" runat="server" GroupName="Food" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Burger" />
        <br />
        <asp:RadioButton ID="RdoPasta" runat="server" GroupName="Food" Text="Pasta" />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnResult" runat="server" OnClick="BtnResult_Click" Text="Result" />
        <br />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="ImgFood" runat="server" Height="122px" />
        <br />
        <br />
        What&#39;s your favourite food?<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Pizza</asp:ListItem>
            <asp:ListItem>Butter Chicken</asp:ListItem>
            <asp:ListItem>Paneer Tikka</asp:ListItem>
            <asp:ListItem>Cake</asp:ListItem>
            <asp:ListItem>Ice Cream</asp:ListItem>
            <asp:ListItem>Fried Rice</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="BtnFood" runat="server" OnClick="BtnFood_Click" Text="Favourite Food" Width="233px" />
        <br />
        <br />
        <asp:Label ID="LblFood" runat="server"></asp:Label>
    </form>
</body>
</html>
