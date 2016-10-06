<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ErrorTestLog.aspx.vb" Inherits="ErrorHandling.ErrorTestLog"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 32px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="16px" Height="16px">B:</asp:Label>
			<asp:TextBox id="txtA" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 32px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="97px" Height="20px"></asp:TextBox>
			<asp:TextBox id="txtB" style="Z-INDEX: 102; LEFT: 160px; POSITION: absolute; TOP: 32px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="97px" Height="20px"></asp:TextBox>
			<asp:Button id="cmdCompute" style="Z-INDEX: 103; LEFT: 280px; POSITION: absolute; TOP: 24px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="152px" Height="32px" Text="Divide A / B"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 32px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="16px" Height="16px">A:</asp:Label>
			<asp:Label id="lblResult" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 80px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="592px" Height="96px"></asp:Label>
			<asp:CheckBox id="chkLog" style="Z-INDEX: 107; LEFT: 456px; POSITION: absolute; TOP: 32px" runat="server" Font-Size="Smaller" Font-Names="Verdana" Width="240px" Height="24px" Text="Log errors to ProseTech log"></asp:CheckBox>
		</form>
	</body>
</HTML>
