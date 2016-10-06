<%@ Page Language="vb" AutoEventWireup="false" Codebehind="QueryStringSender.aspx.vb" Inherits="Caching.QueryStringSender"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>QueryStringSender</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="cmdLarge" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 80px" runat="server" Text="Large Text Version" Width="144px"></asp:Button>
			<asp:Button id="cmdNormal" style="Z-INDEX: 103; LEFT: 24px; TOP: 184px" runat="server" Text="Normal Version" Width="144px"></asp:Button>
			<asp:Button id="cmdSmall" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server" Text="Small Text Version" Width="144px"></asp:Button>
		</form>
	</body>
</HTML>
