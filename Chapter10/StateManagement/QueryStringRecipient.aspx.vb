Public Class QueryStringRecipient
    Inherits System.Web.UI.Page
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblInfo.Text = "Item: " & Request.QueryString("Item") & "<br>"
        lblInfo.Text &= "Show Full Record: " & Request.QueryString("Mode")
    End Sub


End Class
