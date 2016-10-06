Public Class ProtectedPage
    Inherits System.Web.UI.Page
    Protected WithEvents lblSecretMessage As System.Web.UI.WebControls.Label
    Protected WithEvents pnlControls As System.Web.UI.WebControls.Panel

    Protected WithEvents Login As UserControls.LoginBox

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

    Private Sub Failed(ByVal sender As Object, ByVal e As EventArgs) Handles Login.LoginFailed
        ' Retrieve the number of failed attempts from viewstate.
        Dim Attempts As Integer
        Attempts = CType(Viewstate("Attempts"), Integer)

        Attempts += 1
        If Attempts = 3 Then
            pnlControls.Visible = False
            lblSecretMessage.Text = "You have reached the maximum 3 tries. Next time use the 'opensesame' password."
        End If

        ' Store the new number of failed attempts in viewstate.
        ' Of course, the user can always re-request the page to get
        ' around this simple limitation.
        Viewstate("Attempts") = Attempts
    End Sub

    Private Sub Succeeded(ByVal sender As Object, ByVal e As LoginAuthenticatedEventArgs) Handles Login.LoginAuthenticated

        pnlControls.Visible = False
        lblSecretMessage.Text = "You are now authenticated to see this page, "
        lblSecretMessage.Text &= e.UserName

    End Sub

End Class
