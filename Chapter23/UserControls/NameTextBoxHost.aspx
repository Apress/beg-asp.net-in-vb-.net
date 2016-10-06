<%@ Register TagPrefix="uc1" TagName="NameTextBox" Src="NameTextBox.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NameTextBoxHost.aspx.vb" Inherits="UserControls.NameTextBoxHost"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NameTextBoxHost</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:NameTextBox id="NameTextBox1" runat="server"></uc1:NameTextBox>
			<asp:Button id="cmdGetNames" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server" Text="Get Names" Width="96px" Height="24px"></asp:Button>
			<asp:Label id="lblNames" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 104px" runat="server" Width="368px" Height="48px" EnableViewState="False"></asp:Label>
			<HR style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 48px" width="100%" SIZE="1">
		</form>
	</body>
</HTML>
