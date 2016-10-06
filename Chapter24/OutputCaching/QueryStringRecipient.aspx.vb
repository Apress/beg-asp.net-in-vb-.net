Public Class QueryStringOutputCaching
    Inherits System.Web.UI.Page
    Protected WithEvents lblDate As System.Web.UI.WebControls.Label

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

        lblDate.Text = "The time is now:<br>" & DateTime.Now.ToString()
        Select Case Request.QueryString("Version")
            Case "cmdLarge"
                lblDate.Font.Size = FontUnit.XLarge
            Case "cmdNormal"
                lblDate.Font.Size = FontUnit.Large
            Case "cmdSmall"
                lblDate.Font.Size = FontUnit.Small
        End Select

    End Sub


End Class
