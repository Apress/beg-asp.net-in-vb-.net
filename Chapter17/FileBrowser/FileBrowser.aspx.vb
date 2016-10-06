Imports System.IO
Public Class FileBrowser
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents cmdBrowse As System.Web.UI.WebControls.Button
    Protected WithEvents lblFileInfo As System.Web.UI.WebControls.Label
    Protected WithEvents lstDirs As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstFiles As System.Web.UI.WebControls.ListBox
            Protected WithEvents lblCurrentDir As System.Web.UI.WebControls.Label
    Protected WithEvents cmdParent As System.Web.UI.WebControls.Button
    Protected WithEvents cmdShowInfo As System.Web.UI.WebControls.Button

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
        If Me.IsPostBack = False Then
            Dim StartingDir As String = "C:\Temp"
            lblCurrentDir.Text = StartingDir
            ShowFilesIn(StartingDir)
            ShowDirectoriesIn(StartingDir)
        End If
    End Sub

    Private Sub ShowFilesIn(ByVal Dir As String)
        Dim DirInfo As New DirectoryInfo(Dir)
        Dim FileItem As FileInfo

        lstFiles.Items.Clear()
        For Each FileItem In DirInfo.GetFiles()
            lstFiles.Items.Add(FileItem.Name)
        Next
    End Sub

    Private Sub ShowDirectoriesIn(ByVal Dir As String)
        Dim DirInfo As New DirectoryInfo(Dir)
        Dim DirItem As DirectoryInfo

        lstDirs.Items.Clear()
        For Each DirItem In DirInfo.GetDirectories()
            lstDirs.Items.Add(DirItem.Name)
        Next
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        ' Browse to the currently selected subdirectory.
        If lstDirs.SelectedIndex <> -1 Then
            Dim NewDir As String = lblCurrentDir.Text.TrimEnd("\") & "\" & lstDirs.SelectedItem.Text
            lblCurrentDir.Text = NewDir
            ShowFilesIn(NewDir)
            ShowDirectoriesIn(NewDir)
        End If
    End Sub

    Private Sub cmdParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdParent.Click
        ' Browse up to the current directory's parent.
        ' The Directory.GetParent method helps us out.
        Dim NewDir As String
        If Directory.GetParent(lblCurrentDir.Text) Is Nothing Then
            ' This is the root directory; there are no more levels.
            Exit Sub
        Else
            NewDir = Directory.GetParent(lblCurrentDir.Text).FullName
        End If

        lblCurrentDir.Text = NewDir
        ShowFilesIn(NewDir)
        ShowDirectoriesIn(NewDir)
    End Sub

    Private Sub cmdShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowInfo.Click
        ' Show information for the currently selected file.
        If lstFiles.SelectedIndex <> -1 Then
            Dim FileName As String = lblCurrentDir.Text.TrimEnd("\") & "\" & lstFiles.SelectedItem.Text
            Dim SelFile As New FileInfo(FileName)
            lblFileInfo.Text = "<b>" & SelFile.Name & "</b><br>"
            lblFileInfo.Text &= "Size: " & SelFile.Length & "<br>"
            lblFileInfo.Text &= "Created: " & SelFile.CreationTime.ToString() & "<br>"
            lblFileInfo.Text &= "Last Accessed: " & SelFile.LastAccessTime.ToString()
        End If
    End Sub

 
End Class
