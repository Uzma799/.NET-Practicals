<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract2a(4).aspx.cs" Inherits="Practical_2.pract2a_4_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Temperature in Celsius:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate to Fahrenheit" />
            <br />
            Converted to Fahrenheit:
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            Enter Temperature in Fahrenheit: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calculate to Celsius" />
            <br />
            Converted to Celsius:
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
