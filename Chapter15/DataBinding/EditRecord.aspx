<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EditRecord.aspx.vb" Inherits="DataBinding.EditRecord"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Record Editor</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id="lstProduct" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 24px" runat="server" Width="208px" Height="22px" AutoPostBack="True" Font-Names="Verdana" Font-Size="X-Small"></asp:DropDownList>
			<br>
			<br>
			<hr>
			<asp:Button id="cmdUpdate" style="Z-INDEX: 103; LEFT: 272px; POSITION: absolute; TOP: 264px" runat="server" Text="Update" Font-Names="Verdana" Font-Size="X-Small" Visible="False"></asp:Button>
			<asp:Label id="lblChoose" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 27px" runat="server" Width="113px" Height="16px" Font-Names="Verdana" Font-Size="X-Small">Choose Product:</asp:Label>
			<asp:Label id="lblRecordInfo" style="Z-INDEX: 104; LEFT: 14px; POSITION: absolute; TOP: 102px" runat="server" Height="96px" Width="250px" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>
			<asp:ListBox id="lstCategory" style="Z-INDEX: 105; LEFT: 272px; POSITION: absolute; TOP: 88px" runat="server" Height="172px" Width="248px" Font-Names="Verdana" Font-Size="X-Small" Visible="False"></asp:ListBox>
		</form>
	</body>
</HTML>
