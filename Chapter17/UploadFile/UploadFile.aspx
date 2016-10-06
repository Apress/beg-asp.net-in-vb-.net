<%@ Page Language="vb" AutoEventWireup="false" Codebehind="UploadFile.aspx.vb" Inherits="UploadFile.UploadFile" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" enctype="multipart/form-data" method="post" runat="server">
			<INPUT id="FileInput" style="Z-INDEX: 101; LEFT: 32px; WIDTH: 552px; POSITION: absolute; TOP: 24px; HEIGHT: 24px" type="file" size="72" name="File1" runat="server">
			<asp:button id="cmdUpload" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 72px" runat="server" Text="Upload"></asp:button>
			<asp:Label id="lblInfo" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 128px" runat="server" Width="608px" Height="72px" Font-Names="Verdana" Font-Size="Medium" Font-Bold="True"></asp:Label></form>
	</body>
</HTML>
