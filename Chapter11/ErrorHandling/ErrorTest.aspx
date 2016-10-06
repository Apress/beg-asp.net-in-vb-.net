<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ErrorTest.aspx.vb" Inherits="ErrorHandling.ErrorTest"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Error Page</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="cmdError" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server" Text="Cause An Unhandled Error" Width="184px" Height="36px" Font-Names="Verdana" Font-Size="Smaller"></asp:Button>
			<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 152px; POSITION: absolute; TOP: 136px" runat="server" Width="16px" Height="16px" Font-Names="Verdana" Font-Size="Smaller">B:</asp:Label>
			<asp:TextBox id="txtA" style="Z-INDEX: 102; LEFT: 40px; POSITION: absolute; TOP: 136px" runat="server" Width="97px" Height="20px" Font-Names="Verdana" Font-Size="Smaller"></asp:TextBox>
			<asp:TextBox id="txtB" style="Z-INDEX: 103; LEFT: 168px; POSITION: absolute; TOP: 136px" runat="server" Width="97px" Height="20px" Font-Names="Verdana" Font-Size="Smaller"></asp:TextBox>
			<asp:Button id="cmdCompute" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 128px" runat="server" Text="Divide A / B" Width="152px" Height="32px" Font-Names="Verdana" Font-Size="Smaller"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 136px" runat="server" Width="16px" Height="16px" Font-Names="Verdana" Font-Size="Smaller">A:</asp:Label>
			<asp:Label id="lblResult" style="Z-INDEX: 107; LEFT: 32px; POSITION: absolute; TOP: 184px" runat="server" Width="592px" Height="96px" Font-Names="Verdana" Font-Size="Smaller"></asp:Label>
			<asp:Button id="cmdCustom" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 24px" runat="server" Height="36px" Width="376px" Text="Cause An Unhandled Error With A Custom Message" Font-Names="Verdana" Font-Size="Smaller"></asp:Button></form>
	</body>
</HTML>
