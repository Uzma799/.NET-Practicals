<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract2b(2)-single_inheritance.aspx.cs" Inherits="Practical_2.pract2b_2__single_inheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a Number:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
            <br />
            <br />
            Square of the Number: <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Cube of the Number: <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
