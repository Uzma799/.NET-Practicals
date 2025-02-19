<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract5a.aspx.cs" Inherits="Practical_5.pract5a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SiteMapPath ID="SiteMapPath1" runat="server">
            </asp:SiteMapPath>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/page1.aspx">Go to page1</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/page2.aspx">Go to page2</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/page3.aspx">Go to page3</asp:HyperLink>
        </div>
    </form>
</body>
</html>
