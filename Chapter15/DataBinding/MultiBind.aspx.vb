Public Class MultiBind
    Inherits System.Web.UI.Page
    Protected WithEvents lblDynamic As System.Web.UI.WebControls.Label
    Protected WithEvents chkDynamic As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lnkDynamic As System.Web.UI.WebControls.HyperLink
    Protected WithEvents imgDynamic As System.Web.UI.WebControls.Image

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

    Public URL As String
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        URL = Server.MapPath("picture.jpg")
        Me.DataBind()
    End Sub

End Class
