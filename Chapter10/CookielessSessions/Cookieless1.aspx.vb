Public Class Cookieless1
    Inherits System.Web.UI.Page
    Protected WithEvents cmdLink As System.Web.UI.WebControls.Button
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents cmdLinkAbsolute As System.Web.UI.WebControls.Button
    Protected WithEvents lnkRedirect As System.Web.UI.WebControls.HyperLink

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


    Private Sub cmdLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLink.Click
        Response.Redirect("Cookieless2.aspx")
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Session("test") = "Test String"
    End Sub


    Private Sub cmdLinkAbsolute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLinkAbsolute.Click
        Response.Redirect("http://localhost/ASP.NET/Chapter10/CookielessSessions/Cookieless2.aspx")
    End Sub
End Class
