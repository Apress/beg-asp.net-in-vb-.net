Imports System.Net

Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents cmdUnauthenticated As System.Web.UI.WebControls.Button
    Protected WithEvents cmdAuthenticated As System.Web.UI.WebControls.Button
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


    Private Sub cmdUnauthenticated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnauthenticated.Click
        Dim SecuredService As New localhost.SecuredService()
        Try
            lblInfo.Text = SecuredService.TestAuthenticated()
        Catch Err As Exception
            lblInfo.Text = Err.ToString()
        End Try
    End Sub

    Private Sub cmdAuthenticated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAuthenticated.Click
        Dim SecuredService As New localhost.SecuredService()

        ' Specity some user credentials for the web service.
        ' This example uses the user account "GuestAccount" with the password
        ' "Guest".
        Dim Credentials As New NetworkCredential("GuestAccount", "Guest")
        SecuredService.Credentials = Credentials

        ' Uncomment this code to submit user credentials for the current user
        ' (which will be the account under which the ASP.NET service is running).
        'SecuredService.Credentials = CredentialCache.DefaultCredentials

        lblInfo.Text = SecuredService.TestAuthenticated()
    End Sub
End Class
