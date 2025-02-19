<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract10a.aspx.cs" Inherits="practical_10.pract10a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="xml writer" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="163px" Width="212px"></asp:ListBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="xml reader" />
        </div>
    </form>
</body>
</html>
