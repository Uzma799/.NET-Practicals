<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract2b(2)-hierarchical_inheritance.aspx.cs" Inherits="Practical_2.pract2b_2__hierarchical_inheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter b:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Result" />
            <br />
            <br />
            a+b= <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            a-b=
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
