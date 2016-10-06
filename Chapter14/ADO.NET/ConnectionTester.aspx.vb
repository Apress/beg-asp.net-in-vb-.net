Imports System.Data.OleDb
Public Class ConnectionTester
    Inherits System.Web.UI.Page
    Protected WithEvents cmdConnect As System.Web.UI.WebControls.Button
    Protected WithEvents optSQL As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optWindows As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel

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

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click

        ' Define the connection string.
        Dim strConnection As String = "Provider=SQLOLEDB.1;" & _
         "Data Source=localhost;Initial Catalog=pubs;"
        If optWindows.Checked = True Then
            strConnection &= "Integrated Security=SSPI"
        Else
            strConnection &= "User ID=sa"
        End If

        ' Define the ADO.NET connection object.
        Dim MyConnection As New OleDbConnection(strConnection)
        
        Try
            ' Try to open the connection.
            MyConnection.Open()
            lblInfo.Text = "<b>Server Version:</b> " & MyConnection.ServerVersion
            lblInfo.Text &= "<br><b>Connection Is:</b> " & MyConnection.State.ToString()
        Catch err As Exception
            ' Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. "
            lblInfo.Text &= err.Message
        Finally
            ' Either way, make sure the connection is properly closed.
            If Not MyConnection Is Nothing Then MyConnection.Close()
            lblInfo.Text &= "<br><b>Now Connection Is:</b> "
            lblInfo.Text &= MyConnection.State.ToString
        End Try


    End Sub
End Class
