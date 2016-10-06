Public Class FailedSessionServiceTest
    Inherits System.Web.UI.Page
    Protected WithEvents cmdCallService As System.Web.UI.WebControls.Button
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label
    Protected WithEvents cmdGetCounter As System.Web.UI.WebControls.Button

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

    Private WS As New localhost3.StockQuote_SessionState()

    Private Sub cmdGetCounter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCounter.Click

        Dim WSInfo As New localhost3.CounterInfo()
        WSInfo = WS.GetStockUsage("MSFT")

        ' Add usage information to the label.
        lblResult.Text &= "<b>Global: " & WSInfo.GlobalRequests & "<br>"
        lblResult.Text &= "Session: " & WSInfo.SessionRequests & "<br></b>"
    End Sub

    Private Sub cmdCallService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCallService.Click

        Dim Result As Decimal = WS.GetStockQuote("MSFT")

        ' Add confirmation message to the label.
        lblResult.Text &= "GetStockQuote With MSFT Returned " & Result & "<br>"
    End Sub
End Class
