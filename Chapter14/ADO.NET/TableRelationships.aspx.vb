Imports System.Data.OleDb
Imports System.Data

Public Class TableRelationships
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
    Protected WithEvents lblList As System.Web.UI.WebControls.Label

#End Region
    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
       "Data Source=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Me.IsPostBack = False Then

            CreateList()
        End If
    End Sub

    Private Sub CreateList()

        ' Define ADO.NET objects.
        Dim strSelect As String
        strSelect = "SELECT au_lname, au_fname, au_id FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dsPubs As New DataSet()

        ' Try to open database and read information.
        Try
            con.Open()
            adapter.Fill(dsPubs, "Authors")

            ' This command is still linked to the data adapter.
            cmd.CommandText = "SELECT au_id, title_id FROM TitleAuthor"
            adapter.Fill(dsPubs, "TitleAuthor")

            ' This command is still linked to the data adapter.
            cmd.CommandText = "SELECT title_id, title FROM Titles"
            adapter.Fill(dsPubs, "Titles")

        Catch err As Exception
            lblList.Text = "Error reading list of names. "
            lblList.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

        ' Create the links between the tables.
        ' Two links are needed: to connect Titles --> TitleAuthor,
        ' and to connect TitleAuthor --> Authors.
        Dim Titles_TitleAuthor As New DataRelation("", _
          dsPubs.Tables("Titles").Columns("title_id"), _
          dsPubs.Tables("TitleAuthor").Columns("title_id"))
        Dim Authors_TitleAuthor As New DataRelation("", _
          dsPubs.Tables("Authors").Columns("au_id"), _
          dsPubs.Tables("TitleAuthor").Columns("au_id"))

        ' Add the relation to the DataSet.
        dsPubs.Relations.Add(Titles_TitleAuthor)
        dsPubs.Relations.Add(Authors_TitleAuthor)

        Dim rowAuthor, rowTitleAuthor, rowTitle As DataRow
        For Each rowAuthor In dsPubs.Tables("Authors").Rows
            lblList.Text &= "<br><b>" & rowAuthor("au_fname")
            lblList.Text &= " " & rowAuthor("au_lname") & "</b><br>"

            For Each rowTitleAuthor In rowAuthor.GetChildRows(Authors_TitleAuthor)
                For Each rowTitle In rowTitleAuthor.GetParentRows(Titles_TitleAuthor)
                    lblList.Text &= "&nbsp;&nbsp;"   ' Non-breaking spaces.
                    lblList.Text &= rowTitle("title") & "<br>"
                Next
            Next
        Next

    End Sub
End Class
