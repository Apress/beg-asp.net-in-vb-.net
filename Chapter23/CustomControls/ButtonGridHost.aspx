<%@ Register TagPrefix="cc1" Namespace="CustomControls" Assembly="CustomControls" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ButtonGridHost.aspx.vb" Inherits="CustomControls.ButtonGridHost"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ButtonGridHost</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<cc1:ButtonGrid id="ButtonGrid1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 96px" runat="server" Width="488px" Height="264px"></cc1:ButtonGrid>
			<asp:TextBox id="txtCols" style="Z-INDEX: 105; LEFT: 192px; POSITION: absolute; TOP: 24px" runat="server" Width="72px"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 152px; POSITION: absolute; TOP: 24px" runat="server" Width="32px" Height="16px">Cols:</asp:Label>
			<asp:TextBox id="txtRows" style="Z-INDEX: 102; LEFT: 64px; POSITION: absolute; TOP: 24px" runat="server" Width="72px"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server" Width="40px" Height="16px">Rows:</asp:Label>
			<asp:Button id="cmdUpdate" style="Z-INDEX: 106; LEFT: 296px; POSITION: absolute; TOP: 24px" runat="server" Width="96px" Text="Update"></asp:Button>
			<asp:Label id="lblInfo" style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 64px" runat="server" Font-Bold="True"></asp:Label>
		</form>
	</body>
</HTML>
