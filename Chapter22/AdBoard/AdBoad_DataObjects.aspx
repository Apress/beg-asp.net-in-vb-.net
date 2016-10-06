<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AdBoad_DataObjects.aspx.vb" Inherits="AdBoard.AdBoad_DataObjects"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>AdBoard</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server" Width="64px" Height="16px" Font-Names="Verdana" Font-Size="X-Small">Category:</asp:label><asp:datagrid id="gridItems" style="Z-INDEX: 105; LEFT: 104px; POSITION: absolute; TOP: 336px" runat="server" Width="418px" Height="16px" Font-Names="Verdana" Font-Size="X-Small" BorderStyle="Outset" CellPadding="5"></asp:datagrid><asp:dropdownlist id="lstCategories" style="Z-INDEX: 102; LEFT: 104px; POSITION: absolute; TOP: 24px" runat="server" Width="264px" Height="24px" Font-Names="Verdana" Font-Size="X-Small"></asp:dropdownlist><asp:button id="cmdDisplay" style="Z-INDEX: 103; LEFT: 384px; POSITION: absolute; TOP: 24px" runat="server" Width="88px" Text="Display" Font-Names="Verdana" Font-Size="X-Small"></asp:button><asp:panel id="pnlNew" style="Z-INDEX: 104; LEFT: 104px; POSITION: absolute; TOP: 70px" runat="server" Width="448px" Height="238px">
				<DIV id="DIV1" style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; FONT-SIZE: x-small; BORDER-LEFT: 1px solid; WIDTH: 416px; BORDER-BOTTOM: 1px solid; FONT-FAMILY: Verdana; POSITION: relative; HEIGHT: 224px" ms_positioning="GridLayout">
					<asp:Button id="cmdAdd" style="Z-INDEX: 100; LEFT: 288px; POSITION: absolute; TOP: 184px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Width="88px" Text="Add"></asp:Button>
					<asp:Label id="Label2" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 48px" runat="server" Height="16px" Width="80px">Title:</asp:Label>
					<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 80px" runat="server" Height="16px" Width="80px">Price:</asp:Label>
					<asp:Label id="Label4" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 112px" runat="server" Height="16px" Width="80px">Description:</asp:Label>
					<asp:TextBox id="txtTitle" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 48px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Width="264px"></asp:TextBox>
					<asp:TextBox id="txtPrice" style="Z-INDEX: 105; LEFT: 112px; POSITION: absolute; TOP: 80px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Width="264px"></asp:TextBox>
					<asp:TextBox id="txtDescription" style="Z-INDEX: 106; LEFT: 112px; POSITION: absolute; TOP: 112px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Height="64px" Width="264px" TextMode="MultiLine"></asp:TextBox>
					<asp:Label id="Label5" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Font-Size="X-Small" Font-Names="Verdana" Height="16px" Width="296px" Font-Bold="True">Add Item To Current Category</asp:Label></DIV>
			</asp:panel></form>
	</body>
</HTML>
