<%@ Register TagPrefix="uc1" TagName="LoginBox" Src="LoginBox.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ProtectedPage.aspx.vb" Inherits="UserControls.ProtectedPage"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ProtectedPage</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblSecretMessage" style="Z-INDEX: 101; LEFT: 64px; POSITION: absolute; TOP: 232px" runat="server" EnableViewState="False" Font-Size="Larger" Font-Names="Verdana" Font-Bold="True"></asp:Label>
			<asp:Panel id="pnlControls" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server" Width="248px" Height="160px">&nbsp; 
<uc1:LoginBox id="Login" runat="server"></uc1:LoginBox></asp:Panel>
		</form>
	</body>
</HTML>
