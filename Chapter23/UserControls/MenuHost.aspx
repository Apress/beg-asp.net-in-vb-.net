<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MenuHost.aspx.vb" Inherits="UserControls.MenuHost"%>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>MenuHost</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:Menu id="Menu1" runat="server"></uc1:Menu>
			<asp:Label id="lblSelection" style="Z-INDEX: 101; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server" EnableViewState="False" Font-Size="Larger" Font-Names="Verdana" Font-Bold="True"></asp:Label>
		</form>
	</body>
</HTML>
