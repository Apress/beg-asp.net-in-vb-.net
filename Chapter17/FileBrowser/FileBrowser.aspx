<%@ Page Language="vb" AutoEventWireup="false" Codebehind="FileBrowser.aspx.vb" Inherits="FileBrowser.FileBrowser" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>File Browser</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:ListBox id="lstDirs" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 72px" runat="server" Width="248px" Height="208px" Font-Names="Verdana"></asp:ListBox>
			<asp:Button id="cmdParent" style="Z-INDEX: 109; LEFT: 176px; POSITION: absolute; TOP: 280px" runat="server" Text="Up One Level" Width="100px" Height="24px"></asp:Button>
			<asp:Button id="cmdShowInfo" style="Z-INDEX: 107; LEFT: 312px; POSITION: absolute; TOP: 280px" runat="server" Text="Show Info"></asp:Button>
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 312px; POSITION: absolute; TOP: 56px" runat="server" Width="192px" Height="24px" Font-Names="Verdana" Font-Bold="True" Font-Size="X-Small">Contained Files:</asp:Label>
			<asp:ListBox id="lstFiles" style="Z-INDEX: 102; LEFT: 312px; POSITION: absolute; TOP: 72px" runat="server" Width="280px" Height="200px" Font-Names="Verdana"></asp:ListBox>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 56px" runat="server" Width="216px" Height="38px" Font-Names="Verdana" Font-Bold="True" Font-Size="X-Small">Subdirectories:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 16px" runat="server" Width="184px" Height="19px" Font-Names="Verdana" Font-Bold="True" Font-Size="Medium">Current Directory:</asp:Label>
			<asp:Button id="cmdBrowse" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 280px" runat="server" Text="Browse To Selected" Width="136px" Height="24px"></asp:Button>
			<asp:Label id="lblFileInfo" style="Z-INDEX: 108; LEFT: 312px; POSITION: absolute; TOP: 328px" runat="server" Width="280px" Height="80px" BorderStyle="Groove" BorderWidth="2px" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>
			<asp:Label id="lblCurrentDir" style="Z-INDEX: 110; LEFT: 240px; POSITION: absolute; TOP: 16px" runat="server" Width="184px" Height="24px" Font-Names="Verdana" Font-Bold="True" Font-Size="Medium"></asp:Label>
		</form>
	</body>
</HTML>
