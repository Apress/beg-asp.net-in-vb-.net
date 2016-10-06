Imports System.Diagnostics
Public Class ErrorTestLog
    Inherits System.Web.UI.Page
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents cmdCompute As System.Web.UI.WebControls.Button
    Protected WithEvents txtB As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtA As System.Web.UI.WebControls.TextBox
    Protected WithEvents chkLog As System.Web.UI.WebControls.CheckBox
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
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

            ' Write the information to the event log.
            Dim Log As EventLog
            If chkLog.Checked = True Then
                Log = New EventLog("ProseTech")
            Else
                Log = New EventLog()
            End If
            Log.Source = "ErrorTestLog_Page"
            Log.WriteEntry(err.Message, EventLogEntryType.Error)
            lblResult.Text &= "<br><br>Exception written to event log."
        End Try

    End Sub
End Class
