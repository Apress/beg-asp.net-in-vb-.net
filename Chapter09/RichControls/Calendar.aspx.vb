Public Class Calendar
    Inherits System.Web.UI.Page
    Protected WithEvents lblDates As System.Web.UI.WebControls.Label
    Protected WithEvents MyCalendar As System.Web.UI.WebControls.Calendar

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

    Private Sub MyCalendar_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyCalendar.SelectionChanged
        lblDates.Text = "You selected these dates:<br>"

        Dim dt As DateTime
        For Each dt In MyCalendar.SelectedDates
            lblDates.Text &= dt.ToLongDateString() & "<br>"
        Next

    End Sub
End Class
