Public Class HashTableBinding
    Inherits System.Web.UI.Page
            Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents MyListBox As System.Web.UI.WebControls.ListBox

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
        'Put user code to initialize the page here
        If Page.IsPostBack = False Then
            Session("me") = "fi"
            ' Create and fill the collection.
            Dim colFruit As New Hashtable()
            colFruit.Add(1, "Kiwi")
            colFruit.Add(2, "Pear")
            colFruit.Add(3, "Mango")
            colFruit.Add(4, "Blueberry")
            colFruit.Add(5, "Apricot")
            colFruit.Add(6, "Banana")
            colFruit.Add(7, "Peach")
            colFruit.Add(8, "Plum")

            ' Define the binding for the list controls.
            MyListBox.DataSource = colFruit
            MyListBox.DataTextField = "Value"
            MyListBox.DataValueField = "Key"

            ' Activate the binding.
            Me.DataBind()
        End If
    End Sub

    Private Sub MyListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyListBox.SelectedIndexChanged
        lblMessage.Text = "You picked: " & MyListBox.SelectedItem.Text
        lblMessage.Text &= " which has the key: " & MyListBox.SelectedItem.Value
    End Sub

End Class
