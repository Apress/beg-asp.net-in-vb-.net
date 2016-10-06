<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ManualValidation.aspx.vb" Inherits="Validation.ValidationTest3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			A number (1 to 10):
			<asp:TextBox id="txtValidated" runat="server"></asp:TextBox>&nbsp;
			<asp:RangeValidator id="RangeValidator" runat="server" ErrorMessage="This Number Is Not In The Range" ControlToValidate="txtValidated" MaximumValue="10" MinimumValue="1" Type="Integer" EnableClientScript="False"></asp:RangeValidator><BR>
			<BR>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
			<asp:TextBox id="txtNotValidated" runat="server"></asp:TextBox><BR>
			<BR>
			<asp:Button id="cmdOK" runat="server" Text="OK"></asp:Button><BR>
			<BR>
			<asp:Label id="lblMessage" runat="server" EnableViewState="False"></asp:Label>
		</form>
	</body>
</HTML>
