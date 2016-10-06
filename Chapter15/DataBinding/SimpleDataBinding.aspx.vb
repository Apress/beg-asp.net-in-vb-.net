Public Class DataBindingPage
    Inherits System.Web.UI.Page
    Protected WithEvents lblDynamic As System.Web.UI.WebControls.Label
        
    Public TransactionCount As Integer

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

        ' You could use database code here to look up a value for
        ' intTransactionsToday.
        TransactionCount = 10
        ' Now convert all the data binding expressions on the page.
        Me.DataBind()

    End Sub

End Class
