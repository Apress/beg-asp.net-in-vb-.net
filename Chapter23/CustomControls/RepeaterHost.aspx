<%@ Page Language="vb" AutoEventWireup="false" Codebehind="RepeaterHost.aspx.vb" Inherits="CustomControls.RepeaterHost"%>
<%@ Register TagPrefix="cc1" Namespace="CustomControls.AdvancedControls" Assembly="CustomControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>RepeaterHost</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<cc1:ConfigurableRepeaterControl id="Repeat" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server" Width="384px" Height="152px" Text="Repeated Text" Font-Bold="True" ForeColor="#C00000" BorderStyle="Groove" BorderWidth="2px" BorderColor="Transparent" BackColor="Honeydew" Font-Names="Cooper Black" Font-Size="Large" RepeatTimes="3"></cc1:ConfigurableRepeaterControl>
			<asp:Button id="cmdPostback" style="Z-INDEX: 103; LEFT: 232px; POSITION: absolute; TOP: 192px" runat="server" Width="168px" Text="Postback Page"></asp:Button>
			<asp:Button id="cmdSetRepeatTimes" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 192px" runat="server" Width="168px" Text="Set RepeatTimes = 5"></asp:Button>
		</form>
	</body>
</HTML>
