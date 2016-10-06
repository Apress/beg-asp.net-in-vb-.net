<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AdRotatorTest.aspx.vb" Inherits="RichControls.AdRotatorTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>AdRotator Test</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:AdRotator id="Ads" runat="server" Width="468px" Height="60px" AdvertisementFile="MainAds.xml"></asp:AdRotator><BR>
			</P>
			<P>&nbsp;</P>
			<P>
				<HR width="100%" SIZE="1">
			</P>
			<P>
				<asp:HyperLink id="lnkBanner" runat="server">HyperLink</asp:HyperLink></P>
		</form>
	</body>
</HTML>
