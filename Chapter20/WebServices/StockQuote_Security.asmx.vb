Imports System.Web.Services

Public Class StockQuote_Security
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

    <WebMethod()> _
    Public Function Login(ByVal ID As String, ByVal Password As String) As LicenseKey      
        If VerifyUser(ID, Password) = True Then
            ' Generate a license key made up of
            ' some random sequence of characters.
            Dim Key As LicenseKey

            ' A value is hard-coded here. Typically, it would be
            ' generated using some algorithm (maybe incoporating the
            ' current time of day and user ID).
            Key.Key = "s0d343520lgfgfg"

            ' The key would then be added to some temporary
            ' license database.
        Else
            ' Cause an error that will be returned to the client.
            ' The function gets a little fancy and uses a special exception.
            Throw New System.Security.SecurityException()
        End If
    End Function

    <WebMethod()> _
    Public Function GetStockQuote(ByVal Ticker As String, ByVal Key As LicenseKey) As Integer
        If VerifyKey(Key) = False Then
            Throw New System.Security.SecurityException()
        Else
            ' Normal GetStockQuote code goes here.
            Return (Ticker.Length)
        End If
    End Function

    Private Function VerifyUser(ByVal ID As String, ByVal Password As String) As Boolean
        ' Add database lookup code here to verify the user.
        Return True
    End Function

    Private Function VerifyKey(ByVal Key As LicenseKey) As Boolean
        ' Look up key in key database. If it's not there
        ' (or it's expired, return False).
        Return True
    End Function
End Class

Public Class LicenseKey
    Public Key As String
End Class