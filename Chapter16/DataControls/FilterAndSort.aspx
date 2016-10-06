<%@ Page Language="vb" AutoEventWireup="false" Codebehind="FilterAndSort.aspx.vb" Inherits="DataControls.FilterAndSort"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>FilterAndSort</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="gridAuthor" style="Z-INDEX: 101; LEFT: 20px; POSITION: absolute; TOP: 24px" runat="server" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" Font-Names="Verdana" Font-Size="X-Small">
				<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
				<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
				<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
				<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
			</asp:DataGrid>&nbsp;
		</form>
	</body>
</HTML>
