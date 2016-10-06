<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataGridSelect.aspx.vb" Inherits="DataControls.DataGridSelect"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Select Data Grid</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="gridAuthor" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 20px" runat="server" AutoGenerateColumns="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<Columns>
					<asp:ButtonColumn Text="Select" ButtonType="PushButton" CommandName="Select"></asp:ButtonColumn>
					<asp:TemplateColumn HeaderText="Author Name">
						<ItemTemplate>
							<%# Container.DataItem("au_fname") %>
							<%# Container.DataItem("au_lname") %>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="city" HeaderText="City"></asp:BoundColumn>
					<asp:BoundColumn DataField="address" HeaderText="Address"></asp:BoundColumn>
				</Columns>
			</asp:DataGrid>&nbsp;
		</form>
	</body>
</HTML>
