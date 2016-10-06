<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AuthorBrowser.aspx.vb" Inherits="ADO.NET.AuthorBrowser"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Author Browser</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 24px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Width="181px" Height="20px"> Select Author:</asp:label><asp:label id="lblResults" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 64px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Width="384px" Height="168px"></asp:label><asp:dropdownlist id="lstAuthor" style="Z-INDEX: 102; LEFT: 184px; POSITION: absolute; TOP: 20px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Width="171px" Height="22px" AutoPostBack="True"></asp:dropdownlist></form>
	</body>
</HTML>
