<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MultiBind.aspx.vb" Inherits="DataBinding.MultiBind"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblDynamic" runat="server">
				<%# URL %>
			</asp:Label>
			<br>
			<br>
			<asp:CheckBox id="chkDynamic" Text="<%# URL %>" runat="server" />
			<br>
			<br>
			<asp:Hyperlink id="lnkDynamic" Text="Click here!" NavigateUrl="<%# URL %>" runat="server" />
			<br>
			<br>
			<asp:Image id="imgDynamic" Src="<%# URL %>" runat="server" />
		</form>
	</body>
</HTML>
