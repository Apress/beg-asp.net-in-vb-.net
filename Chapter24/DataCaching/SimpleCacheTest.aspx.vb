Public Class SimpleCacheTest
    Inherits System.Web.UI.Page
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.IsPostBack = True Then
            lblInfo.Text &= "Page posted back.<br>"
        Else
            lblInfo.Text &= "Page created.<br>"
        End If


        If Cache("TestItem") Is Nothing Then
            lblInfo.Text &= "Creating TestItem...<br>"
            Dim TestItem As Date = DateTime.Now()

            lblInfo.Text &= "StoringTestItem in cache for 30 seconds.<br>"
            Cache.Insert("TestItem", TestItem, Nothing, DateTime.Now.AddSeconds(30), TimeSpan.Zero)
        Else
            lblInfo.Text &= "Retrieving TestItem...<br>"
            Dim testitem As Date = CType(Cache("TestItem"), Date)
            lblInfo.Text &= "TestItem is '" & TestItem.ToString & "'<br>"
        End If

        lblInfo.Text &= "<br>"
    End Sub

End Class
