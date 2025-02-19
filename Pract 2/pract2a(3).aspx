<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract2a(3).aspx.cs" Inherits="Practical_2.pract2a_3_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 15px">
    <form id="form1" runat="server">
        <div>
            Enter Value of a:
            <asp:TextBox ID="TextBox1" runat="server" Width="129px"></asp:TextBox>
            <br />
            Enter Value of b:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Enter Value of c:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
            <br />
&nbsp;<br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
