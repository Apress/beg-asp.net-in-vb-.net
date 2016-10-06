Imports Microsoft.Web.UI.WebControls

Public Class TreeViewTest
    Inherits System.Web.UI.Page
    Protected WithEvents TreeView1 As Microsoft.Web.UI.WebControls.TreeView
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
        If Not Me.IsPostBack Then

            Dim RootNode As TreeNode
            RootNode = AddNode("default.aspx", "My Site", "Folder", TreeView1.Nodes)

            AddNode("home.aspx", "Home Page", "Page", RootNode.Nodes)
            AddNode("search.aspx", "Search Page", "Page", RootNode.Nodes)
            AddNode("contact.aspx", "Contact Page", "Page", RootNode.Nodes)
            AddNode("info.aspx", "Contact Page", "Page", RootNode.Nodes)
            RootNode.Expanded = True

            RootNode = AddNode("links.aspx", "Links", "Folder", TreeView1.Nodes)
            AddNode("http://www.nytimes.com", "New York Times", "Page", RootNode.Nodes)
            AddNode("http://www.theonion.com", "The Onion", "Page", RootNode.Nodes)
            AddNode("http://www.zdnet.com", "ZDNet", "Page", RootNode.Nodes)
            AddNode("http://www.google.com", "Google", "Page", RootNode.Nodes)
            RootNode.Expanded = True

        End If
    End Sub

    Private Function AddNode(ByVal id As String, ByVal text As String, ByVal type As String, ByVal nodeCollection As TreeNodeCollection) As TreeNode
        Dim Node As New TreeNode()
        Node.Text = text
        Node.Type = type
        Node.ID = id
        nodeCollection.Add(Node)
        Return Node
    End Function

    Private Sub TreeView1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As Microsoft.Web.UI.WebControls.TreeViewSelectEventArgs) Handles TreeView1.SelectedIndexChange
        Dim SelectedNode As TreeNode = TreeView1.GetNodeFromIndex(e.NewNode)
        Response.Redirect(SelectedNode.ID)
    End Sub
End Class
