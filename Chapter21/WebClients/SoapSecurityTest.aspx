<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SoapSecurityTest.aspx.vb" Inherits="WebClients.SoapSecurityTest"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SoapSecurityTest</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="cmdNoHeader" style="Z-INDEX: 101; LEFT: 33px; POSITION: absolute; TOP: 24px" runat="server" Text="Call Without Setting the Header" Width="264px" Height="40px"></asp:Button>
			<asp:Button id="cmdHeader" style="Z-INDEX: 102; LEFT: 320px; POSITION: absolute; TOP: 24px" runat="server" Text="Set the Header and Call" Width="264px" Height="40px"></asp:Button>&nbsp;
			<asp:Label id="lblResult" style="Z-INDEX: 103; LEFT: 40px; POSITION: absolute; TOP: 104px" runat="server" Width="544px" Height="120px"></asp:Label>
		</form>
	</body>
</HTML>
