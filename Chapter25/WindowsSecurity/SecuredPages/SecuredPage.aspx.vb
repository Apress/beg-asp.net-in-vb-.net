Imports System.Security.Principal
Imports System.Web.Security
Imports System.Security
Public Class SecuredPage
    Inherits System.Web.UI.Page
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

        Dim WinIdentity As WindowsIdentity
        WinIdentity = CType(User.Identity, WindowsIdentity)
        lblMessage.Text &= "<br><br>Authentication Type: " & WinIdentity.AuthenticationType
        lblMessage.Text &= "<br>Anonymous: " & WinIdentity.IsAnonymous
        lblMessage.Text &= "<br>Authenticated: " & WinIdentity.IsAuthenticated
        lblMessage.Text &= "<br>Guest: " & WinIdentity.IsGuest
        lblMessage.Text &= "<br>System: " & WinIdentity.IsSystem
        lblMessage.Text &= "<br>Administrator: " & User.IsInRole("BUILTIN\Administrators")
    End Sub


End Class
