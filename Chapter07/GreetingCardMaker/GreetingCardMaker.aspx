<%@ Page Language="vb" AutoEventWireup="false" Codebehind="GreetingCardMaker.aspx.vb" Inherits="GreetingCardMaker.GreetingCardMaker" %>
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
			<DIV style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge; PADDING-LEFT: 20px; FONT-SIZE: x-small; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 293px; PADDING-TOP: 20px; BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 486px; BACKGROUND-COLOR: lightyellow" ms_positioning="FlowLayout">Choose 
				a background color:<BR>
				<asp:DropDownList id="lstBackColor" runat="server" Width="194px" Height="22px"></asp:DropDownList><BR>
				<BR>
				Choose a font:<BR>
				<asp:DropDownList id="lstFontName" runat="server" Width="194px" Height="22px"></asp:DropDownList><BR>
				<BR>
				Specify&nbsp;a numeric font size:<BR>
				<asp:TextBox id="txtFontSize" runat="server"></asp:TextBox><BR>
				<BR>
				Choose a border style:<BR>
				<asp:RadioButtonList id="lstBorder" runat="server" Width="177px" Height="59px" Font-Size="X-Small"></asp:RadioButtonList><BR>
				<BR>
				<asp:CheckBox id="chkPicture" runat="server" Text="Add the Default Picture"></asp:CheckBox><BR>
				<BR>
				Enter the greeting text below:<BR>
				<asp:TextBox id="txtGreeting" runat="server" Width="240px" Height="85px" TextMode="MultiLine"></asp:TextBox><BR>
				<BR>
				<asp:Button id="cmdUpdate" runat="server" Width="71px" Height="24px" Text="Update"></asp:Button></DIV>
			<asp:Panel id="pnlCard" style="Z-INDEX: 101; LEFT: 313px; POSITION: absolute; TOP: 16px" runat="server" Width="339px" Height="507px" HorizontalAlign="Center"><BR>&nbsp; 
<asp:Label id="lblGreeting" runat="server" Height="150px" Width="256px"></asp:Label><BR><BR><BR>
<asp:Image id="imgDefault" runat="server" Height="160px" Width="212px" Visible="False"></asp:Image></asp:Panel></FORM>
	</BODY>
</HTML>
