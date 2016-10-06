Public Class ValidationTest2
    Inherits System.Web.UI.Page
    Protected WithEvents txtValidated As System.Web.UI.WebControls.TextBox
    Protected WithEvents RangeValidator As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents txtNotValidated As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdOK As System.Web.UI.WebControls.Button
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
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
        'Put user code to initialize the page here
    End Sub


    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Me.IsValid = False Then Exit Sub
        lblMessage.Text = "Page Validated and cmdOK_Click event handler executed."
    End Sub

End Class
