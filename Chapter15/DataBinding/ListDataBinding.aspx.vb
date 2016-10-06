Public Class ListDataBinding
    Inherits System.Web.UI.Page
    Protected WithEvents MyListBox As System.Web.UI.WebControls.ListBox
    Protected WithEvents MyDropDownListBox As System.Web.UI.WebControls.DropDownList
        Protected WithEvents MyCheckBoxList As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents MyRadioButtonList As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents MyHTMLSelect As System.Web.UI.HtmlControls.HtmlSelect
            Protected WithEvents MyRepeater As System.Web.UI.WebControls.Repeater

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
        Session("me") = "fi"
        ' Create and fill the collection.
        Dim colFruit As New Collection()
        colFruit.Add("Kiwi")
        colFruit.Add("Pear")
        colFruit.Add("Mango")
        colFruit.Add("Blueberry")
        colFruit.Add("Apricot")
        colFruit.Add("Banana")
        colFruit.Add("Peach")
        colFruit.Add("Plum")

        ' Define the binding for the list controls.
        MyListBox.DataSource = colFruit
        MyDropDownListBox.DataSource = colFruit
        MyHTMLSelect.DataSource = colFruit
        MyCheckBoxList.DataSource = colFruit
        MyRadioButtonList.DataSource = colFruit

        ' Activate the binding.
        Me.DataBind()

    End Sub

End Class
