Public Class SimpleCounter
    Inherits System.Web.UI.Page
    Protected WithEvents lblCount As System.Web.UI.WebControls.Label
    Protected WithEvents cmdIncrement As System.Web.UI.WebControls.Button

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

    Private Sub cmdIncrement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncrement.Click

        If Me.ViewState("Counter") = Nothing Then
            Me.ViewState("Counter") = 1
        Else
            Me.ViewState("Counter") = CType(Me.ViewState("Counter"), Integer) + 1
        End If
        lblCount.Text = "Counter: " & CType(Me.ViewState("Counter"), Integer)

    End Sub
End Class
