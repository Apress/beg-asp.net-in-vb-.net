Imports System.Data.OleDb
Imports System.Data

Public Class AuthorListMultipleTemplates
    Inherits System.Web.UI.Page
    Protected WithEvents listAuthor As System.Web.UI.WebControls.DataList

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
    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
     "DataSource=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Pubs As New DataSet()

        adapter.Fill(Pubs, "Authors")
        listAuthor.DataSource = Pubs.Tables("Authors")
        Me.DataBind()
    End Sub

End Class
