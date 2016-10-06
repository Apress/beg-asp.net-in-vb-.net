Public Class TraceExample
    Inherits System.Web.UI.Page
    Protected WithEvents cmdWrite As System.Web.UI.WebControls.Button
    Protected WithEvents cmdWriteCategory As System.Web.UI.WebControls.Button
    Protected WithEvents cmdError As System.Web.UI.WebControls.Button
    Protected WithEvents cmdSession As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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
        Trace.IsEnabled = True
    End Sub

    Private Sub cmdWrite_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles cmdWrite.Click

        Trace.Write("About to place an item in session state.")
        Session("Test") = "Contents"
        Trace.Write("Placed item in session state.")

    End Sub

    Private Sub cmdWriteCategory_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles cmdWriteCategory.Click

        Trace.Write("Page_Load", "About to place an item in session state.")
        Session("Test") = "This is just a string"
        Trace.Write("Page_Load", "Placed item in session state.")

    End Sub


    Private Sub cmdError_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles cmdError.Click

        Try
            DivideNumbers(5, 0)
        Catch err As Exception
            Trace.Warn("cmdError_Click", "Caught Error", err)
        End Try

    End Sub

    Private Function DivideNumbers(ByVal number As Integer, ByVal divisor As Integer) As Integer
        Return (number / divisor)
    End Function

    Private Sub cmdSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSession.Click
        Dim ds As New DataSet()
        Session("MyDataSet") = ds
    End Sub
End Class
