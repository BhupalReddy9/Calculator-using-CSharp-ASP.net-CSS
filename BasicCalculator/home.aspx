<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BasicCalculator.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/style.css" rel="stylesheet" />
</head>
<body>
   <form id="form1" runat="server" class="Container">
        <main>
            <h1>Calculator</h1>
        </main>
        <div>

            <asp:TextBox ID="Output" CssClass="textbox" placeholder="  Ans:4" ReadOnly="true" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="Input" CssClass="textbox" placeholder="  Q: 2+2=?" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Button ID="AllClear" runat="server" Text="AC" OnClick="AllClear_Click" />
            <asp:Button ID="Clear" runat="server" Text="C" OnClick="Clear_Click" />
            <asp:Button ID="Delete" runat="server" Text="Del" OnClick="Delete_Click" />
            <asp:Button ID="Divide" runat="server" Text="/" OnClick="Divide_Click" />
        </div>

        <div>
            <asp:Button ID="seven" runat="server" Text="7" OnClick="seven_Click" />
            <asp:Button ID="eight" runat="server" Text="8" OnClick="eight_Click" />
            <asp:Button ID="nine" runat="server" Text="9" OnClick="nine_Click" />
            <asp:Button ID="multiple" runat="server" Text="*" OnClick="multiple_Click" />
        </div>
        <div>
            <asp:Button ID="four" runat="server" Text="4" OnClick="four_Click" />
            <asp:Button ID="five" runat="server" Text="5" OnClick="five_Click" />
            <asp:Button ID="six" runat="server" Text="6" OnClick="six_Click" />
            <asp:Button ID="minus" runat="server" Text="-" OnClick="minus_Click" />
        </div>
        <div>
            <asp:Button ID="one" runat="server" Text="1" OnClick="one_Click" />
            <asp:Button ID="two" runat="server" Text="2" OnClick="two_Click" />
            <asp:Button ID="three" runat="server" Text="3" OnClick="three_Click" />
            <asp:Button ID="plus" runat="server" Text="+" OnClick="plus_Click" />
        </div>
        <div>
            <asp:Button ID="zero" runat="server" Text="0" OnClick="zero_Click" />
            <asp:Button ID="dot" runat="server" Text="." OnClick="dot_Click" />
            <asp:Button ID="equalto" runat="server" Text="=" CssClass="equal" OnClick="equalto_Click" />
        </div>
    </form>
</body>
</html>
