<%@ Page Language="VB" %>
<script runat="server">

    Sub Page_Load(sender As Object, e As EventArgs)
        Dim SaleProduct As New Product("Kitchen Garbage", 49.99)
        SaleProduct.ImageUrl = "Garbage.jpg"
        Response.Write(SaleProduct.GetHtml())
    End Sub

</script>
<html>
<head>
</head>
<body>
    <form runat="server">
        <!-- Insert content here -->
    </form>
</body>
</html>