Public Class NameTextBoxHost
    Inherits System.Web.UI.Page
    Protected WithEvents lblNames As System.Web.UI.WebControls.Label
    Protected WithEvents cmdGetNames As System.Web.UI.WebControls.Button
    Protected WithEvents NameTextBox1 As AdvancedControls.NameTextBox

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

    Private Sub cmdGetNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetNames.Click
        lblNames.Text = "<b>First name:</b> " & NameTextBox1.GetFirstName()
        lblNames.Text &= "<br><b>Last name:</b> " & NameTextBox1.GetLastName()
    End Sub
End Class
