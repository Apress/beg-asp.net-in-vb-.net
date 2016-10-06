<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CalendarTest.aspx.vb" Inherits="RichControls.CalendarTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:Calendar id="Calendar1" runat="server" SelectionMode="DayWeekMonth" BorderWidth="1px" BackColor="#FFFFCC" Width="220px" DayNameFormat="FirstLetter" ForeColor="#663399" Height="200px" Font-Size="8pt" Font-Names="Verdana" BorderColor="#FFCC66" ShowGridLines="True">
					<TodayDayStyle ForeColor="White" BackColor="#FFCC66"></TodayDayStyle>
					<SelectorStyle BackColor="#FFCC66"></SelectorStyle>
					<NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC"></NextPrevStyle>
					<DayHeaderStyle Height="1px" BackColor="#FFCC66"></DayHeaderStyle>
					<SelectedDayStyle Font-Bold="True" BackColor="#CCCCFF"></SelectedDayStyle>
					<TitleStyle Font-Size="9pt" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
				</asp:Calendar></P>
			<P>
				<asp:Label id="lbl" runat="server" Width="544px" Height="72px" Font-Size="Small" Font-Names="Verdana" Font-Bold="True">Look for the month of May ...</asp:Label></P>
		</form>
	</body>
</HTML>
