<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Taschenrechner.web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Clear" Height="35px" Width="65px" OnClick="clear_Click" /><br />
            <asp:Button ID="Button2" runat="server" Text="7" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button3" runat="server" Text="8" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button4" runat="server" Text="9" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button5" runat="server" Text="/" Height="50px" Width="50px" OnClick="oper_Click" /><br />
            <asp:Button ID="Button6" runat="server" Text="4" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button7" runat="server" Text="5" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button8" runat="server" Text="6" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button9" runat="server" Text="*" Height="50px" Width="50px" OnClick="oper_Click" /><br />
            <asp:Button ID="Button10" runat="server" Text="1" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button11" runat="server" Text="2" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button12" runat="server" Text="3" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button13" runat="server" Text="-" Height="50px" Width="50px" OnClick="oper_Click" /><br />
            <asp:Button ID="Button14" runat="server" Text="0" Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button15" runat="server" Text="." Height="50px" Width="50px" OnClick="oper_Click" />
            <asp:Button ID="Button16" runat="server" Text="=" Height="50px" Width="50px" OnClick="equal_Click" />
            <asp:Button ID="Button17" runat="server" Text="+" Height="50px" Width="50px" OnClick="oper_Click" />
        </div>
    </form>
</body>
</html>
