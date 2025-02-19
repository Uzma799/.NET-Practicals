<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract5c_viewstate.aspx.cs" Inherits="Practical_5.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View State:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="count" />
        </div>
    </form>
</body>
</html>
