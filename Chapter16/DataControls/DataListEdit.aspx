<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataListEdit.aspx.vb" Inherits="DataControls.DataListEdit"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>DataList Editing</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:datalist id="listAuthor" style="Z-INDEX: 101; LEFT: 31px; POSITION: absolute; TOP: 39px" runat="server" Width="350px" Height="565px" BorderStyle="Ridge" BorderWidth="3px" CellPadding="5">
				<ItemTemplate>
					<b>
						<%# Container.DataItem("au_fname") %>
						<%# Container.DataItem("au_lname") %>
					</b>(<%# Container.DataItem("au_id") %>)<br>
					Address:
					<%# Container.DataItem("address") %>
					<br>
					City:
					<%# Container.DataItem("city") %>
					<br>
					<asp:Button CommandName="Edit" Text="Edit" Runat="server" />
				</ItemTemplate>
				<EditItemTemplate>
					<b>
						<%# Container.DataItem("au_fname") %>
						<%# Container.DataItem("au_lname") %>
					</b>(
					<asp:Label Text='<%# Container.DataItem("au_id") %>' id=lblID runat=server />)<br>
					Address:
					<asp:TextBox Text='<%# Container.DataItem("address") %>' id="txtAddress" runat=server /><br>
					City:
					<asp:TextBox Text='<%# Container.DataItem("city") %>' id="txtCity" runat=server /><br>
					<asp:Button CommandName="Update" Text="Update" Runat="server" />
					<asp:Button CommandName="Cancel" Text="Cancel" Runat="server" />
				</EditItemTemplate>
				<SeparatorTemplate>
					<hr>
				</SeparatorTemplate>
			</asp:datalist><asp:label id="lblStatus" style="Z-INDEX: 102; LEFT: 432px; POSITION: absolute; TOP: 56px" runat="server" Width="232px" Height="56px" EnableViewState="False" ForeColor="#C04000" Font-Bold="True" Font-Names="Verdana"></asp:label></form>
	</body>
</HTML>
