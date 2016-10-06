<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Login.aspx.vb" Inherits="FormsSecurity.Login"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Login</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; FONT-SIZE: x-small; Z-INDEX: 101; LEFT: 15px; BORDER-LEFT: 2px groove; WIDTH: 421px; BORDER-BOTTOM: 2px groove; FONT-FAMILY: Verdana; POSITION: absolute; TOP: 21px; HEIGHT: 210px" ms_positioning="GridLayout">
				<asp:TextBox id="txtName" style="Z-INDEX: 100; LEFT: 136px; POSITION: absolute; TOP: 24px" runat="server" Width="152px"></asp:TextBox>
				<asp:TextBox id="txtPassword" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 64px" runat="server" Width="152px" TextMode="Password"></asp:TextBox>
				<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 30px" runat="server" Width="104px">Name:</asp:Label>
				<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 70px" runat="server" Width="104px">Password:</asp:Label>
				<asp:Button id="cmdLogin" style="Z-INDEX: 105; LEFT: 288px; POSITION: absolute; TOP: 168px" runat="server" Width="113px" Text="Login"></asp:Button>
				<asp:Label id="lblStatus" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: 168px" runat="server" Width="248px" Height="24px" ForeColor="#C00000"></asp:Label></DIV>
			<asp:Label id="Label3" style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 256px" runat="server" Width="256px" Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True">Password must be "secret"</asp:Label>
		</form>
	</body>
</HTML>
