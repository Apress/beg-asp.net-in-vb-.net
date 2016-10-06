<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ValidationTest.aspx.vb" Inherits="Validation.ValidationTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Simple Validation Test</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				A number (1 to 10):
				<asp:TextBox id="txtValidated" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:RangeValidator id="RangeValidator" runat="server" ErrorMessage="This Number Is Not In The Range" ControlToValidate="txtValidated" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator><BR>
				<BR>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
				<asp:TextBox id="txtNotValidated" runat="server"></asp:TextBox><BR>
			</P>
			<P><BR>
				<asp:Button id="cmdOK" runat="server" Text="OK"></asp:Button><BR>
				<BR>
				<asp:Label id="lblMessage" runat="server" EnableViewState="False"></asp:Label></P>
		</form>
	</body>
</HTML>
