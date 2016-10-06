<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TraceExample.aspx.vb" Inherits="ErrorHandling.TraceExample"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Simple Tracer</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<DIV style="FONT-SIZE: x-small; WIDTH: 416px; FONT-FAMILY: Verdana; POSITION: relative; HEIGHT: 152px" ms_positioning="GridLayout">
				<asp:Button id="cmdWrite" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 64px" runat="server" Text="Write Message" Width="128px" Height="24px" Font-Size="X-Small" Font-Names="Verdana"></asp:Button>
				<asp:Label id="Label1" runat="server" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 16px">A Simple Tracing Example</asp:Label>
				<asp:Button id="cmdWriteCategory" style="Z-INDEX: 103; LEFT: 160px; POSITION: absolute; TOP: 64px" runat="server" Text="Write Message With Category" Width="216px" Height="24px" Font-Size="X-Small" Font-Names="Verdana"></asp:Button>
				<asp:Button id="cmdError" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 96px" runat="server" Text="Write Exception" Width="128px" Height="24px" Font-Size="X-Small" Font-Names="Verdana"></asp:Button>
				<asp:Button id="cmdSession" style="Z-INDEX: 105; LEFT: 160px; POSITION: absolute; TOP: 96px" runat="server" Text="Add Session Item" Width="136px" Height="24px" Font-Names="Verdana"></asp:Button></DIV>
		</form>
		<BR>
	</body>
</HTML>
