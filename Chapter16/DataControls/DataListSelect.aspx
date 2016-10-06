<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataListSelect.aspx.vb" Inherits="DataControls.DataListSelect"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>DataList Selection</title>
<meta content="Microsoft Visual Studio.NET 7.0" name=GENERATOR>
<meta content="Visual Basic 7.0" name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
  </HEAD>
<body MS_POSITIONING="GridLayout">
<form id=Form1 method=post runat="server">
<asp:datalist id=listAuthor runat="server" BorderColor="#DEBA84" BorderStyle="None" CellSpacing="2" BackColor="#DEBA84" CellPadding="3" GridLines="Both" BorderWidth="1px" RepeatColumns="4" Font-Size="Smaller">
<SelectedItemStyle Font-Italic="True" BorderColor="Aqua" BackColor="#FFC0FF">
</SelectedItemStyle>

<HeaderTemplate>
       <h2>Author List</h2>
    
</HeaderTemplate>

<SelectedItemTemplate>
       <b><%# Container.DataItem("au_fname") %>
       <%# Container.DataItem("au_lname") %></b><br>
       Address: <%# Container.DataItem("address") %><br>
       City: <%# Container.DataItem("city") %><br>
    
</SelectedItemTemplate>

<AlternatingItemStyle BackColor="#FFE0C0">
</AlternatingItemStyle>

<ItemStyle Font-Names="Verdana" ForeColor="#8C4510" BackColor="#FFF7E7">
</ItemStyle>

<ItemTemplate>
       <b><%# Container.DataItem("au_fname") %>
       <%# Container.DataItem("au_lname") %></b><br>
       Address: <%# Container.DataItem("address") %><br>
       City: <%# Container.DataItem("city") %><br>
       <asp:Button CommandName="Select" Text="Select" Runat=server ID="Button1"/>
    
</ItemTemplate>

<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129">
</HeaderStyle>
</asp:datalist>

<br></form>

  </body>
</HTML>
