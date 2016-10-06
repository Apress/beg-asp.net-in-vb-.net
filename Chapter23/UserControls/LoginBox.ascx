<%@ Control Language="vb" AutoEventWireup="false" Codebehind="LoginBox.ascx.vb" Inherits="UserControls.LoginBox" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<DIV style="BORDER-RIGHT: 2px groove; PADDING-RIGHT: 5px; BORDER-TOP: 2px groove; PADDING-LEFT: 5px; FONT-WEIGHT: bold; FONT-SIZE: x-small; PADDING-BOTTOM: 5px; BORDER-LEFT: 2px groove; WIDTH: 376px; PADDING-TOP: 5px; BORDER-BOTTOM: 2px groove; FONT-FAMILY: Verdana; POSITION: relative; HEIGHT: 192px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout">
	<asp:TextBox id="txtUser" style="Z-INDEX: 100; LEFT: 144px; POSITION: absolute; TOP: 40px" runat="server" Width="160px"></asp:TextBox>
	<asp:TextBox id="txtPassword" style="Z-INDEX: 101; LEFT: 144px; POSITION: absolute; TOP: 72px" runat="server" Width="160px" TextMode="Password"></asp:TextBox>
	<asp:Button id="cmdLogin" style="Z-INDEX: 102; LEFT: 264px; POSITION: absolute; TOP: 144px" runat="server" Text="Login" Width="72px"></asp:Button>
	<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 34px; POSITION: absolute; TOP: 44px" runat="server">User Name:</asp:Label>
	<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 36px; POSITION: absolute; TOP: 77px" runat="server">Password:</asp:Label></DIV>
