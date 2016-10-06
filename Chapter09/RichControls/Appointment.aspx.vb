Public Class Appointment
    Inherits System.Web.UI.Page
    Protected WithEvents lstTimes As System.Web.UI.WebControls.ListBox
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar

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

  
    Private Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        lstTimes.Items.Clear()
        Select Case Calendar1.SelectedDate.DayOfWeek
            Case DayOfWeek.Monday
                ' Apply special Monday schedule.
                lstTimes.Items.Add("10:00")
                lstTimes.Items.Add("10:30")
                lstTimes.Items.Add("11:00")
            Case DayOfWeek.Tuesday
                lstTimes.Items.Add("10:00")
                lstTimes.Items.Add("10:30")
            Case Else
                lstTimes.Items.Add("10:00")
                lstTimes.Items.Add("10:30")
                lstTimes.Items.Add("11:00")
                lstTimes.Items.Add("11:30")
                lstTimes.Items.Add("12:00")
                lstTimes.Items.Add("12:30")
        End Select
    End Sub

    Private Sub DayRender(ByVal source As Object, ByVal e As DayRenderEventArgs) _
      Handles Calendar1.DayRender
        ' Check for May 5 in any year, and format it.
        If e.Day.Date.Day = 5 And e.Day.Date.Month = 5 Then
            e.Cell.BackColor = System.Drawing.Color.Yellow
            ' Add some static text to the cell.
            Dim lbl As New Label()
            lbl.Text = "<br>My Birthday!"
            e.Cell.Controls.Add(lbl)
        End If

        If e.Day.IsWeekend Then
            e.Day.IsSelectable = False
        End If
    End Sub
End Class
