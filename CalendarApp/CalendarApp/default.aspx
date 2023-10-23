<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CalendarApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="228px" OnSelectionChanged="Calendar1_SelectionChanged" Width="319px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            <br />
            <asp:Calendar ID="Calendar2" runat="server" Height="246px" Width="319px"></asp:Calendar>
            <asp:Label ID="LblResult1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BtnGet" runat="server" OnClick="BtnGet_Click" Text="Get" />
&nbsp;
            <asp:Button ID="BtnSet" runat="server" OnClick="BtnSet_Click" Text="Set" />
&nbsp;&nbsp;
            <asp:Button ID="BtnDiff" runat="server" OnClick="BtnDiff_Click" Text="Diff" />
            <br />
            <br />
            <asp:Label ID="LblResult2" runat="server"></asp:Label>
&nbsp;
        </div>
    </form>
</body>
</html>
