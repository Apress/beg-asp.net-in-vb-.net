Public Class CheckBoxTest
    Inherits System.Web.UI.Page
    Protected WithEvents chklst As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents cmdOK As System.Web.UI.WebControls.Button
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles MyBase.Load
        If Me.IsPostBack = False Then
            chklst.Items.Add("C")
            chklst.Items.Add("C++")
            chklst.Items.Add("C#")
            chklst.Items.Add("Visual Basic 6.0")
            chklst.Items.Add("VB.NET")
            chklst.Items.Add("Pascal")
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles cmdOK.Click

        lblResult.Text = "You chose:<b>"

        Dim lstItem As ListItem
        For Each lstItem In chklst.Items
            If lstItem.Selected = True Then
                ' Add text to label.
                lblResult.Text &= "<br>" & lstItem.Text
            End If
        Next

        lblResult.Text &= "</b>"

    End Sub


End Class
