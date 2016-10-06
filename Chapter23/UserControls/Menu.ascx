<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Menu.ascx.vb" Inherits="UserControls.Menu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<DIV style="BORDER-RIGHT: 2px groove; PADDING-RIGHT: 5px; BORDER-TOP: 2px groove; PADDING-LEFT: 5px; FONT-WEIGHT: bold; FONT-SIZE: x-small; PADDING-BOTTOM: 5px; BORDER-LEFT: 2px groove; WIDTH: 100px; PADDING-TOP: 5px; BORDER-BOTTOM: 2px groove; FONT-FAMILY: Verdana; HEIGHT: 120px; BACKGROUND-COLOR: lightyellow" ms_positioning="FlowLayout">
	Products:
	<asp:HyperLink id="lnkBooks" runat="server" NavigateUrl="MenuHost.aspx?product=Books">Books</asp:HyperLink><br>
	<asp:HyperLink id="lnkToys" runat="server" NavigateUrl="MenuHost.aspx?product=Toys">Toys</asp:HyperLink><br>
	<asp:HyperLink id="lnkSports" runat="server" NavigateUrl="MenuHost.aspx?product=Sports">Sports</asp:HyperLink><br>
	<asp:HyperLink id="lnkFurniture" runat="server" NavigateUrl="MenuHost.aspx?product=Furniture">Furniture</asp:HyperLink></DIV>
