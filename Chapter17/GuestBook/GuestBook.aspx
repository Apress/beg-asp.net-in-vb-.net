<%@ Page Language="vb" AutoEventWireup="false" Codebehind="GuestBook.aspx.vb" Inherits="GuestBook.GuestBook" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:DataList id="GuestBookList" runat="server" BorderColor="#CC9966" BorderStyle="None" BackColor="White" CellPadding="4" GridLines="Both" BorderWidth="1px">
					<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<ItemTemplate>
						Left By:
						<%# Databinder.Eval(Container.DataItem, "Author") %>
						<br>
						<b>
							<%# Databinder.Eval(Container.DataItem, "Message") %>
						</b>
						<br>
						Left On:
						<%# Databinder.Eval(Container.DataItem, "Submitted") %>
					</ItemTemplate>
					<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
				</asp:DataList></P>
			<DIV style="WIDTH: 560px; POSITION: relative; HEIGHT: 248px" ms_positioning="GridLayout">
				<asp:Label id="Label1" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Width="104px" Height="24px">Your Name:</asp:Label>
				<asp:Label id="Label2" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 48px" runat="server" Width="104px" Height="24px">Your Message:</asp:Label>
				<asp:TextBox id="txtName" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 16px" runat="server" Width="392px"></asp:TextBox>
				<asp:TextBox id="txtMessage" style="Z-INDEX: 104; LEFT: 136px; POSITION: absolute; TOP: 48px" runat="server" Width="392px" Height="154px" TextMode="MultiLine"></asp:TextBox>
				<asp:Button id="cmdSubmit" style="Z-INDEX: 105; LEFT: 136px; POSITION: absolute; TOP: 208px" runat="server" Width="104px" Text="Submit"></asp:Button></DIV>
		</form>
	</body>
</HTML>
