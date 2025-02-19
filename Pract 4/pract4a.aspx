<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract4a.aspx.cs" Inherits="Practical_4.pract4a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Name Required" ForeColor="Green"></asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Password:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Password Required" ForeColor="Green"></asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
            &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="*Password should be same" ForeColor="Green"></asp:CompareValidator>
            <br />
            <br />
            Enter Email ID:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Enter correct email" ForeColor="Green" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Enter Age: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Age  between 18 to 30" ForeColor="Green" MaximumValue="30" MinimumValue="18" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
