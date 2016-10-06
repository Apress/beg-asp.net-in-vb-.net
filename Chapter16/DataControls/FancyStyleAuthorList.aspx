<%@ Page Language="vb" AutoEventWireup="false" Codebehind="FancyStyleAuthorList.aspx.vb" Inherits="DataControls.FancyStyleAuthorList"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Fancy Author List</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; FONT-SIZE: x-small; BORDER-LEFT: 2px groove; WIDTH: 512px; BORDER-BOTTOM: 2px groove; FONT-FAMILY: Verdana; POSITION: relative; HEIGHT: 146px" ms_positioning="GridLayout">
				<asp:Button id="cmdUpdate" style="Z-INDEX: 101; LEFT: 384px; POSITION: absolute; TOP: 104px" runat="server" Text="Refresh" Width="104px"></asp:Button>
				<asp:TextBox id="txtColumns" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 80px" runat="server" Width="120px"></asp:TextBox>
				<asp:RadioButton id="optVertical" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server" Text="Repeat Vertical" Width="224px" Height="16px" GroupName="Repeat" Checked="True"></asp:RadioButton>
				<asp:RadioButton id="optHorizontal" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 40px" runat="server" Text="Repeat Horizontal" Width="224px" Height="16px" GroupName="Repeat"></asp:RadioButton>
				<asp:Label id="Label1" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 80px" runat="server" Width="112px" Height="16px">Repeat Columns:</asp:Label></DIV>
			<P>
				<asp:datalist id="listAuthor" runat="server" BorderColor="#DEBA84" BorderStyle="None" CellSpacing="2" BackColor="#DEBA84" CellPadding="3" GridLines="Both" BorderWidth="1px">
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
					<ItemStyle Font-Size="Smaller" Font-Names="Verdana" ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
					<AlternatingItemStyle BackColor="#FFE0C0"></AlternatingItemStyle>
					<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
					<HeaderTemplate>
						<h2>Author List</h2>
					</HeaderTemplate>
					<FooterTemplate>
						<br>
						This list provided on
						<%# System.DateTime.Now %>
					</FooterTemplate>
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
					<SeparatorTemplate>
						<hr>
					</SeparatorTemplate>
				</asp:datalist><BR>
			</P>
		</form>
	</body>
</HTML>
