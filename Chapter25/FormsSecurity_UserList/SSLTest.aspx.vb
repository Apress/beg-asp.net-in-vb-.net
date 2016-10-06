Public Class SSLTest
    Inherits System.Web.UI.Page
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Request.IsSecureConnection = True Then
            lblStatus.Text = "This page is running under SSL."
        Else
            lblStatus.Text = "This page is not secure. <br>Please request it with the prefix https:// instead of http://"
        End If
    End Sub

End Class
