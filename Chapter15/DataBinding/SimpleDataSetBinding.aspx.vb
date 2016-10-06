Public Class SimpleDataSetBinding
    Inherits System.Web.UI.Page
    Protected WithEvents lstUser As System.Web.UI.WebControls.ListBox
    
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
        'Put user code to initialize the page here
        If Me.IsPostBack = False Then

            ' Define a DataSet with a single DataTable.
            Dim dsInternal As New DataSet()
            dsInternal.Tables.Add("Users")

            ' Define two columns for this table.
            dsInternal.Tables("Users").Columns.Add("Name")
            dsInternal.Tables("Users").Columns.Add("Country")

            ' Add some actual information into the table.
            Dim rowNew As DataRow
            rowNew = dsInternal.Tables("Users").NewRow()
            rowNew("Name") = "John"
            rowNew("Country") = "Uganda"
            dsInternal.Tables("Users").Rows.Add(rowNew)

            rowNew = dsInternal.Tables("Users").NewRow()
            rowNew("Name") = "Samantha"
            rowNew("Country") = "Belgium"
            dsInternal.Tables("Users").Rows.Add(rowNew)

            rowNew = dsInternal.Tables("Users").NewRow()
            rowNew("Name") = "Rico"
            rowNew("Country") = "Japan"
            dsInternal.Tables("Users").Rows.Add(rowNew)

            ' Define the binding.
            lstUser.DataSource = dsInternal
            lstUser.DataMember = "Users"
            lstUser.DataTextField = "Name"

            ' Activate the binding.
            Me.DataBind()
        End If
    End Sub

End Class
