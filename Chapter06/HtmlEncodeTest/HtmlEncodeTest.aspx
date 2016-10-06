<%@ Page Language="VB" Inherits="HtmlEncodeTest" Src="HtmlEncodeTest.vb" AutoEventWireup="False" %>

<HTML><body>
  <form method="post" runat="server">


<h2>Properly encoded:</h2> 
      <div id="ctrl2" 
            runat="server"/>

<br><hr><br>
<h2>Incorrectly encoded:</h2> 
      <div id="ctrl1" 
            runat="server"/>


  </form>
</body></HTML>
