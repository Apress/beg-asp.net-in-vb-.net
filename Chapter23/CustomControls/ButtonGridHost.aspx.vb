Public Class ButtonGridHost
    Inherits System.Web.UI.Page
    Protected WithEvents txtRows As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtCols As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents ButtonGrid1 As CustomControls.ButtonGrid

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
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        ButtonGrid1.Rows = txtRows.Text.ToString()
        ButtonGrid1.Cols = txtCols.Text.ToString()
    End Sub

    Private Sub ButtonGrid1_GridClick(ByVal ButtonName As String) Handles ButtonGrid1.GridClick
        lblInfo.Text = "You clicked: " & ButtonName
    End Sub
End Class
