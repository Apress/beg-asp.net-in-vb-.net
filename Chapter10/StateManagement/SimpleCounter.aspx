<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SimpleCounter.aspx.vb" Inherits="StateManagement.SimpleCounter"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SimpleCounter</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblCount" style="Z-INDEX: 101; LEFT: 21px; POSITION: absolute; TOP: 25px" runat="server" Width="232px" Height="61px" Font-Size="Large" Font-Names="Verdana" Font-Bold="True"></asp:Label>
			<asp:Button id="cmdIncrement" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 112px" runat="server" Width="88px" Text="Increment"></asp:Button>
		</form>
	</body>
</HTML>
