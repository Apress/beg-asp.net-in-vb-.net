<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TablePictures.aspx.vb" Inherits="WebControls.TablePictures" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			Rows:
			<asp:textbox id="txtRows" runat="server"></asp:textbox>&nbsp;Cols:
			<asp:textbox id="txtCols" runat="server"></asp:textbox><BR>
			<BR>
			<asp:checkbox id="chkBorder" runat="server" Text="Put Border Around Cells"></asp:checkbox><BR>
			<BR>
			<asp:button id="cmdCreate" runat="server" Text="Create"></asp:button><BR>
			<BR>
			<asp:Table id="tbl" runat="server"></asp:Table></form>
	</body>
</HTML>
