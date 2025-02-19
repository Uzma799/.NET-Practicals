<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Practical_5.WebForm2" Theme="Skinfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" SkinId="lb1" Text="Enter Name:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">Go to page1</asp:HyperLink>
<br />
</asp:Content>
