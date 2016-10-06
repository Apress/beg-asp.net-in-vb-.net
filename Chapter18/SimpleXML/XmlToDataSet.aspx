<%@ Page Language="vb" AutoEventWireup="false" Codebehind="XmlToDataSet.aspx.vb" Inherits="SimpleXML.XmlDataSet"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>XmlDataSet</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 106; LEFT: 8px; BORDER-LEFT: 2px groove; WIDTH: 576px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 8px; HEIGHT: 72px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout">
				<asp:button id="cmdDisplay" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Font-Names="Tahoma" Font-Size="Smaller" Height="29px" Width="208px" Text="Display Data From File"></asp:button></DIV>
			<asp:label id="lblStatus" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 112px" runat="server" Font-Names="Verdana" Font-Size="X-Small" Height="32px" Width="512px"></asp:label>
			<asp:datagrid id="dgResults" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 152px" runat="server" Height="112px" Width="432px"></asp:datagrid>
		</form>
	</body>
</HTML>
