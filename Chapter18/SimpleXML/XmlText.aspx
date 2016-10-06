<%@ Page Language="vb" AutoEventWireup="false" Codebehind="XmlText.aspx.vb" Inherits="SimpleXML.XmlText"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>XmlText</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			&nbsp;
			<asp:Label id="lblStatus" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 152px" runat="server" Width="512px" Height="32px" Font-Size="X-Small" Font-Names="Verdana" EnableViewState="False"></asp:Label>
			<asp:DataGrid id="dgResults" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 200px" runat="server" Width="432px" Height="112px" EnableViewState="False"></asp:DataGrid>
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 104; LEFT: 24px; BORDER-LEFT: 2px groove; WIDTH: 576px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 16px; HEIGHT: 104px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout"><asp:button id="cmdCreate" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Text="Create XML File" Width="128px" Height="32px" Font-Size="X-Small" Font-Names="Tahoma"></asp:button><asp:button id="cmdNodes" style="Z-INDEX: 102; LEFT: 328px; POSITION: absolute; TOP: 16px" runat="server" Text="Display Nodes From File" Width="208px" Height="29px" Font-Names="Tahoma"></asp:button><asp:button id="cmdDisplay" style="Z-INDEX: 103; LEFT: 328px; POSITION: absolute; TOP: 48px" runat="server" Text="Display Data From File" Width="208px" Height="29px" Font-Size="Smaller" Font-Names="Tahoma"></asp:button></DIV>
		</form>
	</body>
</HTML>
