<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PreserveMembers.aspx.vb" Inherits="StateManagement.PreserveMembers"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>PreserveMembers</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="txtValue" style="Z-INDEX: 100; LEFT: 19px; POSITION: absolute; TOP: 22px" runat="server" Width="440px" Height="104px" TextMode="MultiLine"></asp:TextBox>
			<asp:Button id="cmdLoad" style="Z-INDEX: 103; LEFT: 317px; POSITION: absolute; TOP: 144px" runat="server" Width="144px" Height="24px" Text="Load Contents"></asp:Button>
			<asp:Button id="cmdSave" style="Z-INDEX: 102; LEFT: 19px; POSITION: absolute; TOP: 144px" runat="server" Width="144px" Height="24px" Text="Save Contents"></asp:Button>
		</form>
	</body>
</HTML>
