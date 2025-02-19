<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract2b(2)-multilevel_inheritance.aspx.cs" Inherits="Practical_2.pract2b_2__multilevel_inheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a number:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
            <br />
            <br />
            Power of 2:
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Power of 3:
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            Power of 4:
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
