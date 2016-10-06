<%@ Page Language="vb" AutoEventWireup="false" Codebehind="XmlValidation.aspx.vb" Inherits="SimpleXML.XmlValidation"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>XmlValidation</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 105; LEFT: 16px; BORDER-LEFT: 2px groove; WIDTH: 576px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 16px; HEIGHT: 104px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout">
				<asp:button id="cmdValidate" style="Z-INDEX: 100; LEFT: 328px; POSITION: absolute; TOP: 56px" runat="server" Text="Validate XML" Width="208px" Height="29px" Font-Size="Smaller" Font-Names="Tahoma"></asp:button>
				<asp:RadioButton id="optValid" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server" Text="Use SuperProProductList.xml" Width="264px" Height="16px" Font-Size="X-Small" Font-Names="Verdana" Checked="True" GroupName="Valid"></asp:RadioButton>
				<asp:RadioButton id="optInvalidData" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 40px" runat="server" Text="Use InvalidData.xml" Width="264px" Height="16px" Font-Size="X-Small" Font-Names="Verdana" GroupName="Valid"></asp:RadioButton>
				<asp:RadioButton id="optInvalidTag" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 64px" runat="server" Text="Use InvalidTag.xml" Width="264px" Height="16px" Font-Size="X-Small" Font-Names="Verdana" GroupName="Valid"></asp:RadioButton></DIV>
			<asp:Label id="lblStatus" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 152px" runat="server" Width="512px" Height="32px" Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" EnableViewState="False"></asp:Label>
		</form>
	</body>
</HTML>
