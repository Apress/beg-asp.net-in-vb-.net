' Import the namespace that includes the I/O classes.
Imports System.IO

Public Class ViewFiles
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents lstFiles As System.Web.UI.WebControls.ListBox
    Protected WithEvents cmdRefresh As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFileInfo As System.Web.UI.WebControls.Label
    Protected WithEvents cmdDelete As System.Web.UI.WebControls.Button
    
#End Region

    Public FTPDirectory As String = "C:\Temp"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack = False Then
            CreateFileList()
        End If
    End Sub

    Private Sub CreateFileList()
        ' Retrieve the list of files, and display it in the page.
        ' This code also disables the delete button, ensuring the
        ' user must view the file information before deleting it.
        Dim FileList() As String = Directory.GetFiles(FTPDirectory)
        lstFiles.DataSource = FileList
        lstFiles.DataBind()
        lblFileInfo.Text = ""
        cmdDelete.Enabled = False
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        CreateFileList()
    End Sub

    Private Sub lstFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFiles.SelectedIndexChanged

        ' Display the selected file information.
        ' This control has AutoPostback = True.
        Dim FileName As String = lstFiles.SelectedItem.Text
        lblFileInfo.Text = "<b>" & FileName & "</b><br>"
        lblFileInfo.Text &= "Created : "
        lblFileInfo.Text &= File.GetCreationTime(FileName).ToString() & "<br>"
        lblFileInfo.Text &= "Last Accessed : "
        lblFileInfo.Text &= File.GetLastAccessTime(FileName).ToString() & "<br>"

        ' Show attribute information. GetAttributes can return a combination
        ' of enumerated values, so you need to evaluate it with the And keyword.
        Dim Attributes As FileAttributes = File.GetAttributes(FileName)
        If (Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
            lblFileInfo.Text &= "This is a hidden file." & "<br>"
        End If
        If (Attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
            lblFileInfo.Text &= "This is a read-only file." & "<br>"
        End If

        ' Allow the file to be deleted.
        If (Attributes And FileAttributes.ReadOnly) <> FileAttributes.ReadOnly Then
            cmdDelete.Enabled = True
        End If

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        File.Delete(lstFiles.SelectedItem.Text)
        CreateFileList()
    End Sub

End Class
