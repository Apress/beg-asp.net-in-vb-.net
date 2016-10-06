<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TreeFrame.aspx.vb" Inherits="IEControls.TreeFrame"%>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>TreeViewTest</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<iewc:TreeView id="TreeView1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server" Width="228px" Height="363px" AutoPostBack="True" BorderStyle="None" BorderWidth="2px" Indent="15">
				<iewc:TreeNodeType ImageUrl="folder.gif" Type="Folder"></iewc:TreeNodeType>
				<iewc:TreeNodeType ImageUrl="page.gif" Type="Page"></iewc:TreeNodeType>
			</iewc:TreeView>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 20px; POSITION: absolute; TOP: 264px" runat="server" Height="80px" Width="316px">Note: None of the links under My Site will work, because these pages do not exist.</asp:Label>
		</form>
	</body>
</HTML>
