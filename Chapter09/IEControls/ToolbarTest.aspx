<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ToolbarTest.aspx.vb" Inherits="IEControls.ToolbarTest"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ToolbarTest</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<iewc:Toolbar id="Toolbar1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 12px" runat="server" Orientation="Vertical" Font-Names="Verdana" Font-Size="X-Small" Height="440px" Width="114px">
				<iewc:ToolbarButton Text="Get Help" ImageUrl="CHM.gif"></iewc:ToolbarButton>
				<iewc:ToolbarSeparator></iewc:ToolbarSeparator>
				<iewc:ToolbarButton Text="&amp;nbsp;Page 1" ImageUrl="folder.gif"></iewc:ToolbarButton>
				<iewc:ToolbarButton Text="&amp;nbsp;Page 2" ImageUrl="folder.gif"></iewc:ToolbarButton>
				<iewc:ToolbarButton Text="&amp;nbsp;Page 3" ImageUrl="folder.gif"></iewc:ToolbarButton>
			</iewc:Toolbar>
			<DIV id="DIV1" style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 102; LEFT: 120px; BORDER-LEFT: 2px groove; WIDTH: 528px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 13px; HEIGHT: 440px" ms_positioning="GridLayout">
				<asp:Label id="lblInfo" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 20px" runat="server" Width="464px" Height="208px" Font-Names="Verdana" Font-Size="Large" Font-Bold="True"></asp:Label></DIV>
		</form>
	</body>
</HTML>
