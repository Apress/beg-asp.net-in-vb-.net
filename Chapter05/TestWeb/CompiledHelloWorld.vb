Public Class HelloWorldClass
  Inherits System.Web.UI.Page
    Protected lblTest As System.Web.UI.WebControls.Label

    Private Sub Page_Load()
        lblTest.Text = "Hello, the Page_Load event occurred."
    End Sub

End Class
