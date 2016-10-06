<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TemplateDataGrid.aspx.vb" Inherits="DataControls.TemplateDataGrid"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>Template Data Grid</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">
<asp:DataGrid id=gridAuthor runat="server" AutoGenerateColumns="False">
  <Columns>
     <asp:TemplateColumn HeaderText="Author Name">
        <ItemTemplate><%# Container.DataItem("au_fname") %>
        <%# Container.DataItem("au_lname") %></ItemTemplate>
     </asp:TemplateColumn>

     <asp:BoundColumn DataField="city" HeaderText="City"></asp:BoundColumn>
     <asp:BoundColumn DataField="address" HeaderText="Address"></asp:BoundColumn>
  </Columns>
</asp:DataGrid>&nbsp;

    </form>

  </body>
</HTML>
