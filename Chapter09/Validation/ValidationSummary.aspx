<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ValidationSummary.aspx.vb" Inherits="Validation.ValidationTest2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Validation Summary</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>A number (1 to 10):
				<asp:textbox id="txtValidated" runat="server"></asp:textbox>&nbsp;
				<asp:rangevalidator id="RangeValidator" runat="server" Display="None" Type="Integer" MinimumValue="1" MaximumValue="10" ControlToValidate="txtValidated" ErrorMessage="The First Number Is Not In The Range"></asp:rangevalidator><BR>
				<BR>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
				<asp:textbox id="txtNotValidated" runat="server"></asp:textbox><BR>
			</P>
			<P><BR>
				<asp:button id="cmdOK" runat="server" Text="OK"></asp:button><BR>
				<BR>
				<asp:label id="lblMessage" runat="server" EnableViewState="False"></asp:label><BR>
				<BR>
				<asp:ValidationSummary id="ValidationSummary1" runat="server" ShowMessageBox="True"></asp:ValidationSummary></P>
		</form>
	</body>
</HTML>
