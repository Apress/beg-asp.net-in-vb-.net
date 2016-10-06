<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NameTextBoxHost.aspx.vb" Inherits="CustomControls.NameTextBoxHost"%>
<%@ Register TagPrefix="cc1" Namespace="CustomControls.AdvancedControls" Assembly="CustomControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<cc1:nametextbox id="NameTextBox1" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Width="168px"></cc1:nametextbox>
			<HR style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 48px" width="100%" SIZE="1">
			<asp:button id="cmdGetNames" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 56px" runat="server" Width="96px" Text="Get Names" Height="24px"></asp:button><asp:label id="lblNames" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 104px" runat="server" Width="368px" Height="48px" EnableViewState="False"></asp:label></form>
	</body>
</HTML>
