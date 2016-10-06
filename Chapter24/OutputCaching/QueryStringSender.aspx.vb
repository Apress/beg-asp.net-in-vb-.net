Public Class QueryStringSender
    Inherits System.Web.UI.Page
    Protected WithEvents cmdSmall As System.Web.UI.WebControls.Button
    Protected WithEvents cmdNormal As System.Web.UI.WebControls.Button
    Protected WithEvents cmdLarge As System.Web.UI.WebControls.Button

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


    Private Sub cmdVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles cmdLarge.Click, cmdNormal.Click, cmdSmall.Click
        Response.Redirect("QueryStringRecipient.aspx" & "?Version=" & CType(sender, Control).ID)
    End Sub

End Class
