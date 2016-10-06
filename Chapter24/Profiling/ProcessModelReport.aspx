<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ProcessModelReport.aspx.vb" Inherits="Profiling.ProcessModelReport"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ProcessModelInfo</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="dgProcess" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 80px" runat="server" Width="544px" Height="88px" Font-Names="Verdana" Font-Size="X-Small" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" EnableViewState="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
				<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
				<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
				<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
			</asp:datagrid>
			<asp:Button id="cmdHistory" style="Z-INDEX: 103; LEFT: 184px; POSITION: absolute; TOP: 24px" runat="server" Width="152px" Text="Show Process History"></asp:Button>
			<asp:Button id="cmdCurrent" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server" Width="152px" Text="Show Current Process"></asp:Button>
			<asp:Label id="lblInfo" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 80px" runat="server" Width="536px" Height="48px" Font-Names="Verdana" Font-Size="Medium" EnableViewState="False"></asp:Label></form>
	</body>
</HTML>
