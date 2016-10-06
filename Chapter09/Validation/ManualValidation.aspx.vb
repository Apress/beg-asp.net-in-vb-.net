Public Class ValidationTest3
    Inherits System.Web.UI.Page
    Protected WithEvents txtValidated As System.Web.UI.WebControls.TextBox
    Protected WithEvents RangeValidator As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents txtNotValidated As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdOK As System.Web.UI.WebControls.Button
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
        Dim ErrorMessage As String = "<b>Mistakes found:</b><br>"

        ' Create a variable to represent the input control.
        Dim ctrlInput As TextBox

        ' Search through the validation controls.
        Dim ctrl As BaseValidator

        For Each ctrl In Me.Validators
            If ctrl.IsValid = False Then
                ErrorMessage &= ctrl.ErrorMessage & "<br>"

                ' Find the corresponding input control, and change the
                ' generic Control object variable into a TextBox variable.
                ' This allows access to the Text property.
                ctrlInput = CType(Me.FindControl(ctrl.ControlToValidate), TextBox)
                ErrorMessage &= " * Problem is with this input: " & ctrlInput.Text & "<br>"
            End If
        Next

        lblMessage.Text = ErrorMessage
    End Sub
End Class
