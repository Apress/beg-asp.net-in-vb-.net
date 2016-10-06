Imports System.IO
Public Class GuestBook
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
    Protected WithEvents GuestBookList As System.Web.UI.WebControls.DataList
    Protected WithEvents cmdSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents txtMessage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

#End Region

    Private GuestBookName As String = "C:\ASP.NET\Chapter17\GuestBook\GuestBook"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack = False Then
            GuestBookList.DataSource = GetAllEntries()
            GuestBookList.DataBind()
        End If
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        ' Create a new BookEntry object.
        Dim NewEntry As New BookEntry()
        NewEntry.Author = txtName.Text
        NewEntry.Submitted = DateTime.Now
        NewEntry.Message = txtMessage.Text

        ' Let the SaveEntry procedure create the corresponding file.
        SaveEntry(NewEntry)

        ' Refresh the display.
        GuestBookList.DataSource = GetAllEntries()
        GuestBookList.DataBind()

        txtName.Text = ""
        txtMessage.Text = ""
    End Sub

    Private Function GetAllEntries() As ArrayList
        ' Return an ArrayList that contains BookEntry objects
        ' for each file in the GuestBook directory.
        ' This function relies on the GetEntryFromFile function.
        Dim Entries As New ArrayList()
        Dim GuestBookDir As New DirectoryInfo(GuestBookName)

        Dim FileItem As FileInfo
        For Each FileItem In GuestBookDir.GetFiles()
            Entries.Add(GetEntryFromFile(FileItem))
        Next

        Return Entries
    End Function

    Private Function GetEntryFromFile(ByVal EntryFile As FileInfo) As BookEntry
        ' Turn the file information into a Book Entry object.
        Dim NewEntry As New BookEntry()
        Dim r As StreamReader = EntryFile.OpenText()
        NewEntry.Author = r.ReadLine()
        NewEntry.Submitted = DateTime.Parse(r.ReadLine())
        NewEntry.Message = r.ReadLine()
        r.Close()

        Return NewEntry
    End Function

    Private Sub SaveEntry(ByVal Entry As BookEntry)
        ' Create a new file for this entry, with a filename that should
        ' be unique.
        Dim Rand As New Random()
        Dim FileName As String = GuestBookName & "\"
        FileName &= DateTime.Now.Ticks.ToString() & Rand.Next(100)
        Dim NewFile As New FileInfo(FileName)
        Dim w As StreamWriter = NewFile.CreateText()

        ' Write the information to the file.
        w.WriteLine(Entry.Author)
        w.WriteLine(Entry.Submitted.ToString())
        w.WriteLine(Entry.Message)
        w.Close()
    End Sub
End Class

Public Class BookEntry
    Public _Author As String
    Public _Submitted As Date
    Public _Message As String

    Public Property Author() As String
        Get
            Return _Author
        End Get
        Set(ByVal Value As String)
            _Author = Value
        End Set
    End Property

    Public Property Submitted() As Date
        Get
            Return _Submitted
        End Get
        Set(ByVal Value As Date)
            _Submitted = Value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return _Message
        End Get
        Set(ByVal Value As String)
            _Message = Value
        End Set
    End Property
End Class
