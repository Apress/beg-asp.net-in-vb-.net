<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ViewFiles.aspx.vb" Inherits="FileInfo.ViewFiles" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>File Information</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server" Font-Names="Verdana" Font-Bold="True">Files in the FTP Directory:</asp:Label>
			<asp:ListBox id="lstFiles" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 56px" runat="server" Width="256px" Height="264px" AutoPostBack="True" Font-Names="Verdana"></asp:ListBox>
			<asp:Button id="cmdRefresh" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 328px" runat="server" Width="72px" Height="32px" Text="Refresh"></asp:Button>
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 296px; POSITION: absolute; TOP: 24px" runat="server" Width="248px" Height="24px" Font-Names="Verdana" Font-Bold="True">Selected File Information:</asp:Label>
			<asp:Label id="lblFileInfo" style="Z-INDEX: 105; LEFT: 296px; POSITION: absolute; TOP: 56px" runat="server" Width="312px" Height="264px" BorderStyle="Groove" BorderWidth="2px" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>
			<asp:Button id="cmdDelete" style="Z-INDEX: 106; LEFT: 520px; POSITION: absolute; TOP: 328px" runat="server" Width="89px" Height="32px" Text="Delete File" EnableViewState="False" Enabled="False"></asp:Button>
		</form>
	</body>
</HTML>
