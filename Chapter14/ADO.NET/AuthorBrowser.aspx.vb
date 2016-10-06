Imports System.Data.OleDb
Imports System.Data
Public Class AuthorBrowser
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents lstAuthor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents cmdDelete As System.Web.UI.WebControls.Button
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents lblResults As System.Web.UI.WebControls.Label



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
     "Data Source=localhost;Initial Catalog=pubs;Integrated Security=SSPI"


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack = False Then

            FillAuthorList()

        End If
    End Sub


    Private Sub lstAuthor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAuthor.SelectedIndexChanged

        ' Create a Select statement that searches for a record
        ' matching the specific author id from the Value property.
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors "
        strSelect &= "WHERE au_id='" & lstAuthor.SelectedItem.Value & "'"

        ' Define the ADO.NET objects.
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim reader As OleDbDataReader

        ' Try to open database and read information.
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            lblResults.Text = "<b>" & reader("au_lname")
            lblResults.Text &= ", " & reader("au_fname") & "</b><br>"
            lblResults.Text &= "Phone: " & reader("phone") & "<br>"
            lblResults.Text &= "Address: " & reader("address") & "<br>"
            lblResults.Text &= "City: " & reader("city") & "<br>"
            lblResults.Text &= "State: " & reader("state") & "<br>"
            reader.Close()
        Catch err As Exception
            lblResults.Text = "Error getting author. "
            lblResults.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try

    End Sub

    Private Sub FillAuthorList()
        ' Define the Select statement.
        ' Three pieces of information are needed: the unique id,
        ' and the first and last name.
        Dim strSelect As String
        strSelect = "SELECT au_lname, au_fname, au_id FROM Authors"

        ' Define the ADO.NET objects.
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim reader As OleDbDataReader

        ' Try to open database and read information.
        Try
            con.Open()
            reader = cmd.ExecuteReader()

            ' For each item, add the author name to the displayed
            ' list box text, and store the unique ID in the Value property.
            Do While reader.Read()
                Dim NewItem As New ListItem()
                NewItem.Text = reader("au_lname") & ", " & reader("au_fname")
                NewItem.Value = reader("au_id")
                lstAuthor.Items.Add(NewItem)
            Loop

            reader.Close()

        Catch err As Exception
            lblResults.Text = "Error reading list of names. "
            lblResults.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try
    End Sub
End Class
