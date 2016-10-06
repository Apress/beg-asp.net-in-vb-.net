Public Class PreserveMembers
    Inherits System.Web.UI.Page
    Protected WithEvents cmdSave As System.Web.UI.WebControls.Button
    Protected WithEvents txtValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdLoad As System.Web.UI.WebControls.Button

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

    ' A member variable that ordinarily will be cleared with every postback.
    Private Contents As String

    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Me.IsPostBack = True Then
            ' Restore variables.
            Contents = CType(Me.ViewState("Text"), String)
        End If
    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles MyBase.PreRender
        ' Persist variables.
        Me.ViewState("Text") = Contents
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdSave.Click
        ' Transfer contents of text box to member variable.
        Contents = txtValue.Text

        txtValue.Text = ""
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdLoad.Click
        ' Restore contents of member variable to text box.
        txtValue.Text = Contents
    End Sub


End Class
