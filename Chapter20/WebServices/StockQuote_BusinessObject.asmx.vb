Imports System.Web.Services

<WebService(Description:="Methods to get information about a NASDAQ stock.", _
Namespace:="http://www.prosetech.com/Stocks")> _
Public Class StockQuote_BusinessObject
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
    End Sub

#End Region



        <WebMethod(Description:="Gets a price quote for a NASDAQ stock symbol.")> _
        Public Function GetStockQuote(ByVal Ticker As String) As StockInfo
            Dim Quote As New StockInfo()
            Quote.Symbol = Ticker
            Quote = FillQuoteFromDB(Quote)
            Return Quote
        End Function

        Private Function FillQuoteFromDB(ByVal Lookup As StockInfo) As StockInfo
            ' You can add the appropriate database code here.
            ' For test purposes this function hard-codes some information.
            Lookup.CompanyName = "Trapezoid"
            Lookup.Price = 400
            Lookup.High_52Week = 410
            Lookup.Low_52Week = 20
            Return Lookup
        End Function

    End Class



Public Class StockInfo
    Public Price As Decimal
    Public Symbol As String
    Public High_52Week As Decimal
    Public Low_52Week As Decimal
    Public CompanyName As String
End Class


