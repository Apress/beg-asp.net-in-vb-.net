<%@ Page Language="vb" AutoEventWireup="false" Codebehind="XmlTransform.aspx.vb" Inherits="SimpleXML.XmlTransform"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>XmlTransform</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:Label id="Label1" runat="server" Width="448px" Height="32px" Font-Names="Verdana" Font-Size="Larger" Font-Bold="True">The Contents of SuperProProductList.xml</asp:Label></P>
			<P>
				<asp:Xml id="Xml1" runat="server" DocumentSource="SuperProTransform.xml" TransformSource="SuperProProductList.xslt"></asp:Xml></P>
		</form>
	</body>
</HTML>
