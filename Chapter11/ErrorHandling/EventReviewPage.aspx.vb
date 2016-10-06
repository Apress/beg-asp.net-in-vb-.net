Imports System.Diagnostics
Public Class EventReviewPage
    Inherits System.Web.UI.Page
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label
    Protected WithEvents txtSource As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdGet As System.Web.UI.WebControls.Button
    Protected WithEvents chkAll As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtLog As System.Web.UI.WebControls.TextBox
        Protected WithEvents Label1 As System.Web.UI.WebControls.Label
        
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


    Private Sub cmdGet_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles cmdGet.Click

        lblResult.Text = ""

        ' Check if the log exists.
        If Not EventLog.Exists(txtLog.Text) Then
            lblResult.Text = "The event log " & txtLog.Text & " does not exist."
        Else
            ' For maximum performance, join all the event
            ' information into one large string using the
            ' StringBuilder.
            Dim sb As New System.Text.StringBuilder()

            Dim log As New EventLog(txtLog.Text)
            Dim entry As EventLogEntry
            For Each entry In log.Entries
                ' Write the event entries to the page.
                If chkAll.Checked = True Or entry.Source = txtSource.Text Then
                    sb.Append("<b>Entry Type:</b> " & entry.EntryType.ToString)
                    sb.Append("<br><b>Message:</b> " & entry.Message)
                    sb.Append("<br><b>Time Generated:</b> " & entry.TimeGenerated)
                    sb.Append("<br><br>")
                End If
            Next
            lblResult.Text = sb.ToString()
        End If

    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked = True Then
            txtSource.Text = ""
            txtSource.Enabled = False
        Else
            txtSource.Enabled = True
        End If
    End Sub


End Class
