Imports System.IO
Public Class UploadFile
    Inherits System.Web.UI.Page
    Protected WithEvents cmdUpload As System.Web.UI.WebControls.Button
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents FileInput As System.Web.UI.HtmlControls.HtmlInputFile

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
        ' Only accept image types.
        FileInput.Accept = "image/*"
    End Sub

    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click

        ' Check that a file is actually being submitted.
        If FileInput.PostedFile.FileName = "" Then
            lblInfo.Text = "No file specified."
        Else
            Try
                ' The saved file will retain its original file name,
                ' but be stored in the current server application directory.
                ' To retrieve the file name, the code uses the shared
                ' Path.GetFileName method, which retrieves the file name
                ' portion from a fully-qualified path.
                Dim ServerFileName As String
                ServerFileName = Path.GetFileName(FileInput.PostedFile.FileName)

                FileInput.PostedFile.SaveAs("C:\" & ServerFileName)
                lblInfo.Text = "File " & ServerFileName & " uploaded successfully."
            Catch err As Exception
                lblInfo.Text = err.Message
            End Try
        End If

    End Sub


End Class
