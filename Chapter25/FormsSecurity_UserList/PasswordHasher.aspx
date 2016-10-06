<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PasswordHasher.aspx.vb" Inherits="FormsSecurity_UserList.PasswordHasher"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>PasswordHasher</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; FONT-SIZE: x-small; Z-INDEX: 101; LEFT: 8px; BORDER-LEFT: 2px groove; WIDTH: 512px; BORDER-BOTTOM: 2px groove; FONT-FAMILY: Verdana; POSITION: absolute; TOP: 8px; HEIGHT: 248px" ms_positioning="GridLayout">
				<asp:TextBox id="txtPassword" style="Z-INDEX: 100; LEFT: 136px; POSITION: absolute; TOP: 24px" runat="server" Width="152px"></asp:TextBox>
				<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 30px" runat="server" Width="104px">Text to Hash:</asp:Label>
				<asp:Button id="cmdHash" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 144px" runat="server" Width="113px" Text="Hash"></asp:Button>
				<asp:RadioButton id="optSHA1" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 72px" runat="server" Width="232px" Text="Use the SHA1 Algorithm" Height="16px" Checked="True"></asp:RadioButton>
				<asp:RadioButton id="optMD5" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 96px" runat="server" Width="248px" Text="Use the MD5 Algorithm" Height="16px"></asp:RadioButton>
				<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 197px" runat="server" Width="96px"> Hashed Value:</asp:Label>
				<asp:TextBox id="txtHash" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 192px" runat="server" Width="354px" ReadOnly="True"></asp:TextBox></DIV>
		</form>
	</body>
</HTML>
