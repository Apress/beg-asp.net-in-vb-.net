Imports System.Web.Security
Public Class Login
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents cmdLogin As System.Web.UI.WebControls.Button

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


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If FormsAuthentication.Authenticate(txtName.Text, txtPassword.Text) Then
                FormsAuthentication.RedirectFromLoginPage(txtName.Text, False)
            Else
                lblStatus.Text = "Try again."
        End If
    End Sub

End Class
