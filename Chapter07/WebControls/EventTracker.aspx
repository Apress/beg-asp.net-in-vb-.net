<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EventTracker.aspx.vb" Inherits="WebControls.EventTracker" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title></title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body >

    <form id="Form1" method="post" runat="server">
<P><h3>Controls being monitored for change events:</h3>
<asp:TextBox id=txt runat="server" AutoPostBack="True"></asp:TextBox><BR><BR>
<asp:CheckBox id=chk runat="server" AutoPostBack="True"></asp:CheckBox><BR><BR>
<asp:RadioButton id=opt1 runat="server" GroupName="Sample" AutoPostBack="True"></asp:RadioButton>
<asp:RadioButton id=opt2 runat="server" GroupName="Sample" AutoPostBack="True"></asp:RadioButton><BR><BR><BR><h3>List 
of events:</h3>
<P></P>
<P>
<asp:ListBox id=lstEvents runat="server" Width="355px" Height="256px"></asp:ListBox><BR></P>

    </form>

  </body>
</HTML>
