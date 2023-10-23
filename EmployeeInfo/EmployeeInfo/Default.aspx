<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeInfo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Information</h2>
            <br />
            Name:
            <asp:TextBox ID="TxtName" runat="server" Width="266px"></asp:TextBox>
            <br />
            <br />
            Select Office:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="23px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="202px">
                <asp:ListItem>Pick city</asp:ListItem>
                <asp:ListItem>Panjim</asp:ListItem>
                <asp:ListItem>Verna</asp:ListItem>
                <asp:ListItem>Margao</asp:ListItem>
                <asp:ListItem>Ponda</asp:ListItem>
            </asp:DropDownList>
&nbsp;
            <asp:Label ID="LblResult" runat="server"></asp:Label>
            <br />
            <br />
            Department:<br />
            <asp:RadioButton ID="RdoHR" runat="server" GroupName="Department" Text="HR" />
            <br />
            <asp:RadioButton ID="RdoAccounts" runat="server" GroupName="Department" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Accounts" />
        </div>
        <asp:RadioButton ID="RdoSoftware" runat="server" GroupName="Department" OnCheckedChanged="Software_CheckedChanged" Text="Software" />
        <br />
        <br />
        Qualification:<br />
        <asp:CheckBox ID="ChkBE" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="B.E" />
        <br />
        <asp:CheckBox ID="ChkMBA" runat="server" Text="MBA" />
        <br />
        <asp:CheckBox ID="ChkPHD" runat="server" Text="PHD" />
        <br />
        <br />
        <asp:Button ID="LblFullResult" runat="server" OnClick="LblFullResult_Click" Text="Go" />
        <br />
    </form>
</body>
</html>
