Public Class SimpleTest1
    Inherits System.Web.UI.Page
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label

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
        ' Create a StockInfo object for our results.
        Dim Result As Decimal

        ' Create the actual Web Service proxy class.
        Dim WS As New localhost1.StockQuote()

        ' Call the Web Service method.
        Result = WS.GetStockQuote("MSFT")

        lblResult.Text = "MSFT returned " & Result.ToString()

    End Sub

End Class
