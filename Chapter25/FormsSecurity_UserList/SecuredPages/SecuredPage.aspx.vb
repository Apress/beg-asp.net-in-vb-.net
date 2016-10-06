Imports System.Web.Security

Public Class SecuredPage
    Inherits System.Web.UI.Page
    Protected WithEvents cmdSignOut As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label

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
        lblMessage.Text = "You have reached the secured page, "
        lblMessage.Text &= User.Identity.Name & "."
        If User.IsInRole("Administrator") Then
            lblMessage.Text &= "<br><br>Congratulations: you are an administrator."
        End If
    End Sub

    Private Sub cmdSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSignOut.Click
        FormsAuthentication.SignOut()
        Response.Redirect(Request.Url.ToString())

    End Sub
End Class
