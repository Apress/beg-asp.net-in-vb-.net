Imports System.Data.OleDb
Imports System.Data

Public Class FancyStyleAuthorList
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
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents txtColumns As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents optVertical As System.Web.UI.WebControls.RadioButton
    Protected WithEvents optHorizontal As System.Web.UI.WebControls.RadioButton

#End Region

    Private strConnection As String = "Provider=SQLOLEDB.1;" & _
     "DataSource=localhost;Initial Catalog=pubs;Integrated Security=SSPI"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Rebuild the table.
        Dim strSelect As String
        strSelect = "SELECT * FROM Authors"
        Dim con As New OleDbConnection(strConnection)
        Dim cmd As New OleDbCommand(strSelect, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Pubs As New DataSet()

        adapter.Fill(Pubs, "Authors")
        listAuthor.DataSource = Pubs.Tables("Authors")

        If Not Me.IsPostBack = True Then
            Me.DataBind()
        End If

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        listAuthor.RepeatColumns = Val(txtColumns.Text)
        If optVertical.Checked = True Then
            listAuthor.RepeatDirection = RepeatDirection.Vertical
        Else
            listAuthor.RepeatDirection = RepeatDirection.Horizontal
        End If
        Me.DataBind()
    End Sub
End Class

