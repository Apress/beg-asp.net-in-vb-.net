<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Cookieless1.aspx.vb" Inherits="CookielessSessions.Cookieless1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Cookieless1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:HyperLink id="lnkRedirect" style="Z-INDEX: 100; LEFT: 31px; POSITION: absolute; TOP: 32px" runat="server" Width="296px" Height="32px" NavigateUrl="Cookieless2.aspx">Go to Cookieless2 using a HyperLink control</asp:HyperLink>
			<asp:Button id="cmdLinkAbsolute" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 180px" runat="server" Width="264px" Text="Go to Cookieless2 using an absolute path"></asp:Button>
			<asp:Button id="cmdLink" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 104px" runat="server" Width="264px" Text="Go to Cookieless2 using a relative path"></asp:Button>
			<asp:Label id="lblInfo" style="Z-INDEX: 103; LEFT: 348px; POSITION: absolute; TOP: 32px" runat="server" Width="292px" Height="188px" Font-Names="Verdana" Font-Size="X-Small">Hyperlink.NavigateUrl is set to <b>
					"Cookieless1.aspx"</b> in code.<br><br><br>The relative path uses<br><b>Response.Redirect("Cookieless1.aspx")</b><br><br><br>The absoulte path uses <b>
					Response.Redirect("http://localhost/.../Cookieless2.aspx)"</b></asp:Label>
		</form>
	</body>
</HTML>
