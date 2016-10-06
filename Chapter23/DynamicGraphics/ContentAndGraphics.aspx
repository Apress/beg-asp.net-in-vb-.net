<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ContentAndGraphics.aspx.vb" Inherits="DynamicGraphics.ContentAndGraphics"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>GraphicalText</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:Label id="Label1" runat="server">Here is some content.</asp:Label></P>
			<P>
				<asp:Image id="Image1" runat="server" ImageUrl="GraphicalText2.aspx?Name=Joe%20Brown"></asp:Image></P>
			<P>
				<asp:Label id="Label2" runat="server">Here is some more content.</asp:Label></P>
		</form>
	</body>
</HTML>
