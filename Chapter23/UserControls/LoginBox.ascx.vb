Public MustInherit Class LoginBox
    Inherits System.Web.UI.UserControl
    Protected WithEvents txtUser As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdLogin As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

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

    Event LoginFailed(ByVal sender As Object, ByVal e As EventArgs)
    Event LoginAuthenticated(ByVal sender As Object, ByVal e As LoginAuthenticatedEventArgs)


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        ' Typically, this code would use the FormsAuthentication class
        ' described in Chapter 24, or some custom database-lookup code
        ' to authenticate the user.
        ' Our example simply checks for a "secret" code.
        If txtPassword.Text = "opensesame" Then
            Dim EventInfo As New LoginAuthenticatedEventArgs()
            EventInfo.UserName = txtUser.Text
            RaiseEvent LoginAuthenticated(Me, EventInfo)
        Else
            RaiseEvent LoginFailed(Me, New EventArgs())
        End If

    End Sub

End Class

Public Class LoginAuthenticatedEventArgs
    Inherits EventArgs

    Public UserName As String
End Class