Public Class SoapSecurityTest
    Inherits System.Web.UI.Page
    Protected WithEvents cmdNoHeader As System.Web.UI.WebControls.Button
    Protected WithEvents cmdHeader As System.Web.UI.WebControls.Button
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


    Private Sub cmdHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHeader.Click
        ' Create an instance of the header.
        Dim Header As New localhost4.SecurityHeader()
        Header.UserID = "Matthew"
        Header.Password = "OpenSesame"

        ' Create the proxy class.
        Dim WS As New localhost4.StockQuote_SoapSecurity()

        ' Assign the header.
        WS.SecurityHeaderValue = Header

        ' Call the service.
        lblResult.Text = "Result of MSFT call is " & WS.GetStockQuote("MSFT")

    End Sub

    Private Sub cmdNoHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoHeader.Click

        ' Create the proxy class.
        Dim WS As New localhost4.StockQuote_SoapSecurity()

        lblResult.Text = "Result of MSFT call is " & WS.GetStockQuote("MSFT")

    End Sub
End Class
