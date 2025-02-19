<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract4c.aspx.cs" Inherits="Practical_4.pract4c" %>
<%@ Register Src="~/WebUserControl.ascx" TagPrefix="uc" TagName="Student"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:Student ID="WebUserControl" runat="server" />
        </div>
    </form>
</body>
</html>
