Imports System.Data.OleDb

Public Class DataGridEdit
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
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label

#End Region

    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
         "DataSource=localhost;Initial Catalog=pubs;Integrated Security=SSPI"


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.IsPostBack = False Then
            Dim ds As DataSet = GetDataSet()
            BindGrid(ds)
        End If
    End Sub



    Public Function GetDataSet() As DataSet
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dsPubs As New DataSet()
        adapter.Fill(dsPubs, "Authors")
        con.Close()
        Return dsPubs
    End Function

    Public Sub BindGrid(ByVal ds As DataSet)
        gridAuthor.DataSource = ds.Tables("Authors")
        Me.DataBind()
    End Sub


    Private Sub gridAuthor_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles gridAuthor.EditCommand
        gridAuthor.EditItemIndex = e.Item.ItemIndex
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub


    Private Sub gridAuthor_PageIndexChanged(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles gridAuthor.PageIndexChanged
        gridAuthor.CurrentPageIndex = e.NewPageIndex
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub

    Private Sub gridAuthor_SortCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles gridAuthor.SortCommand
        Dim ds As DataSet = GetDataSet()
        ' Apply the sort expression to the default view for the table.
        ds.Tables("Authors").DefaultView.Sort = e.SortExpression
        BindGrid(ds)
    End Sub

    Private Sub gridAuthor_UpdateCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles gridAuthor.UpdateCommand

        'Create variables to hold new values.
        Dim strNewFirstName, strNewLastName As String
        Dim strNewCity, strNewAddress As String

        ' Retrieve the new values.
        strNewFirstName = CType(e.Item.FindControl("txtfname"), TextBox).Text
        strNewLastName = CType(e.Item.FindControl("txtlname"), TextBox).Text
        strNewCity = CType(e.Item.Cells(2).Controls(0), TextBox).Text
        strNewAddress = CType(e.Item.Cells(3).Controls(0), TextBox).Text

        ' Retrieve the author ID to look up the record.
        Dim strID As String
        strID = e.Item.Cells(0).Text

        ' Define the SQL Update statement.
        Dim strUpdate As String
        strUpdate = "UPDATE Authors SET "
        strUpdate &= "au_fname='" & strNewFirstName & "', "
        strUpdate &= "au_lname='" & strNewLastName & "', "
        strUpdate &= "city='" & strNewCity & "', "
        strUpdate &= "address='" & strNewAddress & "' "
        strUpdate &= "WHERE au_id='" & strID & "'"

        ' Create the ADO.NET objects.
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strUpdate, con)

        ' Try to open database and execute the update.
        Try
            con.Open()
            Dim intUpdated As Integer
            intUpdated = cmd.ExecuteNonQuery
            lblStatus.Text = intUpdated.ToString & " records updated."
        Catch err As Exception
            lblStatus.Text = "Error updating author. "
            lblStatus.Text &= err.Message
        Finally
            If Not con Is Nothing Then con.Close()
        End Try


        ' Cancel edit mode.
        gridAuthor.EditItemIndex = -1

        ' Rebind the grid.
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub

    Private Sub gridAuthor_CancelCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles gridAuthor.CancelCommand
        gridAuthor.EditItemIndex = -1
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub


End Class