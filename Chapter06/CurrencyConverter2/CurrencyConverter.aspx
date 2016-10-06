<%@ Page Language="VB" Inherits="CurrencyConverter" Src="CurrencyConverter.vb" AutoEventWireup="False" %>

<HTML><body>
  <form method="post" runat="server">

    <DIV style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge; PADDING-LEFT: 20px; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 600px; PADDING-TOP: 20px; BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 211px; BACKGROUND-COLOR: lightyellow" >

      Convert: &nbsp;
      <input type=text id="US" runat="server">&nbsp; US dollars to &nbsp;
      <select id="Currency" style="WIDTH: 155px" runat="server"></select><br><br>
      <input type=submit value="OK" id="Convert" runat="server">
      <input type=submit value="Show Graph" id="ShowGraph" runat="server"><br><br>
      <img id="Graph" runat="server"><br><br>

      <DIV id=Result style="FONT-WEIGHT: bold" runat="server"></DIV>
    </DIV>

  </form>
</body></HTML>
