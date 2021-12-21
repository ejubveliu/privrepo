<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Taschenrechner.web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="errormsg" runat="server" Visible="false">
                <asp:Label ID="errormsgtxt" runat="server"></asp:Label>
            </asp:Panel>
            <asp:TextBox ID="TxtBox" runat="server" ></asp:TextBox><br />
            <asp:Button ID="BtnClear" runat="server" Text="Clear" Height="35px" Width="65px" OnClick="Clear_Click" /><br />
            <asp:Button ID="BtnSeven" runat="server" Text="7" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnEight" runat="server" Text="8" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnNine" runat="server" Text="9" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnSlash" runat="server" Text="/" Height="50px" Width="50px" OnClick="Oper_Click" /><br />
            <asp:Button ID="BtnFour" runat="server" Text="4" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnFive" runat="server" Text="5" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnSix" runat="server" Text="6" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnMulti" runat="server" Text="*" Height="50px" Width="50px" OnClick="Oper_Click" /><br />
            <asp:Button ID="BtnOne" runat="server" Text="1" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnTwo" runat="server" Text="2" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnThree" runat="server" Text="3" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnMinus" runat="server" Text="-" Height="50px" Width="50px" OnClick="Oper_Click" /><br />
            <asp:Button ID="BtnZero" runat="server" Text="0" Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnDot" runat="server" Text="." Height="50px" Width="50px" OnClick="Oper_Click" />
            <asp:Button ID="BtnEqual" runat="server" Text="=" Height="50px" Width="50px" OnClick="Equal_Click" />
            <asp:Button ID="BtnPlus" runat="server" Text="+" Height="50px" Width="50px" OnClick="Oper_Click" />
        </div>
    </form>
</body>
</html>