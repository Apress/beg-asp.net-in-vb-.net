Public Class AdBoad_DataObjects
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents gridItems As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lstCategories As System.Web.UI.WebControls.DropDownList
    Protected WithEvents cmdDisplay As System.Web.UI.WebControls.Button
    Protected WithEvents cmdAdd As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtTitle As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPrice As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents pnlNew As System.Web.UI.WebControls.Panel

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
            Dim Component As New DataObjectDB.DBUtil()

            lstCategories.DataSource = Component.GetCategories()
            lstCategories.DataTextField = "Name"
            lstCategories.DataValueField = "ID"
            lstCategories.DataBind()
            pnlNew.Visible = False
        End If
    End Sub


    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        Dim Component As New DataObjectDB.DBUtil()

        gridItems.DataSource = Component.GetItems(lstCategories.SelectedItem.Value)
        gridItems.DataBind()

        pnlNew.Visible = True
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim Component As New DataObjectDB.DBUtil()
        Component.AddItem(txtTitle.Text, txtDescription.Text, Val(txtPrice.Text), lstCategories.SelectedItem.Value)

        gridItems.DataSource = Component.GetItems(Val(lstCategories.SelectedItem.Value))
        gridItems.DataBind()
    End Sub


End Class
