<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PizzaOrder._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">The Pizza Mania</h1>
            <br />
            <p class="auto-style1">
                <asp:RadioButton ID="RdoVeg" runat="server" GroupName="Category" Text="Veg" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RdoNonVeg" runat="server" GroupName="Category" Text="Non-Veg" />
            </p>
            <h4>Choose your pizza size:</h4>
            <asp:RadioButton ID="RdoS" runat="server" OnCheckedChanged="RdoS" Text="Small" />
&nbsp;Rs.100<br />
            <asp:RadioButton ID="RdoM" runat="server" OnCheckedChanged="RdoM" Text="Medium" />
&nbsp; Rs. 130<br />
            <asp:RadioButton ID="RdoL" runat="server" OnCheckedChanged="RdoL" Text="Large" />
&nbsp;Rs.160<br />
            <h4>Choose your base:</h4>
            <asp:RadioButton ID="RdoPan" runat="server" Text="Pan &amp; Hand  Tossed" />
            <br />
            <asp:RadioButton ID="RdoThin" runat="server" OnCheckedChanged="RdoThin" Text="Thin Crust" />
&nbsp;Rs. 20<br />
            <h4>Choose your toppings:</h4>
            <p>
                <asp:CheckBox ID="ChkBlackOlives" runat="server" Text="Black Olives Rs.10" />
            </p>
            <p>
                <asp:CheckBox ID="ChkBabyCorn" runat="server" Text="Baby Corn Rs. 8" />
            </p>
            <p>
                <asp:CheckBox ID="ChkMushroom" runat="server" Text="Mushroom Rs. 12" />
            </p>
            <p>
                <asp:CheckBox ID="ChkPaneer" runat="server" Text="Paneer Rs.10" />
            </p>
            <p>
                <asp:CheckBox ID="ChkRedPepper" runat="server" Text="Red Pepper Rs. 15" />
            </p>
            <p>
                <asp:CheckBox ID="ChkJalapeno" runat="server" Text="Jalapeno Rs. 10" />
            </p>
            <p>
                <asp:CheckBox ID="ChkChickenBarbecue" runat="server" OnCheckedChanged="CheckBox7_CheckedChanged1" Text="Chicken Barbecue Rs. 15" />
            </p>
            <p>
                <asp:CheckBox ID="ChkChunkyChicken" runat="server" Text="Chunky Chicken Rs. 8" />
            </p>
            <p>
                <asp:CheckBox ID="ChkChickenSausage" runat="server" Text="Chicken Sausage Rs. 10" />
            </p>
            <p>
                <asp:CheckBox ID="ChkChickenPepperoni" runat="server" Text="Chicken Pepperoni Rs. 15" />
            </p>
            <br />
            Make Your Pizza Cheesy<br />
            <asp:RadioButton ID="RdoCheese" runat="server" Text="Extra Cheese" />
&nbsp; Rs. 20<br />
            <br />
            <asp:Button ID="BtnOrder" runat="server" OnClick="BtnOrder" Text="Order" Width="131px" />
            <br />
            <br />
            Total: <asp:Label ID="LblTotal" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
