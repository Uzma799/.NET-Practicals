<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract1d.aspx.cs" Inherits="WebApplication1.pract1d" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Number:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fibonacci Series" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            Enter Number:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Check Prime Number" />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            Enter Character:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Check Vowel" />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            Enter Number:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Reverse Number" />
&nbsp;<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            Enter Number:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Sum of Digit of a Number" />
&nbsp;<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Reading Array by For Each Loop:
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Display Array" />
&nbsp;<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
