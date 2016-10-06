<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SecuredPage.aspx.vb" Inherits="FormsSecurity.SecuredPage"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SecuredPage</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblMessage" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Font-Bold="True" Font-Size="Medium" Font-Names="Verdana" EnableViewState="False">You have reached the secured page, </asp:Label>&nbsp;
		</form>
	</body>
</HTML>
