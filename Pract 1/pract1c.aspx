<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract1c.aspx.cs" Inherits="WebApplication1.pract1c" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Student Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Course Name:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Date of Birth:
            <br />
            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="2003-04-18"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Student ID:"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Student Name:"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Course Name:"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Date of Birth:"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
