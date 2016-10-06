<script runat="server">

	Private Sub Application_OnEndRequest(sender As Object, e As EventArgs)
		Response.Write("<hr>This page was served at " & DateTime.Now.ToString())
	End Sub

</script>