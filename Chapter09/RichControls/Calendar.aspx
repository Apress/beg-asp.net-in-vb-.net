<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Calendar.aspx.vb" Inherits="RichControls.Calendar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Calendar</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Calendar id="MyCalendar" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server" Width="293px" Height="226px" SelectionMode="DayWeekMonth"></asp:Calendar>
			<asp:Label id="lblDates" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 272px" runat="server" Width="544px" Height="72px" Font-Bold="True" Font-Names="Verdana" Font-Size="Small"></asp:Label></form>
	</body>
</HTML>
