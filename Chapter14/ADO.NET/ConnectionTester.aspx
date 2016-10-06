<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ConnectionTester.aspx.vb" Inherits="ADO.NET.ConnectionTester"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Connection Tester</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="cmdConnect" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server" Text="Connect"></asp:button><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 184px; POSITION: absolute; TOP: 24px" runat="server" BorderWidth="0px" Height="64px" Width="320px">
				<asp:RadioButton id="optSQL" runat="server" Text="Use SQL Authentication (with sa account)" GroupName="Authentication" Font-Size="Smaller" Font-Names="Verdana"></asp:RadioButton>
				<BR>
				<asp:RadioButton id="optWindows" runat="server" Text="Use Windows Integrated Authentication" GroupName="Authentication" Font-Size="Smaller" Font-Names="Verdana" Checked="True"></asp:RadioButton>
			</asp:panel><asp:label id="lblInfo" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 120px" runat="server" Height="128px" Width="464px" Font-Size="X-Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label></form>
	</body>
</HTML>
