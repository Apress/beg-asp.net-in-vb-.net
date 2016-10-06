Public Class CookieExample
    Inherits System.Web.UI.Page
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdStore As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents lblWelcome As System.Web.UI.WebControls.Label

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
        Dim Cookie As HttpCookie = Request.Cookies("Preferences")
        If Cookie Is Nothing Then
            lblWelcome.Text = "&nbsp;<b>Unknown Customer</b>"
        Else
            lblWelcome.Text = "&nbsp;<b>Cookie Found.</b><br><br>"
            lblWelcome.Text &= "&nbsp;Welcome, " & Cookie("Name")
        End If
    End Sub

    Private Sub cmdStore_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdStore.Click
        Dim Cookie As HttpCookie = Request.Cookies("Preferences")
        If Cookie Is Nothing Then
            Cookie = New HttpCookie("Preferences")
        End If

        Cookie("Name") = txtName.Text
        Cookie.Expires = DateTime.Now.AddYears(1)
        Response.Cookies.Add(Cookie)

        lblWelcome.Text = "&nbsp;<b>Cookie Created.</b><br><br>"
        lblWelcome.Text &= "&nbsp;New Customer: " & Cookie("Name")
    End Sub


End Class
