<%@ Page Language="vb" AutoEventWireup="false" Codebehind="RegularExpressionTest.aspx.vb" Inherits="Validation.RegularExpressionTest" %>
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
			<asp:TextBox id="txtExpression" style="Z-INDEX: 104; LEFT: 224px; POSITION: absolute; TOP: 48px" runat="server" Width="192px" Height="24px"></asp:TextBox>
			<asp:Button id="cmdSetExpression" style="Z-INDEX: 103; LEFT: 424px; POSITION: absolute; TOP: 48px" runat="server" CausesValidation="False" Height="25px" Width="138px" Text="Set This Expression"></asp:Button>
			<asp:Label id="lblExpression" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server" Width="512px" Height="21px" Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True">Current Expression: (none)</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 106; LEFT: 88px; POSITION: absolute; TOP: 56px" runat="server" Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True">New Expression:</asp:Label>
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 110; LEFT: 16px; BORDER-LEFT: 2px groove; WIDTH: 584px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 120px; HEIGHT: 160px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout">
				<asp:ValidationSummary id="ValidationSummary1" style="Z-INDEX: 111; LEFT: 192px; POSITION: absolute; TOP: 88px" runat="server" Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True"></asp:ValidationSummary>
				<asp:RegularExpressionValidator id="TestValidator" style="Z-INDEX: 111; LEFT: 208px; POSITION: absolute; TOP: 64px" runat="server" ControlToValidate="txtValidate" ErrorMessage="Failed Validation" EnableClientScript="False" Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True"></asp:RegularExpressionValidator>
				<asp:TextBox id="txtValidate" style="Z-INDEX: 111; LEFT: 208px; POSITION: absolute; TOP: 24px" runat="server" Width="192px" Height="24px"></asp:TextBox>
				<asp:Button id="cmdValidate" style="Z-INDEX: 111; LEFT: 408px; POSITION: absolute; TOP: 24px" runat="server" Text="Validate" Width="139px" Height="24px"></asp:Button>
				<asp:Label id="Label2" style="Z-INDEX: 111; LEFT: 16px; POSITION: absolute; TOP: 32px" runat="server" Width="184px" Height="16px" Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True">Test Current Expression:</asp:Label></DIV>
		</form>
	</body>
</HTML>
