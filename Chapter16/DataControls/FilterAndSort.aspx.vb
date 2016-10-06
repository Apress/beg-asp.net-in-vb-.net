Imports System.Data.OleDb

Public Class FilterAndSort
    Inherits System.Web.UI.Page
    Protected WithEvents gridAuthor As System.Web.UI.WebControls.DataGrid

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

        ' Create and fill a DataSet.
        Dim SQL As String
        SQL = "SELECT au_lname, au_fname, phone, address, state, contract FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(SQL, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Pubs As New DataSet()
        adapter.Fill(Pubs, "Authors")
        con.Close()

        ' Apply custom sorting and filtering.
        Pubs.Tables("Authors").DefaultView.Sort = "au_lname ASC"
        Pubs.Tables("Authors").DefaultView.RowFilter = "state='CA' AND contract='true'"

        ' Bind the DataSet, and activate the data bindings for the page.
        gridAuthor.AutoGenerateColumns = True
        gridAuthor.DataSource = Pubs.Tables("Authors")
        Me.DataBind()

    End Sub
End Class
