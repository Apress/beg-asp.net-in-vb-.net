<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MutlipleViews.aspx.vb" Inherits="DataCaching.MutlipleViews"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>MutlipleViews</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="lblCacheStatus" style="Z-INDEX: 100; LEFT: 320px; POSITION: absolute; TOP: 216px" runat="server" Width="264px" Height="24px" Font-Size="X-Small" Font-Names="Verdana"></asp:label><asp:label id="Label1" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Width="152px" Height="40px" Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True">Hide Columns:</asp:label><asp:checkboxlist id="chkColumns" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 40px" runat="server" Width="232px" Height="120px" Font-Size="XX-Small" Font-Names="Verdana" RepeatColumns="2"></asp:checkboxlist><asp:datagrid id="gridPubs" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 256px" runat="server" Width="384px" Height="120px" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" Font-Size="X-Small" Font-Names="Verdana" EnableViewState="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
				<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
				<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
				<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
			</asp:datagrid><asp:button id="cmdApply" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 184px" runat="server" Width="72px" Text="Filter"></asp:button>
			<HR style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 240px" width="100%" SIZE="1">
		</form>
	</body>
</HTML>
