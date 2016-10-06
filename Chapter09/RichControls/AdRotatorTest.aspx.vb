Public Class AdRotatorTest
    Inherits System.Web.UI.Page
    Protected WithEvents Ads As System.Web.UI.WebControls.AdRotator
    Protected WithEvents lnkBanner As System.Web.UI.WebControls.HyperLink

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

    Private Sub AdRotator1_AdCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.AdCreatedEventArgs) Handles Ads.AdCreated
        ' Synchronize the Hyperlink control.
        lnkBanner.NavigateUrl = e.NavigateUrl

        ' Syncrhonize the text of the link.
        lnkBanner.Text = "Click here for information about our sponsor: "
        lnkBanner.Text &= e.AlternateText()
    End Sub
End Class
