<%@ Page Language="vb" AutoEventWireup="false" Codebehind="QueryStringSender.aspx.vb" Inherits="StateManagement.QueryStringSender"%>
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
			<asp:ListBox id="lstItems" style="Z-INDEX: 101; LEFT: 21px; POSITION: absolute; TOP: 26px" runat="server" Width="204px" Height="188px"></asp:ListBox>
			<asp:CheckBox id="chkDetails" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 224px" runat="server" Width="216px" Height="16px" Text="Show Full Details"></asp:CheckBox>
			<asp:Button id="cmdGo" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 272px" runat="server" Width="152px" Text="View Information"></asp:Button>
			<asp:Label id="lblError" style="Z-INDEX: 104; LEFT: 304px; POSITION: absolute; TOP: 64px" runat="server" Width="312px" Height="96px"></asp:Label>
		</form>
	</body>
</HTML>
