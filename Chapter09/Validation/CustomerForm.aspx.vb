Public Class CustomerForm
    Inherits System.Web.UI.Page
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtRetype As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAge As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents vldUserName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents vldRetype As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents vldPassword As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents vldAge As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents vldEmail As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents vldCode As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents cmdSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents cmdCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents txtCode As System.Web.UI.WebControls.TextBox

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

    Private Sub page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub


    Private Sub vldCode_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles vldCode.ServerValidate
        ' Check if the first three digits are divisible by seven.
        If Val(Left(args.Value, 3)) Mod 7 = 0 Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If Page.IsValid = False Then Exit Sub
        lblMessage.Text = "This is a valid form."
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        lblMessage.Text = "No attempt was made to validate this form."
    End Sub
End Class
