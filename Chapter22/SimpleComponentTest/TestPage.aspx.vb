Public Class TestPage
    Inherits System.Web.UI.Page
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label

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
        Dim TestComponent As New SimpleComponent.SimpleTest()
        Dim TestComponent2 As New SimpleComponent.SimpleTest2()
        lblResult.Text = TestComponent.GetInfo("Hello") & "<br><br>"
        lblResult.Text &= TestComponent2.GetInfo("Bye")
    End Sub

End Class
