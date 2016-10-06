Public Class RepeaterHost
    Inherits System.Web.UI.Page
    Protected WithEvents Repeat As CustomControls.AdvancedControls.ConfigurableRepeaterControl
    Protected WithEvents cmdPostback As System.Web.UI.WebControls.Button
    Protected WithEvents cmdSetRepeatTimes As System.Web.UI.WebControls.Button

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

    Private Sub cmdSetRepeatTimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetRepeatTimes.Click
        Repeat.RepeatTimes = 5
    End Sub

    Private Sub cmdPostback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPostback.Click
        ' Do nothing.
    End Sub
End Class
