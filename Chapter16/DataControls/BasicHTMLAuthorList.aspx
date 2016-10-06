<%@ Page Language="vb" AutoEventWireup="false" Codebehind="BasicHTMLAuthorList.aspx.vb" Inherits="DataControls.BasicHTMLAuthorList"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Basic HTML Author List</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataList id="listAuthor" runat="server">
				<ItemTemplate>
					<font face="Verdana" size="2"><b>
							<%# Container.DataItem("au_fname") %>
							<%# Container.DataItem("au_lname") %>
						</b></font>
					<br>
					<font face="Verdana" size="1">&nbsp;&nbsp;&nbsp; Address:
						<%# Container.DataItem("address") %>
						<br>
						&nbsp;&nbsp;&nbsp; City:
						<%# Container.DataItem("city") %>
					</font>
					<br>
					<br>
				</ItemTemplate>
			</asp:DataList>
		</form>
	</body>
</HTML>
