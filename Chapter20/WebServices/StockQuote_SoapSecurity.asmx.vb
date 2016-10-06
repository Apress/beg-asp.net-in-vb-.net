Imports System.Web.Services
Imports System.Web.Services.Protocols


<WebService(Namespace := "http://tempuri.org/")> _
Public Class StockQuote_SoapSecurity
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    Public KeyHeader As SecurityHeader

    <WebMethod(), SoapHeader("KeyHeader", Direction:=SoapHeaderDirection.InOut)> _
    Public Function GetStockQuote(ByVal Ticker As String) As Integer
        If VerifyKey(KeyHeader) = False Then
            Throw New System.Security.SecurityException()
        Else
            ' Normal GetStockQuote code goes here.
            Return (Ticker.Length)
        End If
    End Function

    Private Function VerifyKey(ByVal Key As SecurityHeader) As Boolean
        If Key.Key = "" Then
            ' Look up the user in the database and assign the key.
            ' Add the key to temporary database and return True.
        Else
            ' Look up key in key database. If it's not there
            ' (or it's expired, return False).
        End If

        ' This test function always returns true.
        Return True
    End Function


End Class



Public Class SecurityHeader
    Inherits System.Web.Services.Protocols.SoapHeader

    Public UserID As String
    Public Password As String
    Public Key As String
End Class
