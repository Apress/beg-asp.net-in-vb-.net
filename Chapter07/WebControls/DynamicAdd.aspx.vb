Public Class DynamicAdd
    Inherits System.Web.UI.Page
    Protected WithEvents AddControl As System.Web.UI.HtmlControls.HtmlInputButton

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

    Private Sub AddControl_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddControl.ServerClick
        Dim ctrl As New HtmlButton()
        ctrl.InnerText = "Dynamic Button"
        Me.Controls.Add(ctrl)


    End Sub
End Class
