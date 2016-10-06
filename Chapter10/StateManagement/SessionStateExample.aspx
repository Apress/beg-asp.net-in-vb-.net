<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SessionStateExample.aspx.vb" Inherits="StateManagement.SessionStateExample"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SessionStateExample</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblSession" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server" Width="232px" Height="61px" Font-Size="Medium" Font-Names="Verdana" Font-Bold="True"></asp:Label>
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 105; LEFT: 16px; BORDER-LEFT: 2px groove; WIDTH: 576px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 248px; HEIGHT: 160px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout">
				<asp:ListBox id="lstItems" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Width="208px" Height="128px"></asp:ListBox>
				<asp:Button id="cmdMoreInfo" style="Z-INDEX: 106; LEFT: 248px; POSITION: absolute; TOP: 24px" runat="server" Width="120px" Height="24px" Text="More Information"></asp:Button>
				<asp:Label id="lblRecord" style="Z-INDEX: 106; LEFT: 248px; POSITION: absolute; TOP: 64px" runat="server" Width="272px" Height="61px" Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True"></asp:Label></DIV>
		</form>
	</body>
</HTML>
