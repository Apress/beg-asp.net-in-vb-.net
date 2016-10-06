Imports System.Data.OleDb
Public Class DataListSelect
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

#End Region

    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
         "DataSource=localhost;Initial Catalog=pubs;Integrated Security=SSPI"


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.IsPostBack = False Then
            Dim ds As DataSet = GetDataSet()
            BindGrid(ds)
        End If
    End Sub



    Private Sub listAuthor_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles listAuthor.ItemCommand
        If e.CommandName = "Select" Then
            listAuthor.SelectedIndex = e.Item.ItemIndex
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




End Class





