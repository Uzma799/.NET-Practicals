<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract7a.aspx.cs" Inherits="Practical_7.pract7a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="accountnumber" DataValueField="accountnumber">
            </asp:DropDownList>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="accountnumber" DataValueField="accountnumber">
            </asp:DropDownList>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Bank Details]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Result" Height="24px" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
