Imports System.Web.Caching
Imports System.IO

Public Class CacheDependency
    Inherits System.Web.UI.Page
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label
    Protected WithEvents cmdGetItem As System.Web.UI.WebControls.Button
    Protected WithEvents cmdModfiy As System.Web.UI.WebControls.Button

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
            lblInfo.Text &= "Creating dependent item...<br>"
            Cache.Remove("Dependent")
            Dim Dependency As New System.Web.Caching.CacheDependency(Server.MapPath("dependency.txt"))
            Dim Item As String = "Dependent cached item"
            lblInfo.Text &= "Adding dependent item<br>"
            Cache.Insert("Dependent", Item, Dependency)
        End If
    End Sub

    Private Sub cmdModfiy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModfiy.Click

        lblInfo.Text &= "Modifying dependency.txt file.<br>"
        Dim w As StreamWriter = File.CreateText(Server.MapPath("dependency.txt"))
        w.Write(DateTime.Now)
        w.Flush()
        w.Close()


    End Sub

    Private Sub cmdGetItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetItem.Click

        If Cache("Dependent") Is Nothing Then
            lblInfo.Text &= "Cache item no longer exits.<br>"
        Else
            Dim CacheInfo As String = Cache("Dependent")
            lblInfo.Text &= "Retrieved item with text: '" & CacheInfo & "'<br>"
        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
        lblInfo.Text &= "<br>"
    End Sub
End Class
