<%@ Page Language="VB" Inherits="ImageTest" Src="ImageTest.vb" AutoEventWireup="False" %>

<HTML><body>
  <form method="post" runat="server">

      <h3>Click on the Image </h3>

      <input type="image"
             src="button.png" 
             id="ImgButton"
             runat="server"/>

      <br>

      <div id="Result" 
            runat="server"/>


  </form>
</body></HTML>
