<%@ Page Language="vb" AutoEventWireup="false" Codebehind="IssueReporter.aspx.vb" Inherits="IssueReporter.IssueReporter" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 54px" runat="server" Font-Names="Verdana" Font-Size="X-Small">Your Name:</asp:Label>
			<asp:TextBox id="txtComment" style="Z-INDEX: 107; LEFT: 176px; POSITION: absolute; TOP: 112px" runat="server" Width="384px" Height="112px" TextMode="MultiLine" Font-Names="Verdana" Font-Size="X-Small"></asp:TextBox>
			<asp:TextBox id="txtSender" style="Z-INDEX: 106; LEFT: 176px; POSITION: absolute; TOP: 80px" runat="server" Width="259px" Height="24px" Font-Names="Verdana" Font-Size="X-Small"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 86px" runat="server" Font-Names="Verdana" Font-Size="X-Small">Your Email:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 118px" runat="server" Width="104px" Height="16px" Font-Names="Verdana" Font-Size="X-Small">Comment:</asp:Label>
			<asp:CheckBox id="chkPriority" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 240px" runat="server" Width="416px" Height="24px" Text="Please Reply Immediately!" Font-Names="Verdana" Font-Size="X-Small"></asp:CheckBox>
			<asp:TextBox id="txtName" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 48px" runat="server" Width="258px" Height="24px" Font-Names="Verdana" Font-Size="X-Small"></asp:TextBox>
			<asp:Button id="cmdSend" style="Z-INDEX: 108; LEFT: 32px; POSITION: absolute; TOP: 288px" runat="server" Width="88px" Height="24px" Text="Send"></asp:Button>
			<asp:Label id="lblResult" style="Z-INDEX: 109; LEFT: 40px; POSITION: absolute; TOP: 352px" runat="server" Width="432px" Height="72px" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>
		</form>
	</body>
</HTML>
