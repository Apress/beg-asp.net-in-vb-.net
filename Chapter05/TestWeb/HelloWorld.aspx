<html>

<script language="VB" runat="server">

	Private Sub Page_Load()
		lblTest.Text = "Hello, the Page_Load event occurred.<br>"
	End Sub

</script>

<body>

<form id="Form" runat="server">
	<asp:Label id="lblTest" runat="server" />
</form>

</body>
</html>
