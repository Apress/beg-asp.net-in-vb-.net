Imports Microsoft.Web.UI.WebControls

Public Class ToolbarTest
    Inherits System.Web.UI.Page
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents Toolbar1 As Microsoft.Web.UI.WebControls.Toolbar

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


    Private Sub Toolbar1_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Toolbar1.ButtonClick
        Dim ClickedButton As ToolbarButton = CType(sender, ToolbarButton)

        If ClickedButton.ID = "Help" Then
            lblInfo.Text = "You clicked the Help button."
        Else
            lblInfo.Text = "You clicked: " & ClickedButton.Text
        End If
    End Sub
End Class
