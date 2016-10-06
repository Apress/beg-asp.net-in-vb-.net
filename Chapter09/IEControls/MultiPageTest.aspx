<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MultiPageTest.aspx.vb" Inherits="IEControls.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body ms_positioning="GridLayout">
		<form id="Form1" method="post" runat="server">
			<P>
				<iewc:MultiPage id="MultiPage1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 36px" runat="server" Width="301px" Height="272px" BorderStyle="Outset" BorderWidth="1px">
					<iewc:PageView id="page1">
						<br>
						<h3>&nbsp;This is Page 1</h3>
					</iewc:PageView>
					<iewc:PageView id="page2">
						<br>
						<h3>&nbsp;This is Page 2</h3>
					</iewc:PageView>
					<iewc:PageView id="page3">
						<br>
						<h3>&nbsp;This is Page 3</h3>
					</iewc:PageView>
				</iewc:MultiPage></P>
			<P>
				<iewc:TabStrip id="TabStrip1" runat="server" TabSelectedStyle="background-color:#ffffff;color:#000000" TabHoverStyle="background-color:#777777" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center" TargetID="MultiPage1" Width="300px">
					<iewc:Tab Text="Tab 1"></iewc:Tab>
					<iewc:Tab Text="Tab 2"></iewc:Tab>
					<iewc:Tab Text="Tab 3"></iewc:Tab>
				</iewc:TabStrip></P>
			<P>
			</P>
		</form>
	</body>
</HTML>
