<%@ Page Language="VB" Inherits="CurrencyConverter" Src="CurrencyConverter.vb" %>

<HTML><body>
  <form method="post" runat="server">

    <DIV style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge; PADDING-LEFT: 20px; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 499px; PADDING-TOP: 20px; BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 211px; BACKGROUND-COLOR: lightyellow" >

      <P>Convert: &nbsp;
      <input type=text id="US" runat="server">&nbsp; US dollars to Euros.</P><P>
      <input type=submit value=OK id="convert" runat="server"></P>

      <DIV id=Result style="FONT-WEIGHT: bold" runat="server"></DIV>
    </DIV>

  </form>
</body></HTML>
