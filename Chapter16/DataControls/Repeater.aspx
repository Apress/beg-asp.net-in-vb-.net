<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Repeater.aspx.vb" Inherits="DataControls.Repeater"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Repeater id="repeatAuthor" runat="server">
				<HeaderTemplate>
					<h3>The Repeater:</h3>
					<table bgcolor="LightYellow" border="2">
				</HeaderTemplate>
				<ItemTemplate>
					<tr>
						<td><%# Container.DataItem("au_fname") %></td>
					</tr>
				</ItemTemplate>
				<FooterTemplate>
					</table>
				</FooterTemplate>
			</asp:Repeater>&nbsp;
		</form>
	</body>
</HTML>
