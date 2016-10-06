<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EventReviewPage.aspx.vb" Inherits="ErrorHandling.EventReviewPage"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Event Review Utility</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="lblResult" style="Z-INDEX: 100; LEFT: 32px; POSITION: absolute; TOP: 160px" runat="server" Width="674px" Height="16px" Font-Names="Verdana" Font-Size="Smaller" BorderStyle="Inset" BorderWidth="1px" BackColor="#FFFFC0"></asp:label><asp:textbox id="txtLog" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 32px" runat="server" Width="193px" Height="24px">Application</asp:textbox><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 40px" runat="server" Width="96px" Height="16px" Font-Names="Verdana" Font-Size="Smaller">Log:</asp:label><asp:textbox id="txtSource" style="Z-INDEX: 102; LEFT: 128px; POSITION: absolute; TOP: 64px" runat="server" Width="193px" Height="24px">ErrorTestLog_Page</asp:textbox><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 64px" runat="server" Width="96px" Height="16px" Font-Names="Verdana" Font-Size="Smaller">Source:</asp:label><asp:button id="cmdGet" style="Z-INDEX: 104; LEFT: 200px; POSITION: absolute; TOP: 104px" runat="server" Width="120px" Text="Get Entries" Font-Names="Verdana" Font-Size="Smaller"></asp:button><asp:checkbox id="chkAll" style="Z-INDEX: 105; LEFT: 336px; POSITION: absolute; TOP: 32px" runat="server" Width="224px" Height="40px" Text="Get All Entries for this Log (May Be Extremely Slow)" AutoPostBack="True" Font-Names="Verdana" Font-Size="Smaller"></asp:checkbox></form>
	</body>
</HTML>
