Imports System.Web.Services

Public Class StockQuote_SessionState
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

    <WebMethod(EnableSession:=True)> _
    Public Function GetStockQuote(ByVal Ticker As String) As Decimal
        ' Increment counters. This function locks the application object to
        ' prevent synchronization errors.
        Application.Lock()
        Application(Ticker) = Application(Ticker) + 1
        Application.UnLock()
        Session(Ticker) = Session(Ticker) + 1

        ' Return a sample value representing the length of the ticker.
        Return Ticker.Length
    End Function

    <WebMethod(EnableSession:=True)> _
    Public Function GetStockUsage(ByVal Ticker As String) As CounterInfo
        Dim Result As New CounterInfo()
        Result.GlobalRequests = Application(Ticker)
        Result.SessionRequests = Session(Ticker)
        Return Result
    End Function



End Class
Public Class CounterInfo
    Public GlobalRequests As Integer
    Public SessionRequests As Integer
End Class
