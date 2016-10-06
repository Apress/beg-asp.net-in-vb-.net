<%@ Page Language="vb" AutoEventWireup="false" Codebehind="BasicAuthorList.aspx.vb" Inherits="DataControls.BasicAuthorList"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Basic Author List</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataList id="listAuthor" runat="server">
				<ItemTemplate>
					<%# Container.DataItem("au_lname") %>
					,
					<%# Container.DataItem("au_fname") %>
				</ItemTemplate>
			</asp:DataList>
		</form>
	</body>
</HTML>
