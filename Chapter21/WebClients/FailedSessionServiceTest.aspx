<%@ Page Language="vb" AutoEventWireup="false" Codebehind="FailedSessionServiceTest.aspx.vb" Inherits="WebClients.FailedSessionServiceTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Failed Session Service Test</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="cmdGetCounter" style="Z-INDEX: 101; LEFT: 211px; POSITION: absolute; TOP: 41px" runat="server" Text="Get Usage Info" Width="155px" Height="36px"></asp:Button>
			<asp:Button id="cmdCallService" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 42px" runat="server" Text="Call Service" Width="154px" Height="36px"></asp:Button>
			<asp:Label id="lblResult" style="Z-INDEX: 103; LEFT: 37px; POSITION: absolute; TOP: 102px" runat="server" Width="422px" Height="304px"></asp:Label>
		</form>
	</body>
</HTML>
