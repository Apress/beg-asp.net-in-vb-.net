<%@ Page Language="vb" AutoEventWireup="false" Codebehind="XMLTest.aspx.vb" Inherits="ADO.NET_XML.XMLTest"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>ADO.NET XML</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">
<asp:Button id=cmdShowXML style="Z-INDEX: 101; LEFT: 200px; POSITION: absolute; TOP: 88px" runat="server" Text="Show XML" Width="112px" Height="32px" Font-Names="Verdana"></asp:Button>
<asp:TextBox id=txtTable style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 56px" runat="server" Width="192px" Font-Names="Verdana">Customers</asp:TextBox>
<xmp id=Results 
style="DISPLAY: inline; FONT-SIZE: x-small; Z-INDEX: 102; LEFT: 16px; WIDTH: 504px; FONT-FAMILY: Verdana; POSITION: absolute; TOP: 152px; HEIGHT: 112px" 
runat="server" ms_positioning="FlowLayout"></xmp>
<asp:Label id=Label1 style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 24px" runat="server" Width="80px" Height="24px" Font-Names="Verdana" Font-Size="Smaller">Database:</asp:Label>
<asp:Label id=Label2 style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 64px" runat="server" Width="56px" Height="24px" Font-Names="Verdana" Font-Size="Smaller">Table:</asp:Label>
<asp:TextBox id=txtDatabase style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 24px" runat="server" Width="192px" Font-Names="Verdana">Northwind</asp:TextBox>
<asp:Panel id=Panel1 style="Z-INDEX: 107; LEFT: 360px; POSITION: absolute; TOP: 24px" runat="server" Width="320px" Height="64px" BorderWidth="0px">
<asp:RadioButton id=optSQL runat="server" Font-Names="Verdana" Text="Use SQL Authentication (with sa account)" Font-Size="Smaller" GroupName="Authentication"></asp:RadioButton><BR>
<asp:RadioButton id=optWindows runat="server" Font-Names="Verdana" Text="Use Windows Integrated Authentication" Font-Size="Smaller" GroupName="Authentication" Checked="True"></asp:RadioButton></asp:Panel>

    </form>

  </body>
</HTML>
