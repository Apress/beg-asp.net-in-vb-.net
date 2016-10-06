
Public Class ProcessModelReport
    Inherits System.Web.UI.Page
    Protected WithEvents cmdCurrent As System.Web.UI.WebControls.Button
    Protected WithEvents cmdHistory As System.Web.UI.WebControls.Button
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents dgProcess As System.Web.UI.WebControls.DataGrid

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

    End Sub

    Private Sub cmdCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCurrent.Click
        Dim Current As ProcessInfo = ProcessModelInfo.GetCurrentProcessInfo
        lblInfo.Text = "<b>Process: </b>" & Current.ProcessID.ToString()
        lblInfo.Text &= "<br><b>Start: </b>" & Current.StartTime.ToString()
        lblInfo.Text &= "<br><b>Age: </b>" & Current.Age.ToString()
        lblInfo.Text &= "<br><b>Peak Memory: </b>" & Current.PeakMemoryUsed.ToString()
        lblInfo.Text &= "<br><b>Status: </b>" & Current.Status.ToString()
    End Sub

    Private Sub cmdHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHistory.Click
        dgProcess.DataSource = ProcessModelInfo.GetHistory(100)
        dgProcess.DataBind()
    End Sub
End Class
