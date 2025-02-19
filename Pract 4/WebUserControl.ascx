<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl.ascx.cs" Inherits="Practical_4.WebUserControl" %>
<h3>This is User Contro1 </h3>
<table>
<tr>
<td>Name</td>
<td>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>City</td>
<td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
</tr>

<tr>
<td></td>
<td>
</td>
</tr>
<tr>
<td></td>
<td>
<asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
</td>
</tr>
</table><br />