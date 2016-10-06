Imports System.Data.OleDb

Public Class ErrorTest
    Inherits System.Web.UI.Page
    Protected WithEvents txtA As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtB As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdCompute As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label
    Protected WithEvents cmdCustom As System.Web.UI.WebControls.Button
        Protected WithEvents cmdError As System.Web.UI.WebControls.Button

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

    Private Sub cmdError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdError.Click

        Dim strConnection As String
        Dim conOne As OleDbConnection
        ' The next line will fail and generate a null reference exception.
        ' You cannot modify a property (or use a method) of an object that doesn't exist!
        conOne.ConnectionString = strConnection

    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        Try
            Dim A, B, Result As Decimal
            A = Val(txtA.Text)
            B = Val(txtB.Text)
            Result = A / B
            lblResult.Text = Result.ToString
            lblResult.ForeColor = Color.Black
        Catch err As Exception
            lblResult.Text = "<b>Message:</b> " & err.Message & "<br><br>"
            lblResult.Text &= "<b>Source:</b> " & err.Source & "<br><br>"
            lblResult.Text &= "<b>Stack Trace:</b> " & err.StackTrace
            lblResult.ForeColor = Color.Red
        End Try

    End Sub

    Private Sub cmdCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustom.Click
        DivideNumbers(5, 0)
    End Sub

    Private Function DivideNumbers(ByVal number As Decimal, ByVal divisor As Decimal) As Decimal
        If divisor = 0 Then
            Dim err As New DivideByZeroException( _
           "You supplied 0 for the divisor parameter. You must be stopped.")
            Throw err
        Else
            Return (number / divisor)
        End If
    End Function
End Class
