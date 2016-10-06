Public Class EventTracker
    Inherits System.Web.UI.Page
    Protected WithEvents lstEvents As System.Web.UI.WebControls.ListBox
    Protected WithEvents chk As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txt As System.Web.UI.WebControls.TextBox
    Protected WithEvents opt1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents opt2 As System.Web.UI.WebControls.RadioButton

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
        Log("<< Page_Load >>")
    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
        ' When the Page.UnLoad event occurs it is too late to change the list box.
        Log("Page_PreRender")
    End Sub

    Private Sub chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles chk.CheckedChanged, opt1.CheckedChanged, opt2.CheckedChanged, txt.TextChanged
        ' Find the control ID of the sender.
        ' This requires converting the Object type into a Control class.
        Dim ctrlName As String = CType(sender, Control).ID
        Log(ctrlName & " Changed")
    End Sub

    Private Sub Log(ByVal entry As String)
        lstEvents.Items.Add(entry)

        ' Select the last item to scroll the list so the most recent entries are visible.
        lstEvents.SelectedIndex = lstEvents.Items.Count - 1
    End Sub

End Class
