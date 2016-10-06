<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Appointment.aspx.vb" Inherits="RichControls.Appointment" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Calendar id="Calendar1" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" SelectionMode="DayWeekMonth" BorderWidth="1px" BackColor="#FFFFCC" Width="220px" DayNameFormat="FirstLetter" ForeColor="#663399" Height="200px" Font-Size="8pt" Font-Names="Verdana" BorderColor="#FFCC66" ShowGridLines="True">
				<TodayDayStyle ForeColor="White" BackColor="#FFCC66"></TodayDayStyle>
				<SelectorStyle BackColor="#FFCC66"></SelectorStyle>
				<NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC"></NextPrevStyle>
				<DayHeaderStyle Height="1px" BackColor="#FFCC66"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" BackColor="#CCCCFF"></SelectedDayStyle>
				<TitleStyle Font-Size="9pt" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
			</asp:Calendar>
			<asp:ListBox id="lstTimes" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 248px" runat="server" Width="216px" Height="160px"></asp:ListBox>
		</form>
	</body>
</HTML>
