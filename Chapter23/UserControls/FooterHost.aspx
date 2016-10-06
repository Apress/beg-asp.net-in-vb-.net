<%@ Page Language="vb" AutoEventWireup="false" Codebehind="FooterHost.aspx.vb" Inherits="UserControls.FooterHost"%>
<%@ Register TagPrefix="cr" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>FooterHost</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h2>A Page With a Configurable Footer</h2>
			<P><hr>
			<P></P>
			<P>
				<asp:RadioButton id="optShort" runat="server" Text="Short Format" GroupName="Format"></asp:RadioButton><BR>
				<asp:RadioButton id="optLong" runat="server" Text="Long Format" GroupName="Format"></asp:RadioButton><BR>
				<BR>
				<asp:Button id="cmdRefresh" runat="server" Text="Refresh"></asp:Button></P>
			<HR>
			<P>
				<cr:Footer id="Footer1" runat="server"></cr:Footer></P>
		</form>
	</body>
</HTML>
