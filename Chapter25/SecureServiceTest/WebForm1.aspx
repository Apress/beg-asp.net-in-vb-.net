<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="SecureServiceTest.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblInfo" style="Z-INDEX: 100; LEFT: 20px; POSITION: absolute; TOP: 84px" runat="server" Width="648px" Height="117px" Font-Names="Verdana" Font-Bold="True" Font-Size="Large"></asp:Label>
			<asp:Button id="cmdAuthenticated" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 16px" runat="server" Width="228px" Text="Make an Authenticated Call"></asp:Button>
			<asp:Button id="cmdUnauthenticated" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server" Width="228px" Text="Make an Unauthenticated Call"></asp:Button>
		</form>
	</body>
</HTML>
