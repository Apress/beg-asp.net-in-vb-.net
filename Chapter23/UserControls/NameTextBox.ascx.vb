Public MustInherit Class NameTextBox
    Inherits System.Web.UI.UserControl
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox

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

    Private _FirstName As String
    Private _LastName As String

    Public Function GetFirstName() As String
        UpdateNames()
        Return _FirstName
    End Function

    Public Function GetLastName() As String
        UpdateNames()
        Return _LastName
    End Function

    Private Sub UpdateNames()
        Dim CommaPos As Integer = txtName.Text.IndexOf(",")
        Dim SpacePos As Integer = txtName.Text.IndexOf(" ")

        Dim NameArray() As String

        If CommaPos <> -1 Then
            NameArray = txtName.Text.Split(",")
            _FirstName = NameArray(1)
            _LastName = NameArray(0)
        ElseIf SpacePos <> -1 Then
            NameArray = txtName.Text.Split(" ")
            _FirstName = NameArray(0)
            _LastName = NameArray(1)
        Else
            ' The text has no comma or space.
            ' It cannot be converted to a name.
            Throw New InvalidOperationException()
        End If
    End Sub

End Class
