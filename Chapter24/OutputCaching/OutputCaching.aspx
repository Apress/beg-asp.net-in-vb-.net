<%@ Page Language="vb" AutoEventWireup="false" Codebehind="OutputCaching.aspx.vb" Inherits="Caching.OutputCaching"%>
<%@ OutputCache Duration="20" VaryByParam="None" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>OutputCaching</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblDate" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server" Width="528px" Height="112px" Font-Names="Verdana" Font-Size="X-Large"></asp:Label>&nbsp;
			<asp:Button id="cmdRefresh" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 168px" runat="server" Width="136px" Text="Refresh"></asp:Button>
		</form>
	</body>
</HTML>
