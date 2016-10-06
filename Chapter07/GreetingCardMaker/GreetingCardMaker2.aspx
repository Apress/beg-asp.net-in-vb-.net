<%@ Page Language="vb" AutoEventWireup="false" Codebehind="GreetingCardMaker2.aspx.vb" Inherits="GreetingCardMaker.GreetingCardMaker2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<META content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<META content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge; PADDING-LEFT: 20px; FONT-SIZE: x-small; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 293px; PADDING-TOP: 20px; BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 508px; BACKGROUND-COLOR: lightyellow" ms_positioning="FlowLayout">Choose 
				a background color:<BR>
				<asp:dropdownlist id="lstBackColor" runat="server" Height="22px" Width="194px" AutoPostBack="True"></asp:dropdownlist><BR>
				<BR>
				Choose a foreground (text) color:<BR>
				<asp:dropdownlist id="lstForeColor" runat="server" Height="22px" Width="194px" AutoPostBack="True"></asp:dropdownlist><BR>
				<BR>
				Choose a font name:<BR>
				<asp:dropdownlist id="lstFontName" runat="server" Height="22px" Width="194px" AutoPostBack="True"></asp:dropdownlist><BR>
				<BR>
				Specify&nbsp;a font size:<BR>
				<asp:textbox id="txtFontSize" runat="server" AutoPostBack="True"></asp:textbox><BR>
				<BR>
				Choose a border style:<BR>
				<asp:radiobuttonlist id="lstBorder" runat="server" Height="59px" Width="177px" Font-Size="X-Small" AutoPostBack="True" RepeatColumns="2"></asp:radiobuttonlist><BR>
				<BR>
				<asp:checkbox id="chkPicture" runat="server" Text="Add the Default Picture" AutoPostBack="True"></asp:checkbox><BR>
				<BR>
				Enter the greeting text below:<BR>
				<asp:textbox id="txtGreeting" runat="server" Height="85px" Width="240px" TextMode="MultiLine" AutoPostBack="True"></asp:textbox><BR>
				<BR>
				<asp:button id="cmdUpdate" runat="server" Height="24px" Width="71px" Text="Update"></asp:button></DIV>
			<asp:panel id="pnlCard" style="Z-INDEX: 101; LEFT: 313px; POSITION: absolute; TOP: 16px" runat="server" Height="445px" Width="339px" HorizontalAlign="Center"><BR>&nbsp; 
<asp:Label id="lblGreeting" runat="server" Width="272px" Height="150px"></asp:Label>
<asp:Image id="imgDefault" runat="server" Width="212px" Height="160px" Visible="False"></asp:Image></asp:panel></FORM>
	</BODY>
</HTML>
