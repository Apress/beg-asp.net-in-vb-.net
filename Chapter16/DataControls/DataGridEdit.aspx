<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataGridEdit.aspx.vb" Inherits="DataControls.DataGridEdit"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Advanced DataGrid</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="gridAuthor" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True" PageSize="5" BorderWidth="1px" BorderColor="Gainsboro" CellPadding="10">
				<Columns>
					<asp:BoundColumn DataField="au_id" SortExpression="au_id" ReadOnly="True" HeaderText="ID"></asp:BoundColumn>
					<asp:TemplateColumn SortExpression="au_fname, au_lname" HeaderText="Author Name">
						<ItemTemplate>
							<%# Container.DataItem("au_fname") %>
							<%# Container.DataItem("au_lname") %>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox Text='<%# Container.DataItem("au_fname") %>' id="txtfname" runat=server /><br>
							<asp:TextBox Text='<%# Container.DataItem("au_lname") %>' id="txtlname" runat=server /><br>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="city" SortExpression="city" HeaderText="City"></asp:BoundColumn>
					<asp:BoundColumn DataField="address" SortExpression="address" HeaderText="Address"></asp:BoundColumn>
					<asp:EditCommandColumn ButtonType="PushButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
				</Columns>
			</asp:datagrid><asp:label id="lblStatus" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 352px" runat="server" EnableViewState="False"></asp:label></form>
	</body>
</HTML>
