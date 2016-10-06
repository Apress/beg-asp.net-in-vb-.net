Imports System.Web.Security

Public Class PasswordHasher
    Inherits System.Web.UI.Page
    Protected WithEvents cmdHash As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents optSHA1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optMD5 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents txtHash As System.Web.UI.WebControls.TextBox
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub cmdHash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHash.Click
        Dim Algorithm As String
        If optSHA1.Checked = True Then
            Algorithm = "SHA1"
        Else
            Algorithm = "MD5"
        End If
        txtHash.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, Algorithm)
    End Sub
End Class
