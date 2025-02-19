<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract4b.aspx.cs" Inherits="Practical_4.pract4b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator" runat="server" DataSourceID="Ads" />
            <asp:XmlDataSource ID="Ads" runat="server"
                DataFile="~/ads.xml" OnTransforming="Ads_Transforming"></asp:XmlDataSource>
        </div>
    </form>
</body>
</html>
