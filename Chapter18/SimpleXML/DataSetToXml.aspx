<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataSetToXml.aspx.vb" Inherits="SimpleXML.DataSetToXml"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>DataSetToXml</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:Xml id="XmlControl" runat="server" DocumentSource="SuperProTransform.xml" TransformSource="SuperProProductList.xslt"></asp:Xml></P>
			<P>&nbsp;</P>
		</form>
	</body>
</HTML>
