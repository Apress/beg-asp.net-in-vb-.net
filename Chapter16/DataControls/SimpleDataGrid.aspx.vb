Imports System.Data
Imports System.Data.OleDb

Public Class SimpleDataGrid
    Inherits System.Web.UI.Page
    
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
    Protected WithEvents gridAuthor As System.Web.UI.WebControls.DataGrid

#End Region
    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
    "DataSource=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Create and fill a DataSet.
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Pubs As New DataSet()
        adapter.Fill(Pubs, "Authors")
        con.Close()

        ' Bind the DataSet, and activate the data bindings for the page.
        gridAuthor.AutoGenerateColumns = True
        gridAuthor.DataSource = Pubs.Tables("Authors")
        Me.DataBind()

    End Sub

End Class
