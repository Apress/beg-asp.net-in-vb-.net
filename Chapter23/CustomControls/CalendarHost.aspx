<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CalendarHost.aspx.vb" Inherits="CustomControls.CalendarHost"%>
<%@ Register TagPrefix="cc1" Namespace="CustomControls.AdvancedControls" Assembly="CustomControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>CalendarHost</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">
<asp:Calendar id=Calendar1 style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 56px" runat="server" BorderStyle="Groove"></asp:Calendar>
<asp:Label id=Label2 style="Z-INDEX: 104; LEFT: 296px; POSITION: absolute; TOP: 16px" runat="server" EnableViewState="False" Font-Size="Larger" Font-Names="Verdana" Font-Bold="True">FormattedCalendar:</asp:Label>
<asp:Label id=Label1 style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server" EnableViewState="False" Font-Size="Larger" Font-Names="Verdana" Font-Bold="True">Normal Calendar:</asp:Label>
<cc1:FormattedCalendar id=FormattedCalendar1 style="Z-INDEX: 102; LEFT: 296px; POSITION: absolute; TOP: 56px" runat="server" Width="120px" Height="120px"></cc1:FormattedCalendar>

    </form>

  </body>
</HTML>
