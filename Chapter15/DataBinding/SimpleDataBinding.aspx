<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SimpleDataBinding.aspx.vb" Inherits="DataBinding.DataBindingPage"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Simple Data Binding</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			&nbsp;
			<asp:Label id="lblDynamic" runat="server" Font-Size="X-Large" Font-Names="Verdana">
		There were <%# TransactionCount %> transactions today. I see that you are using <%# Request.Browser.Browser %>.
			</asp:Label>
		</form>
	</body>
</HTML>
