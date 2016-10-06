Imports System.Data.OleDb
Public Class DataListEdit
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
    Protected WithEvents listAuthor As System.Web.UI.WebControls.DataList
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
        listAuthor.DataSource = ds.Tables("Authors")
        Me.DataBind()
    End Sub


    Private Sub listAuthor_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles listAuthor.EditCommand
        listAuthor.EditItemIndex = e.Item.ItemIndex
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub

    Private Sub listAuthor_CancelCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs) Handles listAuthor.CancelCommand
        listAuthor.EditItemIndex = -1
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub

    Private Sub listAuthor_UpdateCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs) Handles listAuthor.UpdateCommand

        'Create variables to hold new values.
        Dim strNewCity, strNewAddress As String

        ' Retrieve the new values.
        strNewCity = CType(e.Item.FindControl("txtCity"), TextBox).Text
        strNewAddress = CType(e.Item.FindControl("txtAddress"), TextBox).Text

        ' Retrieve the author ID to look up the record.
        Dim strID As String
        strID = CType(e.Item.FindControl("lblID"), Label).Text

        ' Define the SQL Update statement.
        Dim strUpdate As String
        strUpdate = "UPDATE Authors SET "
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
        listAuthor.EditItemIndex = -1

        ' Rebind the grid.
        Dim ds As DataSet = GetDataSet()
        BindGrid(ds)
    End Sub


End Class
