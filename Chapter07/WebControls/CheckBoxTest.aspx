<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CheckBoxTest.aspx.vb" Inherits="WebControls.CheckBoxTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>CheckBoxTest</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">

  Choose your favourite programming languages:<br><br>
  <asp:CheckBoxList id="chklst" runat="server" /><br><br>
  <asp:Button id="cmdOK" Text="OK" runat="server" /><br><br>
  <asp:Label id="lblResult" runat="server" />

    </form>

  </body>
</HTML>
