<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract3b.aspx.cs" Inherits="Practical_3.pract3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnDayRender="Calendar1_DayRender" Width="220px" 
                OnSelectionChanged="Calendar1_SelectionChanged" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" > <DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC" />
                <NextPrevStyle BorderStyle="Solid" BorderWidth="2px" Font-Size="8pt" ForeColor="#CCCCFF" /> 
                <OtherMonthDayStyle BorderStyle="Solid" ForeColor="#999999" /> 
                <SelectedDayStyle BackColor="#009999" ForeColor="#CCFF99" Font-Bold="True" />  
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" BorderColor="#3366CC" BorderWidth="1px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" /> <WeekendDayStyle Height="50px" BackColor="#CCCCFF" /> </asp:Calendar>
            <br /> <div>
            Your Selected Date: <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Todays Date:
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            Ganati vacation start date: <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            Days Remainig for Ganpati Vacation:
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            Days Remaining for Christmas:
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
        </div>
    </form>
</body>
</html>
