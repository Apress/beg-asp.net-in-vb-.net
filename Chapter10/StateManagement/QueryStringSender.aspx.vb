Public Class QueryStringSender
    Inherits System.Web.UI.Page
    Protected WithEvents lstItems As System.Web.UI.WebControls.ListBox
    Protected WithEvents chkDetails As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblError As System.Web.UI.WebControls.Label
    Protected WithEvents cmdGo As System.Web.UI.WebControls.Button

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


    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Add sample values.
        lstItems.Items.Add("Econo Sofa")
        lstItems.Items.Add("Supreme Leather Drapery")
        lstItems.Items.Add("Threadbare Carpet")
        lstItems.Items.Add("Antique Lamp")
        lstItems.Items.Add("Retro-Finish Jacuzzi")
    End Sub

    Private Sub cmdGo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGo.Click
        If lstItems.SelectedIndex = -1 Then
            lblError.Text = "You must select an item."
        Else
            ' Forward the user to the information page.
            Dim Url As String = "QueryStringRecipient.aspx?"
            Url &= "Item=" & lstItems.SelectedItem.Text & "&"
            Url &= "Mode=" & chkDetails.Checked.ToString()
            Response.Redirect(Url)
        End If
    End Sub

End Class
