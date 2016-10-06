Imports System.Diagnostics
Imports System.Data.OleDb

Public Class MutlipleViews
    Inherits System.Web.UI.Page
    Protected WithEvents chkColumns As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents gridPubs As System.Web.UI.WebControls.DataGrid
    Protected WithEvents cmdApply As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents lblCacheStatus As System.Web.UI.WebControls.Label

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

        If Me.IsPostBack = False Then
            Cache.Remove("Titles")

            Dim dsPubs As DataSet
            If Cache("Titles") Is Nothing Then
                dsPubs = RetrieveData()
                Cache.Insert("Titles", dsPubs, Nothing, DateTime.MaxValue, TimeSpan.FromMinutes(2))
                lblCacheStatus.Text = "Created and added to cache."
            Else
                dsPubs = CType(Cache("Titles"), DataSet)
                lblCacheStatus.Text = "Retrieved from cache."
            End If

            chkColumns.DataSource = dsPubs.Tables(0).Columns
            chkColumns.DataMember = "Item"
            chkColumns.DataBind()

            gridPubs.DataSource = dsPubs.Tables(0)
            gridPubs.DataBind()
        End If
    End Sub

    Private Function RetrieveData() As DataSet
        Dim ConnectionString As String = "Provider=SQLOLEDB.1;Data Source=localhost;" & _
         "Initial Catalog=Pubs;User ID=sa"

        ' Define ADO.NET objects.
        Dim SQLSelect As String
        SQLSelect = "SELECT * FROM Titles"
        Dim con As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand(SQLSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dsPubs As New DataSet()

        con.Open()
        adapter.Fill(dsPubs, "Titles")

        con.Close()

        Return dsPubs

    End Function

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click

        Dim dsPubs As DataSet
        If Cache("Titles") Is Nothing Then
            dsPubs = RetrieveData()
            Cache.Insert("Titles", dsPubs, Nothing, DateTime.MaxValue, TimeSpan.FromMinutes(2))
            lblCacheStatus.Text = "Created and added to cache."
        Else
            dsPubs = CType(Cache("Titles"), DataSet)
            dsPubs = dsPubs.Copy()
            lblCacheStatus.Text = "Retrieved from cache."
        End If

        Dim Item As ListItem
        For Each Item In chkColumns.Items
            If Item.Selected = True Then
                dsPubs.Tables(0).Columns.Remove(Item.Text)
            End If
        Next

        gridPubs.DataSource = dsPubs.Tables(0)
        gridPubs.DataBind()
    End Sub
End Class
