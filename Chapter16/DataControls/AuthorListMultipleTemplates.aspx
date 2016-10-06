<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AuthorListMultipleTemplates.aspx.vb" Inherits="DataControls.AuthorListMultipleTemplates"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Author List With Multiple Templates</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:datalist id="listAuthor" runat="server">
				<HeaderTemplate>
					<h2>Author List</h2>
					<br>
					<hr>
				</HeaderTemplate>
				<ItemTemplate>
					<b>
						<%# Container.DataItem("au_fname") %>
						<%# Container.DataItem("au_lname") %>
					</b>
					<br>
					Address:
					<%# Container.DataItem("address") %>
					<br>
					City:
					<%# Container.DataItem("city") %>
				</ItemTemplate>
				<AlternatingItemTemplate>
					&nbsp;&nbsp;&nbsp; <b>
						<%# Container.DataItem("au_fname") %>
						<%# Container.DataItem("au_lname") %>
					</b>
					<br>
					&nbsp;&nbsp;&nbsp; Address:
					<%# Container.DataItem("address") %>
					<br>
					&nbsp;&nbsp;&nbsp; City:
					<%# Container.DataItem("city") %>
				</AlternatingItemTemplate>
				<SeparatorTemplate>
					<br>
					<hr>
					<br>
				</SeparatorTemplate>
				<FooterTemplate>
					<br>
					This list provided on
					<%# System.DateTime.Now %>
				</FooterTemplate>
			</asp:datalist>
		</form>
	</body>
</HTML>
