
Namespace AdvancedControls


    Public Class FormattedCalendar
        Inherits Calendar

        Public Sub New()
            ' Configure the appearance of the calendar table.
            Me.CellPadding = 8
            Me.CellSpacing = 8
            Me.BackColor = Color.LightYellow
            Me.BorderStyle = BorderStyle.Groove
            Me.BorderWidth = Unit.Pixel(2)
            Me.ShowGridLines = True

            ' Configure the font.
            Me.Font.Name = "Verdana"
            Me.Font.Size = FontUnit.XXSmall

            ' Set some special calendar settings.
            Me.FirstDayOfWeek = FirstDayOfWeek.Monday
            Me.PrevMonthText = "<--"
            Me.NextMonthText = "-->"

            ' Select the current date by default.
            Me.SelectedDate = Date.Today

        End Sub

        Protected Overrides Sub OnDayRender(ByVal cell As TableCell, ByVal day As CalendarDay)
            MyBase.OnDayRender(cell, day)
            If day.IsOtherMonth Then
                day.IsSelectable = False
                cell.Text = ""
            Else
                cell.Font.Bold = True
            End If
        End Sub
    End Class

End Namespace