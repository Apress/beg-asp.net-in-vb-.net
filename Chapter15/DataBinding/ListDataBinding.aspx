<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ListDataBinding.aspx.vb" Inherits="DataBinding.ListDataBinding"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Data Binding Example</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:ListBox id="MyListBox" style="Z-INDEX: 101; LEFT: 23px; POSITION: absolute; TOP: 28px" runat="server" Width="197px" Height="193px"></asp:ListBox><SELECT id="MyHTMLSelect" style="Z-INDEX: 106; LEFT: 240px; WIDTH: 248px; POSITION: absolute; TOP: 80px; HEIGHT: 26px" size="1" name="Select1" runat="server">
				<OPTION selected></OPTION>
			</SELECT>
			<asp:DropDownList id="MyDropDownListBox" style="Z-INDEX: 102; LEFT: 240px; POSITION: absolute; TOP: 29px" runat="server" Width="248px" Height="22px"></asp:DropDownList>
			<asp:CheckBoxList id="MyCheckBoxList" style="Z-INDEX: 104; LEFT: 29px; POSITION: absolute; TOP: 243px" runat="server" Width="201px" Height="157px"></asp:CheckBoxList>
			<asp:RadioButtonList id="MyRadioButtonList" style="Z-INDEX: 105; LEFT: 257px; POSITION: absolute; TOP: 241px" runat="server" Width="249px" Height="158px"></asp:RadioButtonList>
		</form>
	</body>
</HTML>
