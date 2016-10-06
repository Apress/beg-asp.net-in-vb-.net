<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AuthorListControls.aspx.vb" Inherits="DataControls.AuthorListControls"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Author List With Controls</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:datalist id="listAuthor" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server">
				<ItemTemplate>
					<asp:TextBox id=txtAddress Text='<%# Container.DataItem("address") %>' runat=server /><br>
					<asp:TextBox id=txtCity Text='<%# Container.DataItem("city") %>' runat=server /><br>
					<asp:Button id="cmdUpdate" Text='Update' runat="server"></asp:Button>
					(this button is not wired up)<br>
					<br>
				</ItemTemplate>
			</asp:datalist>
		</form>
	</body>
</HTML>
