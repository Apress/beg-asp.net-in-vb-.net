Public Class RegularExpressionTest
    Inherits System.Web.UI.Page
    Protected WithEvents txtExpression As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtValidate As System.Web.UI.WebControls.TextBox
    Protected WithEvents TestValidator As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents cmdSetExpression As System.Web.UI.WebControls.Button
    Protected WithEvents lblExpression As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents cmdValidate As System.Web.UI.WebControls.Button
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
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


    Private Sub cmdSetExpression_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetExpression.Click
        TestValidator.ValidationExpression = txtExpression.Text
        lblExpression.Text = "Current Expression: " & txtExpression.Text
    End Sub

End Class
