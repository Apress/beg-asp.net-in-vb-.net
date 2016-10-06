Public Class CalendarTest
    Inherits System.Web.UI.Page
    Protected WithEvents lbl As System.Web.UI.WebControls.Label
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



    Private Sub Calendar1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles Calendar1.DayRender

        ' Check for May 5 in any year, and format it.
        If e.Day.Date.Day = 5 And e.Day.Date.Month = 5 Then

            e.Cell.BackColor = System.Drawing.Color.Yellow

            ' Add some static text to the cell.
            Dim lbl As New Label()
            lbl.Text = "<br>My Birthday!"
            e.Cell.Controls.Add(lbl)
        End If

    End Sub
End Class
